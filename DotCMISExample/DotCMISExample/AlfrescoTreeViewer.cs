using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotCMIS;
using DotCMIS.Client;
using DotCMIS.Client.Impl;
using DotCMIS.Data;
using DotCMIS.Data.Impl;

namespace DotCMISExample
    {
    public partial class AlfrescoTreeViewer : Form
        {
        private string alfrscoServerURL = "http://localhost:2020/";
        private string userName = "admin";
        private string password = "admin";
        ISession session = null;
        public AlfrescoTreeViewer()
            {
            InitializeComponent();
            }

        private void AlfrescoTreeViewer_Load(object sender, EventArgs e)
            {
            this.WindowState = FormWindowState.Maximized;
            }

        private void btnView_Click(object sender, EventArgs e)
            {


            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters[DotCMIS.SessionParameter.BindingType] = BindingType.AtomPub;
            parameters[DotCMIS.SessionParameter.AtomPubUrl] =  alfrscoServerURL + "alfresco/api/-default-/public/cmis/versions/1.0/atom";
            parameters[DotCMIS.SessionParameter.User] = userName;
            parameters[DotCMIS.SessionParameter.Password] = password;
            SessionFactory factory = SessionFactory.NewInstance();
              session = factory.GetRepositories(parameters)[0].CreateSession();
            IFolder rootFolder = session.GetRootFolder();

            //IFolder rootFolder = session.GetObject(rootFolderId) as IFolder;

            // list all children

            TreeNode rootNode = treeView1.Nodes.Add("Alfresco Root");
            AddTreeNode(rootFolder, rootNode);
            }

        private void AddTreeNode(IFolder rootFolder,TreeNode node)
            {
            foreach (ICmisObject cmisObject in rootFolder.GetChildren())
                {

                try
                    {
                        IFolder folder = cmisObject as IFolder;
                        if (folder != null)
                        {
                            TreeNode currentNode = node.Nodes.Add(cmisObject.Id, cmisObject.Name);
                            Application.DoEvents();
                            AddTreeNode(folder, currentNode);
                        }


                    }
                catch (Exception ex)
                    {

                    }
                }
            }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
            {
                if (e.Node.Text != "Alfresco Root")
                {

                    string path = e.Node.FullPath.Replace("Alfresco Root", "");
                    IFolder selectedFolder = session.GetObject(e.Node.Name) as IFolder;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Id");

                    DataRow documentRow = null;
                         
                    foreach (ICmisObject cmisObject in selectedFolder.GetChildren())
                    {
                    if (cmisObject.GetType() != typeof(DotCMIS.Client.Impl.Folder))
                        { 
                        documentRow = dt.NewRow();
                        documentRow["Name"] = cmisObject.Name;
                        documentRow["Id"] = cmisObject.Id;
                        dt.Rows.Add(documentRow);
                        }
                    }

                    if (dt.Rows.Count > 0)
                    {
                        folderDetailsGrid.AutoGenerateColumns = true;
                        folderDetailsGrid.DataSource = dt;
                        folderDetailsGrid.Refresh();
                    }
                }
            }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var currentRow = folderDetailsGrid.SelectedRows[0];
            string fileName = Convert.ToString(currentRow.Cells[0].Value);
            string objectId = Convert.ToString(currentRow.Cells[1].Value);
            try
                {

                    Document doc = session.GetObject(objectId) as Document;
                    ContentStream contentStream = (DotCMIS.Data.Impl.ContentStream)doc.GetContentStream();
                    using (var fileStream = File.Create(@".\" + contentStream.FileName))
                    {
                        contentStream.Stream.CopyTo(fileStream);
                    }
                    MessageBox.Show("File " + contentStream.FileName + " downloaded successfully");
                }catch(Exception ex)
                {
                    MessageBox.Show("File " + fileName + " download failed." + ex.Message);
                }
            }
        }
    }
