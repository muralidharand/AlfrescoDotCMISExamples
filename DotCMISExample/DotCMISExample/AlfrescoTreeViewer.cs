using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotCMIS;
using DotCMIS.Client;
using DotCMIS.Client.Impl;

namespace DotCMISExample
    {
    public partial class AlfrescoTreeViewer : Form
        {
        public AlfrescoTreeViewer()
            {
            InitializeComponent();
            }

        private void AlfrescoTreeViewer_Load(object sender, EventArgs e)
            {
            }

        private void btnView_Click(object sender, EventArgs e)
            {

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters[DotCMIS.SessionParameter.BindingType] = BindingType.AtomPub;
            parameters[DotCMIS.SessionParameter.AtomPubUrl] = "http://localhost:8080/alfresco/api/-default-/public/cmis/versions/1.0/atom";
            parameters[DotCMIS.SessionParameter.User] = "admin";
            parameters[DotCMIS.SessionParameter.Password] = "admin";
            SessionFactory factory = SessionFactory.NewInstance();
            ISession session = factory.GetRepositories(parameters)[0].CreateSession();
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
                        TreeNode currentNode = node.Nodes.Add(cmisObject.Name);
                        Application.DoEvents();
                        AddTreeNode(folder, currentNode);  


                    }
                catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
