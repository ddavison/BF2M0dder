/*
** 
** Programmer: Daniel Davison
 *
** Date Created: 1/1/2010
 * 
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using ICSharpCode.SharpZipLib.Zip;
using SyntaxHighlighter;

namespace BF2_M0dd3r
{
    
	/// <summary>
	/// Description of MainForm.
	/// </summary>
    public partial class BF2Modder : Form
    {


        BF2MConstants _const = new BF2MConstants();
        svSettings serverSettings = new svSettings();

        #region "globals"

        // STRINGS
        string curFile = "";
        string userName = "";
        string modName = "";
        Node rootNode = new Node("Current Mod");
        string selPath = "";
        string editedChar = " [*]";
        string selPathAndFile = "";
        string appDir;
        List<string> originalContent;

        // -> PATHS
        string tmpPath;
        string pluginsPath;
        string modPath;
        string sharedPath;
        string restPath;
        string zipPath;
        string curPath = "";

        // -> FILES
        string addFile;
        string netFile;
        string configFile;
        string botNamesFile;
        string currentFile = "";

        // BOOLEANS
        bool hasChanged = false;
        bool isLoaded = false; //this var detects if they have imported a file... if not, then it wont display the save feature.
        bool modLoaded = false;
        bool isFirstTime = true;
        bool isStarting = false;

        string[] allowedLoadFiles = { ".inc", ".con", ".tweak", ".desc", ".ai", ".txt" };

        Image pluginImage = BF2_M0dd3r.Properties.Resources.compactflash;
        SyntaxRichTextBox edit = new SyntaxRichTextBox();

        SyntaxRichTextBox curEdit = new SyntaxRichTextBox();

        #endregion

        string[] args;

        public BF2Modder(string[] argv)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //

            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //

            args = argv;

        }

        // Mail to support...

        private MailAddress fromAddress = new MailAddress("no-reply@sircapsalot.net", "SCA.NET Support Service");
        private MailAddress toAddress = new MailAddress("support@sircapsalot.net");

        // ---------------------

        private void mouseDrag(object sender, MouseEventArgs e)
        {

        }

        void importZip()
        {
            try
            {
                
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    string pth = cd.SelectedPath;
                    selPathAndFile = pth + "\\mods\\bf2\\Objects_server.zip";

                    //copy the zip over...

                    if (!File.Exists(pth + "\\mods\\bf2\\Objects_server.zip"))
                    {
                        MessageBoxEx.Show("You have selected an invalid Battlefield 2 Installation Directory. Please select a correct path.\n\nIf you are sure that it is the correct Battlfield 2 installation directory, then please make sure that you have an Objects_server.zip inside of the directory\\mods\\bf\\Objects_server.zip.\n\nPlease contact support@sircapsalot.net if you continue to have problems.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        //store the path in the conf file...
                        File.WriteAllText(configFile, cd.SelectedPath);

                        selPath = cd.SelectedPath;

                        if (Directory.Exists(tmpPath))
                        {

                        }
                        else
                            Directory.CreateDirectory(tmpPath);


                        //lets copy the mod ...

                        if (Directory.Exists(selPath + "\\mods\\bf2modder"))
                        {
                            if (MessageBoxEx.Show("The BF2 Modder mod already exists. Would you still like to run the batch?", "BF2 Modder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                creatingModFolder creating = new creatingModFolder(selPath + "\\mods\\bf2", selPath + "\\mods\\bf2modder", false);

                                creating.ShowDialog();
                            }
                            else
                            {
                                creatingModFolder creating = new creatingModFolder(selPath + "\\mods\\bf2", selPath + "\\mods\\bf2modder", true);

                                creating.ShowDialog();
                            }
                        }
                        else
                        {
                            creatingModFolder creating = new creatingModFolder(selPath + "\\mods\\bf2", selPath + "\\mods\\bf2modder", false);

                            creating.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                _const.handleError("There was an error while trying to import your mod! :: " + x.Message, true);
            }
        }


        void fillDirectories(string zippath)
        {

            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            if (modLoaded)
                closeTheMod();


            //then continue...

            List<string> contentList = new List<string>();

            try
            {

                if (zippath == "")
                {
                    zippath = appDir + @"\tmp\Objects_server.zip";
                    modName = "Default Mod";
                }
                else
                {
                    //ok, it will be, for example, \\sircapsalot\BF2 Shared M0ds\Objects_server(doucheMod).zip

                    // now is Objects_server(doucheMod).zip

                }

                fileHolder.Tag = zippath;

                if (modName != "Default Mod")
                    modName = Path.GetFileName(zippath);

                file.Nodes.Clear();

                if (!File.Exists(zipPath))
                {
                    MessageBoxEx.Show("Please load the archive before refreshing.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // M0d Comments Node

                    file.Nodes.Add(rootNode);

                    Node modComments = new Node("Mod Comments.tweak");

                    rootNode.Nodes.Add(modComments);



                    ZipFile zf = null;

                    try
                    {
                        FileStream fs = File.OpenRead(zippath);

                        zf = new ZipFile(fs);

                        foreach (ZipEntry ent in zf)
                        {
                            if (!ent.IsFile)
                            {
                                continue;
                            }
                            else
                            {
                                if (!contentList.Contains(ent.Name))
                                {
                                    String entName = ent.Name;
                                    contentList.Add(entName);
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (zf != null)
                        {
                            zf.IsStreamOwner = true;
                            zf.Close();
                        }
                    }

                    //show loading form...

                    //Form loading = new Loading();
                    //loading.ShowDialog();

                    //after the list of contents is stored...output

                    // **** TESTING **** \\

                    foreach (string pathName in contentList)
                    {

                        string folder = Path.GetDirectoryName(pathName);
                        string[] parts = folder.Split('\\');

                        Node node = rootNode;
                        Node childNode = node;


                        foreach (string folderPart in parts)
                        {

                            int n = node.Nodes.Count;

                            childNode = (n == 0) ? new Node() : node.Nodes[n - 1];

                            if (childNode.Text != folderPart)
                            {
                                childNode = new Node(folderPart);
                                node.Nodes.Add(childNode);
                            }
                            node = childNode;

                        }

                        string filename = Path.GetFileName(pathName);
                        childNode.Nodes.Add(new Node(filename));

                    }

                    // **************** \\

                    //REAL 
                    //foreach (string pathName in contentList)
                    //{

                    //    //it's a directory...

                    //    string folder = Path.GetDirectoryName(pathName);

                    //    //get the files in the folder.

                    //    Node prnt = new Node();
                    //    prnt.Text = folder;
                    //    prnt.ImageIndex = 0;


                    //    rootNode.Nodes.Add(prnt);


                    //    Fill(prnt, pathName);


                    //}

                    modLoaded = true;

                    contentList = new List<string>();

                    // clear the content list.
                    for (int i = 0 ; i < contentList.Count ; i++)
                    {
                        contentList[i] = String.Empty;
                    }
                }
            }
            catch (Exception x)
            {
                _const.handleError("There was an error filling the nodes!" + x.Message, true);
            }

            modLoaded = true;
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
        }


        void extract(string sArchiveIn, string outFolder, string selectName) //archive in will always be zipPath, outfolder will always be tmp and selectName will be the nodes.SelectedNode.Text.
        {

            ZipFile zf = null;
            try
            {
                FileStream fs = File.OpenRead(sArchiveIn);
                zf = new ZipFile(fs);

                foreach (ZipEntry theEntry in zf)
                {
                    if (!theEntry.IsFile)
                    {
                        continue;
                    }

                    String entryFileName = Path.GetFileName(theEntry.Name);

                    if (String.Compare(entryFileName, selectName, true) != 0)
                        continue;

                    byte[] buffer = new byte[4096];

                    Stream zipStream = zf.GetInputStream(theEntry);

                    String fullZipToPath = Path.Combine(outFolder, entryFileName);

                    MessageBoxEx.Show("Extracting " + fullZipToPath);

                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        //writ eht buffer...
                        // streamWriter.Write(buffer, 0, fileSize);
                        ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(zipStream, streamWriter, buffer);
                    }
                    break;
                }


            }
            finally
            {
                if (zf != null)
                {
                    zf.IsStreamOwner = true;
                    zf.Close();
                }
            }
        }

        void Fill(Node node, string pathName)
        {
            try
            {
                string filename = Path.GetFileName(pathName);

                Node chld = new Node();

                chld.Text = filename;
                chld.ImageIndex = 1;

                node.Nodes.Add(chld);
            }
            catch (Exception x)
            {
                _const.handleError("There was an error filling the parent node! :: " + x.Message, true);
            }
        }

        void btnLoadArchiveClick(object sender, EventArgs e)
        {
            if (!btnLoadArchive.Checked)
            {
                importZip();
            }
            else
            {
                string msg = "Would you like to select a new location for your Battlefield 2 Directory?\n\nNOTE: If you click yes, it will delete your mod directory, including all of the settings you had for the maps, and bots. Your mods however, will not delete.\n\n\t Would you like to continue?";

                if (Directory.Exists(selPath + "\\mods\\bf2modder"))
                {
                    if (MessageBoxEx.Show(msg, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // they wanna select a new location. Delete the directory, and delete the modCreated.cfg so it will enable the load archive button...
                        Directory.Delete(selPath + "\\mods\\bf2modder", true);
                        File.Delete(appDir + "\\modCreated.cfg");

                        btnLoadArchive.Checked = false;
                    }
                    else
                    {
                    }
                }
                else
                    btnLoadArchive.Checked = false;
            }
        }

        void ListView1SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void FileAfterSelect(object sender, TreeViewEventArgs e) // XXX_FileAfterSelect
        {
            //after the user selects something ending with .con show the code on the right //XXXFileAfterSelect

        }

        bool canLoad(string fileName)
        {
            foreach (string fileExt in allowedLoadFiles)
            {
                if (fileName.EndsWith(fileExt))
                {
                    return (true);
                }
            }

            return (false);
        }



        //void loadFile()
        //{
        //    try
        //    {
        //        this.Cursor = System.Windows.Forms.Cursors.WaitCursor;


        //        only do the following if it hasn't been changed...
        //        if (!hasChanged)
        //        {
        //            if (canLoad(file.SelectedNode.Text))
        //            {
        //                extract(fileHolder.Tag.ToString(), tmpPath, file.SelectedNode.Text);


        //                createNewFile(file.SelectedNode, true);


        //            }
        //            else
        //            {
        //                could be media file...

        //                if (file.SelectedNode.Text.EndsWith(".wav"))
        //                {
        //                    extract(fileHolder.Tag.ToString(), tmpPath, file.SelectedNode.Text);

        //                    then execute, 

        //                    string medPath = tmpPath + "\\" + file.SelectedNode.Text;
        //                    mediaEditor newEdit = new mediaEditor(medPath);
        //                    newEdit.ShowDialog();

        //                    if (File.Exists("bf2mrepl.cfg"))
        //                    {
        //                        MessageBox.Show("Replacing...");
        //                        if (File.Exists("bf2mrepl.cfg"))
        //                        {
        //                            try
        //                            {
        //                                string repl = File.ReadAllText("bf2mrepl.cfg");

        //                                File.Replace(tmpPath + "\\" + file.SelectedNode.Text, repl, null);
        //                            }
        //                            catch (Exception x)
        //                            {
        //                                _const.handleError("Could not replace the file.\n\n\t" + x.Message, false);
        //                            }
        //                            replace the tmp with that,
        //                            delete tmp
        //                            File.Delete("bf2mrepl.cfg");
        //                        }
        //                        else
        //                        {
        //                        }
        //                    }
        //                    else
        //                    {
        //                        they aren't replacing, dont do anything...

        //                    }

        //                }
        //                else if (file.SelectedNode.Text.EndsWith(".ogg"))
        //                {
        //                    extract(fileHolder.Tag.ToString(), tmpPath, file.SelectedNode.Text);

        //                    then execute, 

        //                    string medPath = tmpPath + "\\" + file.SelectedNode.Text;
        //                    mediaEditor newEdit = new mediaEditor(medPath);

        //                    newEdit.ShowDialog();
        //                }
        //                else
        //                {
        //                    nope, neither media or regular file...
        //                }
        //            }
        //        }
        //        else
        //        {
        //            has changed...
        //            DialogResult re = MessageBoxEx.Show("Save Changes?", "Save your changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //            if (re == DialogResult.Yes)
        //            {
        //                saveFile();
        //            }

        //            hasChanged = false;

        //            if (file.SelectedNode.Text.IndexOf(".con") <= 0)
        //            {
        //            }
        //            else
        //            {
        //                edit.Clear();
        //                string confiletext = File.ReadAllText("\\tmp\\" + file.SelectedNode.Text);
        //                edit.Text = confiletext;

        //                isLoaded = true;

        //                MessageBoxEx.Show("\\tmp" + file.SelectedNode.FullPath.Remove(0, 10).ToString());
        //            }

        //            if (file.SelectedNode.Text.IndexOf(".tweak") <= 0)
        //            {
        //            }
        //            else
        //            {
        //                edit.Clear();
        //                string confiletext = File.ReadAllText("\\tmp\\" + file.SelectedNode.Text);


        //                edit.Text = confiletext;


        //                isLoaded = true;
        //            }
        //        }
        //        this.Cursor = System.Windows.Forms.Cursors.Arrow;

        //    }
        //    catch (Exception ex)
        //    {
        //        createNewFile(file.SelectedNode, false);
        //    }

        //    blah
        //}

        private void createNewFile(Node no, bool exists)
        {
            try
            {
                string confiletext = "";

                if (exists)
                    confiletext = File.ReadAllText(tmpPath + "\\" + no.Text);
                else
                {
                    File.WriteAllText(tmpPath + "\\" + no.Text, "");
                    confiletext = File.ReadAllText(tmpPath + "\\" + no.Text);
                }



                int i = tabs.Tabs.Count + 1;

                TabItem newTab = tabs.CreateTab(no.Text, (tabs.Tabs.Count - 1));

                newTab.Name = no.Text;



                newTab.Click += new EventHandler(newTab_Click);
                newTab.MouseUp += new MouseEventHandler(newTab_MouseUp);

                SyntaxRichTextBox pages = new SyntaxRichTextBox();

                pages.KeyUp += new KeyEventHandler(fileChanged);

                pages.GotFocus += new EventHandler(page_GotFocus);

                pages.Text = confiletext;

                pages.AcceptsTab = true;
                pages.Dock = DockStyle.Fill;
                pages.BorderStyle = BorderStyle.None;

                pages.ShortcutsEnabled = true;
                pages.ShowSelectionMargin = true;

                pages.Settings.Comment = "rem";
                pages.Settings.CommentColor = Color.Green;

                pages.Settings.EnableIntegers = true;
                pages.Settings.EnableComments = true;
                pages.Settings.EnableStrings = true;

                pages.Settings.IntegerColor = Color.Red;
                pages.Settings.KeywordColor = Color.Blue;

                pages.Settings.Keywords.Add("ObjectTemplate");
                pages.Settings.Keywords.Add("WorldTemplate");
                pages.Settings.Keywords.Add("CollisionManager");
                pages.Settings.Keywords.Add("GeometryTemplate");
                pages.Settings.Keywords.Add("include");
                pages.CompileKeywords();


                string newTag = (no.FullPath.Remove(0, rootNode.Text.Length));

                newTag = newTag.Replace(";", "\\");
                newTab.Tag = (newTag);

                // now i have to add pages to newTab

                newTab.AttachedControl.Controls.Add(pages);

                try
                {
                    if (pages.Lines[0].Contains("Bf2Editor.exe"))
                    {

                        string newstr = "rem -- edited using " + Application.ProductName + " [ " + DateTime.Now + " ] --";


                        string[] newtext = pages.Lines;

                        newtext[0] = newstr;

                        pages.Lines = newtext;
                    }
                    else if (pages.Lines[0].Contains(Application.ProductName))
                    {
                        string newstr = "rem -- edited using " + Application.ProductName + " [ " + DateTime.Now + " ] --";

                        string[] newtext = pages.Lines;

                        newtext[0] = newstr;

                        pages.Lines = newtext;

                    }
                    else
                    {
                        try
                        {
                            string newstr = "rem -- edited using " + Application.ProductName + " [ " + DateTime.Now + " ] --";

                            string[] newtext = new string[pages.Lines.Length + 2];

                            for (int l = 0 ; l < pages.Lines.Length ; l++)
                            {
                                newtext[l + 2] = pages.Lines[l]; //what this does is for each line, it will make it the third line instead then continue on.
                            }

                            newtext[0] = newstr;
                            newtext[1] = "";



                            pages.Lines = newtext;
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }
            }
            finally
            {
                isLoaded = true;
            }

        }

        void fileChanged(object sender, KeyEventArgs e)
        {
            if (tabs.SelectedTab.Text.Contains(editedChar))
            {

            }
            else
                tabs.SelectedTab.Text += editedChar;
        }

        void newTab_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                TabItem senderr = (TabItem)sender;

                string whatToSearchFor = senderr.Text;

                tabs.Tabs.Remove(senderr);
            }
        }

        void newTab_Click(object sender, EventArgs e)
        {
            TabItem ne = (TabItem)sender;
        }

        void page_GotFocus(object sender, EventArgs e)
        {
            curEdit = (SyntaxRichTextBox)sender;

            if (tabs.SelectedTab.Text.EndsWith(editedChar))
                curFile = tabs.SelectedTab.Text.Remove((tabs.SelectedTab.Text.Length - editedChar.Length), editedChar.Length);
            else
                curFile = tabs.SelectedTab.Text;

        }

        void saveFile()
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                //TODO: Save the current FILE

                if (isLoaded)
                {
                    File.WriteAllText(appDir + @"\tmp\" + curFile, curEdit.Text);

                    if (curFile == "Mod Comments.tweak")
                    {
                        string savedPath = "\\";

                        comp(fileHolder.Tag.ToString(), savedPath);

                    }
                    else
                    {



                        apply(); //apply the mods into the thingy...

                        hasChanged = false;
                    }
                }
                else
                {
                    //MessageBox.Show("notloaded");
                }

                this.Cursor = System.Windows.Forms.Cursors.Arrow;
            }
            catch (Exception x)
            {
                _const.handleError("Could not save file! :: " + x.ToString(), true);
            }
        }

        void MainFormLoad(object sender, EventArgs e)
        {



            try
            {
                //declare teh form object.
                isStarting = true;

                appDir = _const.InstallPath;

                tmpPath = _const.dirTmpDirectory;
                pluginsPath = _const.dirPluginsDirectory;
                modPath = _const.dirModsDirectory;
                sharedPath = _const.dirSharedDirectory;
                zipPath = _const.fileZipFile;
                restPath = _const.dirRestoreDirectory;
                addFile = _const.fileAddFile;
                netFile = _const.fileNetFile;
                configFile = _const.fileConfigFile;
                botNamesFile = _const.fileBotNamesFile;




                tabs.Tabs.Clear();


                if (!Directory.Exists(pluginsPath))
                {
                    Directory.CreateDirectory(pluginsPath);
                }
                else
                {
                }

                if (!Directory.Exists(modPath))
                {
                    Directory.CreateDirectory(modPath);
                }

                if (!File.Exists(addFile))
                {
                    File.WriteAllText(addFile, "");
                }

                if (!File.Exists(appDir + @"\participation.cfg"))
                {
                    registerProductToolStripMenuItem.Checked = false;
                    registerProductToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                }
                else
                {
                    if (File.ReadAllText(appDir + @"\participation.cfg") != "")
                    {
                        // They are participating...
                        userName = File.ReadAllText(appDir + @"\nm.cfg");

                        registerProductToolStripMenuItem.Checked = true;
                        registerProductToolStripMenuItem.ForeColor = Color.SteelBlue;
                    }
                    else
                    {
                        registerProductToolStripMenuItem.Checked = false;
                        registerProductToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                    }
                }

                sv.SelectedObject = serverSettings;

                if (!File.Exists(configFile))
                {
                    File.Create(configFile);
                }
                else
                {
                    selPath = File.ReadAllText(configFile);
                }

                if (!File.Exists(botNamesFile))
                {
                    File.Create(botNamesFile);
                }

                if (File.ReadAllText(addFile).Contains("playerName"))
                {
                    //they are using additional parameters, check it...
                    automaticLoginOnStartupToolStripMenuItem.Checked = true;
                    automaticLoginOnStartupToolStripMenuItem.ForeColor = Color.SteelBlue;
                }
                else
                {
                    automaticLoginOnStartupToolStripMenuItem.Checked = false;
                    automaticLoginOnStartupToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                }

                if (!File.Exists(netFile))
                {
                    File.WriteAllText(netFile, "0");
                    enableNetworkingToolStripMenuItem1.Checked = false;
                    enableNetworkingToolStripMenuItem1.ForeColor = Control.DefaultForeColor;
                }
                else
                {
                    string b = File.ReadAllText(netFile);

                    if (b == "0")
                    {
                        enableNetworkingToolStripMenuItem1.Checked = false;
                        enableNetworkingToolStripMenuItem1.ForeColor = Control.DefaultForeColor;
                    }
                    else if (b == "1")
                    {
                        enableNetworkingToolStripMenuItem1.Checked = true;
                        enableNetworkingToolStripMenuItem1.ForeColor = Color.SteelBlue;

                        // ......

                        pluginsTimer.Enabled = true;

                        refreshMyNetwork(null, null);

                    }
                    else
                    {
                        _const.handleError("Please do not tamper with config files.", false);
                    }
                }



                // PERFORM TESTS

                testFunctions();

                // -------------------
                if (!Directory.Exists(tmpPath))
                {
                    isFirstTime = true;
                    MessageBoxEx.Show("Welcome to BF2 Modder!\n\nFor any help or information, please refer to the YouTube video by searching \"BF2 Modder\" on YouTube, or for further help...\n\nplease email support@sircapsalot.net for support.", "Welcome to BF2 Modder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Directory.CreateDirectory(tmpPath);
                }
                else
                {
                    isFirstTime = false;
                }

                if (!Directory.Exists(modPath))
                {
                    Directory.CreateDirectory(modPath);
                }

                file.Nodes.Add(new Node(" [ double click to refresh ] "));

                parsingTimer.Enabled = true;

                //I

                populateMods();

                initializeConfigReader();

                isStarting = false;
            }
            catch (Exception x)
            {
                _const.handleError("There was an error during startup! :: " + x.Message, true);
            }
        }

        void initializeConfigReader()
        {
            if (!stat.Enabled)
            {
                stat.Enabled = true;
            }

        }

        void RefreshBasedOn(object sender, EventArgs e)
        {
            populateMods();
            basedOnMenu.ShowSubItems = true;
        }

        void populateMods()
        {

            applyModToolStripMenuItem.DropDownItems.Clear();
            selectMod.SubItems.Clear();

            basedOnMenu.SubItems.Clear();

            // Current Open Mod
            ToolStripMenuItem currentMod = (ToolStripMenuItem)applyModToolStripMenuItem.DropDownItems.Add("Current Open Mod");
            currentMod.Image = new Bitmap(BF2_M0dd3r.Properties.Resources.Journal);
            currentMod.Click += new System.EventHandler(this.currentOpenModToolStripMenuItem_Click);

            currentMod.ShortcutKeys = Keys.F5;

            applyModToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            //----------------------

            // Refresh Apply Mod
            ToolStripItem blah = applyModToolStripMenuItem.DropDownItems.Add("Refresh...");
            blah.Click += new System.EventHandler(this.RefreshApplyMods);
            applyModToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            // ---------------------

            // Refresh Select Mod

            ButtonItem blah2 = new ButtonItem("", "Refresh...");
            blah2.ButtonStyle = eButtonStyle.ImageAndText;

            selectMod.SubItems.Add(blah2);

            blah2.Click += new System.EventHandler(this.RefreshSelectMods);
            // ----------------------

            // create new mod based on...
            ButtonItem nm = new ButtonItem("", "huh?");
            nm.ButtonStyle = eButtonStyle.ImageAndText;
            basedOnMenu.SubItems.Add(nm);
            nm.Click += new System.EventHandler(this.RefreshBasedOn);
            // --------------------------------
            DirectoryInfo di = new DirectoryInfo(modPath);

            //get the image for the mods...
            Image modImg = BF2_M0dd3r.Properties.Resources.Journal;

            foreach (FileInfo fi in di.GetFiles("*.zip"))
            {

                ToolStripMenuItem it = (ToolStripMenuItem)applyModToolStripMenuItem.DropDownItems.Add(fi.Name, modImg);
                it.Click += new System.EventHandler(this.menuClick);

                //ToolStripItem del = it.DropDownItems.Add("Delete [ " + fi.Name + " ] ");
                //del.Click += new System.EventHandler(this.deleteMod);

                //ToolStripItem ff = it.DropDownItems.Add("Export [ " + fi.Name + " ] ");
                //ff.Click += new System.EventHandler(this.clickExport);

                //---------------------------

                ButtonItem itt = new ButtonItem("", fi.Name);
                itt.ButtonStyle = eButtonStyle.ImageAndText;
                itt.Image = BF2_M0dd3r.Properties.Resources.Book_angleHS;
                itt.Tag = fi.FullName;

                selectMod.SubItems.Add(itt);
                itt.Click += new System.EventHandler(this.loadMod);


                ButtonItem nmm = new ButtonItem("", fi.Name);
                basedOnMenu.SubItems.Add(nmm);
                nmm.ButtonStyle = eButtonStyle.ImageAndText;
                nmm.Image = BF2_M0dd3r.Properties.Resources.Book_angleHS;
                nmm.Click += new System.EventHandler(this.basedOnMod);

                if (enableNetworkingToolStripMenuItem1.Checked)
                {

                    ButtonItem df = new ButtonItem("", "Export " + fi.Name);
                    df.Tag = fi.Name;
                    df.ButtonStyle = eButtonStyle.ImageAndText;

                    itt.SubItems.Add(df);
                    df.Click += new System.EventHandler(this.clickExport);
                }

                ButtonItem dell = new ButtonItem("", "Delete " + fi.Name);
                dell.Tag = fi.Name;
                dell.ButtonStyle = eButtonStyle.ImageAndText;

                itt.SubItems.Add(dell);
                dell.Click += new System.EventHandler(this.deleteMod);
            }

            ButtonItem openInExp = new ButtonItem("", "Open in Explorer");
            selectMod.SubItems.Add(openInExp);
            openInExp.ButtonStyle = eButtonStyle.ImageAndText;
            openInExp.Click += new System.EventHandler(this.openModFolderInExplorer);
        }

        void openModFolderInExplorer(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Windows\explorer.exe", appDir + @"\mods");
            }
            catch
            {
                _const.handleError("Couldn't open in explorer...", false);
            }
        }

        void basedOnMod(object sender, EventArgs e)
        {
            try
            {
                //this creates from an existing mod...

                ToolStripMenuItem senderr = (ToolStripMenuItem)sender;

                string existingModName = senderr.Text;

                try
                {
                    //File.Copy(modPath + "\\Objects_server(" + existingModName + ").zip", zipPath, true);

                    file.Nodes.Clear();
                    tabs.Tabs.Clear();

                    if (!File.Exists(zipPath))
                    {
                        MessageBoxEx.Show("You need to import the archive before creating a new mod.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // delete the zipPath...

                        File.Delete(zipPath);

                        //then recopy,

                        if (selPath == "")
                        {
                            MessageBoxEx.Show("You need to import the archive before creating a new mod.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            File.Copy(modPath + "\\" + existingModName, zipPath, true);

                            //it's copied, now fill...


                            fillDirectories("");

                            modLoaded = true;
                        }
                    }
                }
                catch (Exception x)
                {
                    _const.handleError("There was an error while trying to create a new mod based on the " + existingModName + " mod.\n\n\t - " + x.Message, false);
                }
            }
            catch (Exception x)
            {
                _const.handleError("There was an unknown error while trying to create a mod based on another!\n\n\t" + x.Message, true);
            }
        }

        void clickExport(object sender, EventArgs e)
        {
            ButtonItem senderr = (ButtonItem)sender;

            string realName = senderr.Tag.ToString();

            //now it is "Objects_server(blah).zip"

            exportMod(realName);
        }

        private void exportMod(string modName)
        {
            if (!Directory.Exists(sharedPath))
            {
                Directory.CreateDirectory(sharedPath);
            }

            string origModPath = modPath + "\\" + modName; // modPath + "Original_server(blah).zip"

            //copy to shared...
            try
            {
                string destFileName = sharedPath + "\\" + modName;

                if (File.Exists(destFileName))
                {
                    if (MessageBoxEx.Show("Overwrite Existing Mod?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Copy(origModPath, destFileName, true);
                        MessageBoxEx.Show("Mod Exported to Shared Mods", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
                else
                {
                    File.Copy(origModPath, destFileName);
                    MessageBoxEx.Show("Mod Exported to Shared Mods", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception x)
            {
                x.ToString();
                _const.handleError("There was a problem exporting the mod.\n\n Message Follows: \n\n\t" + x.Message, true);

            }
        }

        void deleteMod(object sender, EventArgs e)
        {
            ButtonItem senderr = (ButtonItem)sender;
            string realName = senderr.Tag.ToString();

            //now it is "Objects_server(blah).zip ] "

            if (MessageBoxEx.Show("Are you sure you want to delete the mod \"" + realName + "\" ?", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(modPath + "\\" + realName))
                    {
                        File.Delete(modPath + "\\" + realName);

                        RefreshSelectMods(null, null);

                    }
                    else
                    {
                        _const.handleError("Could not delete " + realName + "...", false);
                    }
                }
                catch (Exception x)
                {
                    x.ToString();

                    _const.handleError("Could not delete " + realName + "...", false);
                }
            }
            else
            {
                //do nothing...
            }
        }

        void RefreshSelectMods(object sender, EventArgs e)
        {
            populateMods();
            selectMod.Popup(MousePosition.X, MousePosition.Y);
        }

        void RefreshMods(object sender, EventArgs e)
        {

        }

        void RefreshApplyMods(object sender, EventArgs e)
        {
            populateMods();
            applyModToolStripMenuItem.ShowDropDown();
        }

        void loadMod(object sender, EventArgs e)
        {

            ButtonItem senderr = (ButtonItem)sender;

            modName = senderr.Text;

            fillDirectories(senderr.Tag.ToString());

        }

        void menuClick(object sender, EventArgs e)
        {
            string modName = sender.ToString();

            if (selPath == "")
            {
                MessageBoxEx.Show("You need to import the archive before applying a mod.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Apply applying = new Apply(modName);

                applying.ShowDialog();
            }
        }

        void MainFormClosing(object sender, EventArgs e)
        {
            if (modLoaded)
            {
                closeTheMod();
            }
        }


        //////\\\\\\

        void deleteFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception ex)
            {
                _const.handleError(ex.Message, true);
            }
        }

        bool delete(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);

                    if (!File.Exists(path))
                        return true;
                    else
                        return false;
                }
                else
                    _const.handleError("Said file does not exist.", false);
            }
            catch (Exception x)
            {
                x.ToString();
                _const.handleError(x.Message, true);
            }
            return false;
        }

        void RefreshClick(object sender, EventArgs e)
        {

        }

        void TimerChangedTick(object sender, EventArgs e)
        {
            //this is going to be used for the currently opened mod :)

            if (modName == "")
                rootNode.Text = "Current Mod";
            else
                rootNode.Text = modName;



            // editor font...
            edit.Font = _const.editorFont;
        }

        void btnSaveFileEvent(object sender, EventArgs e)
        {
            saveFile();
        }

        void PosTimerTick(object sender, EventArgs e)
        {

            if (!File.Exists(_const.fileConfigFile))
            {
                refreshButton.ShowSubItems = false;


            }
            else
            {
                refreshButton.ShowSubItems = true;
            }

            if (tabs.Tabs.Count <= 0)
            {
                reflectionImage1.Visible = true;

            }
            else
            {
                reflectionImage1.Visible = false;
            }

            if (enableNetworkingToolStripMenuItem1.Checked)
            {
                myNetworkedModsToolStripMenuItem.Enabled = true;
            }
            else
            {
                myNetworkedModsToolStripMenuItem.Enabled = false;
            }

            if (modName == "")
            {
                fileHolder.TitleText = "No Mod Loaded";
            }
            else
            {
                fileHolder.TitleText = modName;
            }
        }

        void CloseButtonClick(object sender, EventArgs e)
        {
            closeFile();
        }

        void closeFile()
        {
            if (isLoaded)
            {
                try
                {
                    string openFile;

                    if (tabs.SelectedTab.Text.Contains(editedChar))
                    {


                        switch (MessageBox.Show("Save Changes?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                saveFile();
                                openFile = tmpPath + "\\" + tabs.SelectedTab.Text;

                                deleteFile(openFile);

                                tabs.Tabs.Remove(tabs.SelectedTab);
                                break;

                            case DialogResult.No:
                                openFile = tmpPath + "\\" + tabs.SelectedTab.Text;

                                deleteFile(openFile);

                                tabs.Tabs.Remove(tabs.SelectedTab);
                                break;

                            default:
                                // do nothing.
                                break;


                        }

                    }
                    else
                    {

                        openFile = tmpPath + "\\" + tabs.SelectedTab.Text;

                        deleteFile(openFile);

                        tabs.Tabs.Remove(tabs.SelectedTab);
                    }
                }
                catch (Exception x)
                {
                    _const.handleError("Could not delete file!\n\n\t" + x.Message, false);
                }
            }
            else
            {
                //they are retarted...
            }

        }

        void HelpToolStripButtonClick(object sender, EventArgs e)
        {
        }

        void apply()
        {
            // file text...

            try
            {
                comp(fileHolder.Tag.ToString(), tabs.SelectedTab.Tag.ToString());
            }
            catch (Exception x)
            {
                _const.handleError("There was an error with saving your document\n\n\t" + x.Message, true);
            }

        }

        void comp(string archive, string sPathName)
        {
            try
            {
                //Form bl = new Saving_File();
                //bl.ShowDialog();

                string pathRoot = Path.GetPathRoot(sPathName);
                string entryName = (tmpPath + "\\" + file.SelectedNode.Text);

                ZipFile zipFile = new ZipFile(archive);
                zipFile.UseZip64 = UseZip64.Off;

                zipFile.BeginUpdate();

                if (curFile == "Mod Comments.tweak")
                    zipFile.Add(tmpPath + "\\" + "Mod Comments.tweak", "Mod Comments.tweak");
                else
                    zipFile.Add(tmpPath + "\\" + Path.GetFileName(sPathName), sPathName);

                zipFile.CommitUpdate();

                zipFile.Close();

                if (tabs.SelectedTab.Text.Contains(editedChar))
                    tabs.SelectedTab.Text = tabs.SelectedTab.Text.Replace(editedChar, "");
            }
            catch (Exception ex)
            {
                _const.handleError("ERROR: " + ex.Message, true);
            }
        }

        void CompileClick(object sender, EventArgs e)
        {

        }

        void UndoToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        void RedoToolStripMenuItemClick(object sender, EventArgs e)
        {
            edit.Redo();
        }

        void txtFindEnter(object sender, KeyEventArgs e)
        {

        }

        void BtnFindClick(object sender, EventArgs e)
        {

        }

        void ArchiverClick(object sender, EventArgs e)
        {
            importZip();

        }

        void TxtFindClick(object sender, EventArgs e)
        {

        }

        void LaunchGameClick(object sender, EventArgs e)
        {
            launchBF2();
        }

        void ExitToolStripMenuItem2Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void OpenClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        void InsertSomethingToolStripMenuItemClick(object sender, EventArgs e)
        {


            launchBF2();
        }

        void launchBF2()
        {
            //check to see if that annoying tmp.in is already there...if it is...delete it...
            if (File.Exists(appDir + @"\tmp.min"))
            {
                File.Delete(appDir + @"\tmp.min");
            }

            if (selPath == String.Empty)
            {
                MessageBoxEx.Show("You need to import the archive before launching the game.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //System.Diagnostics.Process.Start(selPath + "\\" + "BF2.exe")
                try
                {
                    Process ne = new Process();
                    ne.StartInfo.FileName = appDir + @"\BF2 Modder Runner.exe";

                    ne.Start();


                    this.WindowState = FormWindowState.Minimized;
                    ne.WaitForExit();
                    this.WindowState = FormWindowState.Normal;

                }
                catch (Exception x)
                {

                    _const.handleError(@"ERROR:\n\n\t" + appDir + @"\BF2 Modder Runner.exe" + " is non existant! You will not be able to run Battlefield 2 servers powered by BF2 Modder.\n\nPlease contact support@sircapsalot.net for more info.\n\n\t" + x.Message, false);
                }


            }
        }

        void BtnLaunchClick(object sender, EventArgs e)
        {
            clearIntroVids();
            launchBF2();
        }

        void clearIntroVids()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(selPath + "\\mods\\bf2modder\\Movies");

                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Name == "menu.bik" || fi.Name == "menu_loggedin.bik" || fi.Name == "welcome.bik")
                    {

                    }
                    else
                    {
                        fi.Delete();
                    }
                }
            }
            catch (Exception x)
            {
                _const.handleError("Could not delete intro videos.", false);
            }
        }

        void MainFormPress(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F5)
            {
                applyMods();

            }

            //if ( e.KeyCode == Keys.F9 )
            //{
            //    launchBF2();
            //}

        }

        void applyMods() // IMPORTANT
        {
            if (File.Exists(appDir + @"\tmp\Objects_server.zip"))
            {
                status.Text = "copying...";
                File.Copy(zipPath, selPath + "\\mods\\bf2modder\\Objects_server.zip");

                if (File.Exists(selPath + "\\mods\\bf2modder\\Objects_server.zip"))
                {
                    status.Text = "Done";
                }

            }
            else
            {
                MessageBoxEx.Show("You must load the archive before applying any modifications.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void highlight(bool status)
        {
            switch (status)
            {
                case true:

                    if (isLoaded)
                    {
                        //enabled syntax highlighting for the current thingy...
                        edit.ProcessAllLines();
                    }
                    break;
                case false:
                    break;

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists(appDir + @"\tmp\Objects_server.zip"))
            {
                applyMods();
            }
            else
            {
                MessageBoxEx.Show("You must load the archive before applying any modifications.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void launchBF2BotSwapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newBotSwap = new BF2BotSwap();

            newBotSwap.ShowDialog();
        }

        private void numChars_Click(object sender, EventArgs e)
        {
            //show the drop down...
            selectMod.ShowSubItems = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void txtFindClear(object sender, EventArgs e)
        {
            txtFind.Text = "";
            txtFind.Focus();
        }

        void CreateNewMod()
        {
            if (modLoaded)
                closeTheMod();


            file.Nodes.Clear();
            tabs.Tabs.Clear();

            if (!File.Exists(zipPath))
            {
                MessageBoxEx.Show("You need to import the archive before creating a new mod.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // delete the zipPath...

                File.Delete(zipPath);

                //then recopy,

                if (selPath == "")
                {
                    MessageBoxEx.Show("You need to import the archive before creating a new mod.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!Directory.Exists(restPath))
                    {
                        _const.handleError("Can't load original mod. Reinstall BF2 Modder", false);
                        this.Close();
                    }

                    File.Copy(restPath + "\\Objects_server(_Original_).zip", zipPath, true);

                    //it's copied, now fill...

                    fillDirectories("");
                }
            }
        }

        void saveMod(string theModName)
        {
            // the mod name would be doucheMod...
            string theModPath = (string)fileHolder.Tag; // C:\Program Files\BF2 Modder\



            if (modLoaded)
            {
                ModName sss = new ModName(theModName);
                sss.ShowDialog();




            }
        }

        void refreshMod()
        {
            file.Nodes.Clear();

            if (selPath == String.Empty)
            {
                MessageBoxEx.Show("Load the archive before clicking refresh...", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                fillDirectories("");

                modLoaded = true;
            }

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshMod();
        }

        private void closeMod_Click(object sender, EventArgs e)
        {
            closeTheMod();

        }

        void closeTheMod()
        {
            //clear the nodes...

            try
            {
                if (file.Nodes[0].HasChildNodes)
                    file.Nodes[0].Nodes.Clear();
            }
            catch
            {
            }

            file.Nodes.Clear();
            tabs.Tabs.Clear();

            file.Nodes.Add(new Node(" [ double click to refresh ] "));
            modLoaded = false;
            modName = "";
            isLoaded = false;

        }

        private void status_Click(object sender, EventArgs e)
        {
            if (status.Text == "Archive not loaded")
            {
                importZip();
            }

            if (status.Text == "Ready")
            {


                showBF2MStatus();
            }

        }

        private void showBF2MStatus()
        {
            DirectoryInfo di = new DirectoryInfo(modPath);

            FileInfo[] fi = di.GetFiles("*.zip");

            int numFiles = fi.Length;

            string network = "";

            if (enableNetworkingToolStripMenuItem1.Checked)
            {
                network = "Enabled";
            }
            else
                network = "Disabled";

            MessageBox.Show("BF2 Modder Status");
        }

        private void launchTickIT_Click(object sender, EventArgs e)
        {
            Form tickit = new BF2TickIT();

            tickit.ShowDialog();
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (modLoaded)
                {
                    closeTheMod();
                }

                DirectoryInfo dii = new DirectoryInfo(tmpPath);

                foreach (FileInfo fi in dii.GetFiles())
                {
                    if (fi.Name == "Objects_server.zip")
                    {
                        //don't delete the Os.zip. only delete the others in the tmpdir
                    }
                    else
                    {
                        fi.Delete();
                    }
                }

                deleteParameter("joinServer");

            }
            catch (Exception ex)
            {
                _const.handleError("BF2 Modder Fatal ERROR:\n\n" + ex.Message, true);
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtFind_Click(object sender, EventArgs e)
        {

        }

        private void closeModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeTheMod();
        }

        private void restoreUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void battlfield2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            launchBF2();
        }

        private void bF2BotSwapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newBotSwap = new BF2BotSwap();

            newBotSwap.ShowDialog();
        }

        private void bF2TickITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tick = new BF2TickIT();

            tick.ShowDialog();
        }

        private void launchBF2WeaponizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form wep = new BF2Weaponizer();

            wep.ShowDialog();
        }

        private void stat_Tick(object sender, EventArgs e)
        {
            //read the config file...

            if (!File.Exists(configFile))
            {


                status.Text = "Archive not loaded";
            }
            else
            {
                //check the contents...

                string confirmation = File.ReadAllText(configFile);

                if (confirmation == String.Empty)
                {
                    status.ForeColor = Color.White;
                    status.Text = "Archive not loaded";
                }
                else
                {
                    status.ForeColor = Color.White;

                    status.Text = "Ready";
                }

            }

        }

        private void createNewModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewMod();
        }

        private void saveModToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void file_DoubleClick(object sender, EventArgs e)
        {
            if (file.SelectedNode == null)
            {   //do nothing
            }
            else
            {
                if (file.Nodes.Count == 1) //no visible mods cept the [ ] blah...
                {
                    if (file.SelectedNode.Text != " [ double click to refresh ] ")
                    {

                        if (tabs.Tabs[file.SelectedNode.Text] == null)
                        {
                            // tab doesnt exist...
                            loadFiles();
                        }
                        else
                        {
                            tabs.SelectedTab = tabs.Tabs[file.SelectedNode.Text];
                        }
                        //dont refresh, load the file...
                    }
                    else
                    {
                        refreshMod();
                    }
                }
                else
                {
                    //do nothing...

                }
            }
        }

        private void loadFiles()
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;


                //only do the following if it hasn't been changed...
                foreach (Node no in file.SelectedNodes)
                {


                    if (!hasChanged)
                    {
                        if (canLoad(no.Text))
                        {
                            extract(fileHolder.Tag.ToString(), tmpPath, no.Text);

                            MessageBoxEx.Show("XXX TEST : File Extracted!");

                            originalContent.Add(File.ReadAllText(tmpPath + "\\" + no.Text));

                            createNewFile(no, true);



                        }
                        else
                        {
                            //could be media file...

                            if (no.Text.EndsWith(".wav"))
                            {
                                extract(fileHolder.Tag.ToString(), tmpPath, no.Text);

                                //then execute, 

                                string medPath = tmpPath + "\\" + no.Text;
                                mediaEditor newEdit = new mediaEditor(medPath);
                                newEdit.ShowDialog();

                                if (File.Exists("bf2mrepl.cfg"))
                                {
                                    MessageBox.Show("Replacing...");
                                    if (File.Exists("bf2mrepl.cfg"))
                                    {
                                        try
                                        {
                                            string repl = File.ReadAllText("bf2mrepl.cfg");

                                            File.Replace(tmpPath + "\\" + no.Text, repl, null);
                                        }
                                        catch (Exception x)
                                        {
                                            _const.handleError("Could not replace the file.\n\n\t" + x.Message, false);
                                        }
                                        //replace the tmp with that,
                                        //delete tmp
                                        File.Delete("bf2mrepl.cfg");
                                    }
                                    else
                                    {
                                    }
                                }
                                else
                                {
                                    //they aren't replacing, dont do anything...

                                }

                            }
                            else if (no.Text.EndsWith(".ogg"))
                            {
                                extract(fileHolder.Tag.ToString(), tmpPath, no.Text);

                                //then execute, 

                                string medPath = tmpPath + "\\" + no.Text;
                                mediaEditor newEdit = new mediaEditor(medPath);

                                newEdit.ShowDialog();
                            }
                            else
                            {
                                //nope, neither media or regular file...
                            }
                        }
                    }
                    else
                    {
                        //has changed...
                        DialogResult re = MessageBoxEx.Show("Save Changes?", "Save your changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            saveFile();
                        }

                        hasChanged = false;

                        if (no.Text.IndexOf(".con") <= 0)
                        {
                        }
                        else
                        {
                            edit.Clear();
                            string confiletext = File.ReadAllText("\\tmp\\" + no.Text);
                            edit.Text = confiletext;

                            isLoaded = true;

                            //MessageBoxEx.Show("\\tmp" + no.FullPath.Remove(0, 10).ToString());
                        }

                        if (no.Text.IndexOf(".tweak") <= 0)
                        {
                        }
                        else
                        {
                            edit.Clear();
                            string confiletext = File.ReadAllText("\\tmp\\" + no.Text);


                            edit.Text = confiletext;


                            isLoaded = true;
                        }
                    }
                }
                this.Cursor = System.Windows.Forms.Cursors.Arrow;

            }
            catch (Exception ex)
            {
                createNewFile(file.SelectedNode, false);
            }

            //blah

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillDirectories("");
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            closeFile();
        }

        private void closeModToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeTheMod();
        }

        private void createNewModToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                CreateNewMod();
            }
            else
                CreateNewMod();
        }

        private void ni_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bf_Exited(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }


        private void cmbFireRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //find ObjectTemplate.addFireRate
        }

        private void minDmg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void EditKeyUp(object sender, KeyEventArgs e)
        {
        }


        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFind.Focus();
        }

        private void toolScroller_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void wepGroup_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void toolbox_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolbox_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edit.SelectedText != "")
            {
                edit.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edit.SelectedText != "")
            {
                edit.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit.Paste();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            txtFind.Text = "";
            txtFind.Focus();
        }

        private void currentOpenModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //APPLY CURRENT MOD
            try
            {
                if (File.Exists(zipPath) && selPath != "")
                {
                    status.Text = "applying current mod...";

                    File.Copy(zipPath, selPath + "\\mods\\bf2modder\\Objects_server.zip", true);

                    if (File.Exists(selPath + "\\mods\\bf2modder\\Objects_server.zip"))
                    {
                        status.Text = "Done!";
                        status.ForeColor = Color.SteelBlue;
                    }
                    else
                        _const.handleError("Could not apply current mod. An unknown error occured.", true);
                }
                else
                    _const.handleError("You need to import the archive before applying any modifications.", false);
            }
            catch (Exception x)
            {
                _const.handleError("Could not apply current mod.\n\n\t" + x.Message, false);
            }
        }

        private void txtFind_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutBox();

            aboutForm.Show();
        }

        private void searchStyle_TextChanged(object sender, EventArgs e)
        {
            txtFind.Focus();
        }

        //OMFG..............

        private void shareFolder(bool isEnabling)
        {
            if (isEnabling)
            {
                try
                {
                    if (!Directory.Exists(sharedPath))
                    {
                        Directory.CreateDirectory(sharedPath);
                    }

                    ManagementClass folder = new ManagementClass("Win32_Share");

                    ManagementBaseObject inParams = folder.GetMethodParameters("Create");
                    ManagementBaseObject outParams;

                    inParams["Description"] = "Shared mods folder for BF2 Modder by sircapsalot.NET";
                    inParams["Name"] = "BF2 Modder Shared Mods";
                    inParams["Path"] = sharedPath;
                    inParams["Type"] = 0x0; //disk drive?

                    outParams = folder.InvokeMethod("Create", inParams, null);

                    if ((uint)(outParams.Properties["ReturnValue"].Value) != 0)
                    {
                        _const.handleError("Failed to enable Shared Mods. This could be due to not having proper privileges, or you enabled Shared Mods already.", false);
                    }
                    else
                    {
                        //temporarily get the ip address and host name...

                        string hostName = System.Windows.Forms.SystemInformation.ComputerName;

                        MessageBoxEx.Show("Shared mods in BF2 Modder is now networked. \n\n Access:\n \\\\" + hostName, "BF2 Modder - Shared Mods", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        File.WriteAllText(netFile, "1");
                    }

                }
                catch (Exception x)
                {
                    x.ToString();
                }
            }
            else
            {
                //this is like...OMFG code.....
                using (ManagementObject o = new ManagementObject("root\\cimv2", "Win32_Share.Name='BF2 Modder Shared Mods'", null))
                {
                    ManagementBaseObject outParams = o.InvokeMethod("Delete", null, null);
                    if ((uint)(outParams.Properties["ReturnValue"].Value) != 0)
                    {
                        _const.handleError("Failed to disable sharing!", false);
                    }
                    else
                    {
                        MessageBoxEx.Show("Shared mods in BF2 Modder is now disabled.", "BF2 Modder - Shared Mods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.WriteAllText(netFile, "0");
                    }
                }
            }
        }

        private void enableNetworkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (enableNetworkingToolStripMenuItem1.Checked)
            {
                case true:

                    //it's checked
                    enableNetworkingToolStripMenuItem1.Checked = false;
                    shareFolder(false);
                    RefreshMods(null, null);

                    break;

                case false:

                    enableNetworkingToolStripMenuItem1.Checked = true;
                    shareFolder(true);
                    RefreshMods(null, null);
                    refreshMyNetwork(null, null);

                    break;
            }
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void searchNetwork(string networkedComputerName) // SIRCAPSALOT
        {
            try
            {
                string networkFolder = "";

                if (networkedComputerName.StartsWith(@"\\"))
                {
                    networkFolder = networkedComputerName + @"\BF2 Modder Shared Mods";
                }
                else
                {
                    networkFolder = @"\\" + networkedComputerName + @"\BF2 Modder Shared Mods";
                }

                //// add a network field...

                foreach (ToolStripMenuItem tmpItem in txtComputerName.Items)
                {

                    if (tmpItem.Text == networkedComputerName)
                    {
                        //dont add it...


                    }
                    else
                    {
                        ToolStripMenuItem newItem = new ToolStripMenuItem(networkedComputerName);
                        txtComputerName.Items.Add(networkedComputerName);
                    }
                }

                ButtonItem networkComputer = new ButtonItem(networkedComputerName, networkedComputerName);

                ButtonItem refreshClick = new ButtonItem("Refresh...");

                refreshClick.Click += new System.EventHandler(this.refreshNetwork);

                networkComputer.SubItems.Add(new LabelItem("", "-"));

                try
                {
                    DirectoryInfo networkMods = new DirectoryInfo(networkFolder);

                    foreach (FileInfo fi in networkMods.GetFiles("*.zip"))
                    {
                        //add to the networkedModsMenu drop down...

                        int networkMod = networkComputer.SubItems.Add(new ButtonItem(fi.Name, fi.Name)); // now we have SIRCAPSALOT > Object_server[SEX].zip

                        int copyMod = networkComputer.SubItems[networkMod].SubItems.Add(new ButtonItem("Copy Mod", "Copy Mod"));
                        ButtonItem cpMod = (ButtonItem)networkComputer.SubItems[networkMod].SubItems[0].Parent;

                        cpMod.Click += new EventHandler(this.copyNetworkMod);
                    }
                }
                catch (Exception x)
                {
                    x.ToString();
                    _const.handleError(x.Message, true);
                }
            }
            catch (Exception x)
            {
                _const.handleError(x.Message, false);
            }
        }

        private void refreshNetwork(object sender, EventArgs e)
        {
            try
            {
                //we need to refresh the \\parentitem\BF2 M0dd3r Shared M0ds\ folder...
                ToolStripMenuItem parent = (ToolStripMenuItem)sender;

                parent = (ToolStripMenuItem)parent.OwnerItem;


                string networkFolder = @"\\" + parent.Text + "\\BF2 Modder Shared Mods";

                DirectoryInfo networkMods = new DirectoryInfo(networkFolder);
                parent.DropDownItems.Clear();

                ToolStripMenuItem refresh = new ToolStripMenuItem("Refresh...");
                refresh.Click += new System.EventHandler(this.refreshNetwork);

                parent.DropDownItems.Add(refresh);
                parent.DropDownItems.Add("-");

                foreach (FileInfo fi in networkMods.GetFiles("*.zip"))
                {
                    //add to the networkedModsMenu drop down...



                    ToolStripMenuItem networkMod = (ToolStripMenuItem)parent.DropDownItems.Add(fi.Name);
                    networkMod.Click += new System.EventHandler(this.editNetworkMod);

                    ToolStripMenuItem copyIt = (ToolStripMenuItem)networkMod.DropDownItems.Add("Copy [" + fi.Name + "]");
                    copyIt.Click += new System.EventHandler(this.copyNetworkMod);

                }
                parent.ShowDropDown();
            }
            catch (Exception x)
            {
                x.ToString();
                _const.handleError("Cannot Refresh Mods...The Networked BF2 Modder is either Disconnected, or has changed permissions.", false);
            }
        }

        private void copyNetworkMod(object sender, EventArgs e)
        {
            //get the mod path...
            try
            {
                ButtonItem senderr = (ButtonItem)sender;

                string from = @"\\" + senderr.Text + "\\BF2 Modder Shared Mods\\" + senderr.Parent.Text;
                string to = @"mods\" + senderr.Parent.Text;

                try
                {

                    Form copying = new Copying(from, to);
                    copying.ShowDialog();

                    if (File.Exists(to))
                    {
                        MessageBoxEx.Show("Mod Copied", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        _const.handleError("BF2 Modder encountered an error while trying to copy the networked mod. Please retry copying the mod.", true);
                }
                catch (Exception x)
                {
                    x.ToString();
                    _const.handleError("BF2 Modder could not copy the networked mod. " + from + ", is not accessible. Please make sure BF2 Modder networking is enabled, and that you have the proper rights.", false);

                }
            }
            catch (Exception x)
            {
                x.ToString();

                _const.handleError("An error has occured trying to copy your network mod.\n\n\tMessage Follows:\n\n" + x.Message, true);
            }
        }

        private void refreshMyNetwork(object sender, EventArgs e)
        {
            try
            {
                //we need to refresh the \\parentitem\BF2 M0dd3r Shared M0ds\ folder...
                ButtonItem parent = myNetworkedModsToolStripMenuItem;
                parent.ButtonStyle = eButtonStyle.ImageAndText;

                string networkFolder = @"\\" + System.Windows.Forms.SystemInformation.ComputerName + "\\BF2 Modder Shared Mods";

                DirectoryInfo networkMods = new DirectoryInfo(networkFolder);
                parent.SubItems.Clear();

                ButtonItem refresh = new ButtonItem("", "Refresh...");
                refresh.Click += new System.EventHandler(this.refreshMyNetwork);
                refresh.ButtonStyle = eButtonStyle.ImageAndText;

                parent.SubItems.Add(refresh);

                foreach (FileInfo fi in networkMods.GetFiles("*.zip"))
                {
                    //add to the networkedModsMenu drop down...



                    ButtonItem networkMod = new ButtonItem("", fi.Name);
                    parent.SubItems.Add(networkMod);
                    networkMod.ButtonStyle = eButtonStyle.ImageAndText;

                    networkMod.Click += new System.EventHandler(this.editNetworkMod);
                    networkMod.Tag = fi.Name;

                    ButtonItem delete = new ButtonItem("", "Delete");
                    delete.ButtonStyle = eButtonStyle.ImageAndText;

                    delete.Tag = fi.Name;
                    networkMod.SubItems.Add(delete);
                    delete.Click += new EventHandler(delete_Click);

                }
                parent.ShowSubItems = true;

            }
            catch (Exception x)
            {
                _const.handleError("Cannot Refresh Mods...The Networked BF2 Modder is either Disconnected, or has changed permissions :: " + x.Message, true);
            }
        }

        void delete_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem senderr = (ToolStripMenuItem)sender;



                if (MessageBoxEx.Show("Are you sure you want to delete " + senderr.Tag.ToString(), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(sharedPath + "\\" + senderr.Tag.ToString());

                    ToolStripMenuItem mnu = (ToolStripMenuItem)senderr.OwnerItem.OwnerItem;

                    mnu.ShowDropDown();
                }
            }
            catch (Exception x)
            {
                _const.handleError("Could not delete the network mod.\n\n" + x.ToString(), false);
            }
        }

        private void editNetworkMod(object sender, EventArgs e)
        {
            try
            {

                ToolStripMenuItem senderr = (ToolStripMenuItem)sender;

                string modName = "";
                string networkName = @"\\" + senderr.OwnerItem.Text;

                if (networkName == @"\\My Network Mods")
                {
                    networkName = @"\\" + System.Windows.Forms.SystemInformation.ComputerName;
                }

                networkName += @"\BF2 Modder Shared Mods";

                modName = networkName + "\\" + senderr.Text;

                List<string> contentList = new List<string>();

                this.modName = "NETWORK: " + senderr.Text;

                fillDirectories(modName);
            }
            catch (Exception x)
            {
                x.ToString();

                _const.handleError("Could not load Networked Mod. the path, " + modName + ", is not accessible.", false);
            }
        }

        private void myNetworkedModsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                curEdit.Undo();
            }
            catch
            {
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                curEdit.Redo();
            }
            catch
            {
            }
        }

        private void scanForM0dsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ScanNetworkMods form = new ScanNetworkMods();
            form.ShowDialog();
        }

        private void registerProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO ::: 
            try
            {
                if (!registerProductToolStripMenuItem.Checked)
                {
                    File.WriteAllText(appDir + @"\participation.cfg", "part");

                    if (File.Exists(appDir + @"\participation.cfg"))
                    {
                        if (File.ReadAllText(appDir + @"\participation.cfg") != "")
                        {
                            //if they already put their name...
                            registerProductToolStripMenuItem.Checked = true;
                        }
                        else
                        {
                            Form frm = new Participation();
                            frm.ShowDialog();

                            string nm = "";
                            nm = File.ReadAllText(appDir + @"\participation.cfg");
                            if (nm != "")
                            {
                                registerProductToolStripMenuItem.Checked = true;

                                userName = nm;
                            }
                            else
                            {
                                registerProductToolStripMenuItem.Checked = false;
                            }
                        }

                    }
                    else
                    {
                        File.Create(appDir + @"\participation.cfg");
                    }
                }
                else
                {
                    File.Delete(appDir + @"\participation.cfg");

                    registerProductToolStripMenuItem.Checked = false;
                    registerProductToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                }
            }
            catch (Exception x)
            {
                _const.handleError("There was an error trying to enable / disable participation.\n\n\t" + x.Message, true);
            }
        }

        private void enableNetworkingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            switch (enableNetworkingToolStripMenuItem1.Checked)
            {
                case true:

                    //it's checked
                    enableNetworkingToolStripMenuItem1.Checked = false;
                    enableNetworkingToolStripMenuItem1.ForeColor = Control.DefaultForeColor;
                    shareFolder(false);
                    RefreshMods(null, null);

                    break;

                case false:

                    enableNetworkingToolStripMenuItem1.Checked = true;
                    enableNetworkingToolStripMenuItem1.ForeColor = Color.SteelBlue;
                    shareFolder(true);
                    RefreshMods(null, null);
                    refreshMyNetwork(null, null);

                    break;
            }
        }

        private void searchStyle_Click(object sender, EventArgs e)
        {
            if (searchStyle.Text == "...in editor")
            {
                searchStyle.Text = "...in archive";
            }
            else
            {
                searchStyle.Text = "...in editor";
            }
        }

        private void automaticLoginOnStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!automaticLoginOnStartupToolStripMenuItem.Checked)
                {
                    AutomaticLogin loginForm = new AutomaticLogin();
                    loginForm.ShowDialog();

                    //then check to see if string file.Contains("playerName")

                    string fileContents = File.ReadAllText(addFile);

                    if (fileContents.Contains("playerName"))
                    {
                        automaticLoginOnStartupToolStripMenuItem.Checked = true;
                        automaticLoginOnStartupToolStripMenuItem.ForeColor = Color.SteelBlue;
                    }
                    else
                    {


                        automaticLoginOnStartupToolStripMenuItem.Checked = false; // they probably clicked cancel or something...
                        automaticLoginOnStartupToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                    }
                }
                else
                {
                    string txt = File.ReadAllText(addFile);

                    // what i need to do is split the strings?

                    string[] nn = txt.Split(new char[1] { '+' });

                    string newtxt = "";

                    foreach (string n in nn)
                    {

                        if (n.Contains("playerName"))
                        {
                            txt = txt.Replace("+" + n, "");
                        }
                        if (n.Contains("playerPassword"))
                        {
                            txt = txt.Replace("+" + n, "");
                        }
                    }
                    newtxt = txt;

                    File.WriteAllText(addFile, newtxt);

                    File.Delete(appDir + @"\bf2profname.cfg");

                    automaticLoginOnStartupToolStripMenuItem.Checked = false;
                    automaticLoginOnStartupToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                }
            }
            catch (Exception x)
            {
                _const.emailReport(userName, "There was an error while disabling / enabling automaticLoginOnStartupToolStripMenuItem, : " + x.Message);
            }
        }

        private void playLANBotServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!playLANBotServerToolStripMenuItem.Checked)
            {

                // if it's not checked...

                if (hostLANBotServerToolStripMenuItem.Checked)
                {
                    string txt = File.ReadAllText(addFile);

                    // what i need to do is split the strings?

                    string[] nn = txt.Split(new char[1] { '+' });

                    string newtxt = "";

                    foreach (string n in nn)
                    {

                        if (n.Contains("loadLevel"))
                        {
                            txt = txt.Replace("+" + n, "");
                        }

                        if (n.Contains("gameMode"))
                        {
                            txt = txt.Replace("+" + n, "");
                        }

                        if (n.Contains("ai"))
                        {
                            txt = txt.Replace("+" + n, "");
                        }
                    }
                    newtxt = txt;

                    File.WriteAllText(addFile, newtxt);

                    hostLANBotServerToolStripMenuItem.Checked = false;
                    hostLANBotServerToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                }

                LANServer frm = new LANServer();
                frm.ShowDialog();

                if (File.ReadAllText(addFile).Contains("joinServer"))
                {
                    playLANBotServerToolStripMenuItem.Checked = true;
                    playLANBotServerToolStripMenuItem.ForeColor = Color.SteelBlue;
                }
                else
                {
                    playLANBotServerToolStripMenuItem.Checked = false;
                    playLANBotServerToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                }

            }
            else
            {
                //if they are unselecting it...then 

                string txt = File.ReadAllText(addFile);

                // what i need to do is split the strings?

                string[] nn = txt.Split(new char[1] { '+' });

                string newtxt = "";

                foreach (string n in nn)
                {

                    if (n.Contains("joinServer"))
                    {
                        txt = txt.Replace("+" + n, "");
                    }
                }
                newtxt = txt;

                File.WriteAllText(addFile, newtxt);

                playLANBotServerToolStripMenuItem.Checked = false;
            }


        }

        private void createFromOriginal(object sender, EventArgs e)
        {
            CreateNewMod();
        }

        private void parsingTimer_Tick(object sender, EventArgs e)
        {
            try
            {

                /*
                 * [0] Current Mod
                 *    [1] 
                 * */
                if (file.Nodes[0].Nodes.Count == 1)
                {
                    if (file.Nodes[0].Text == " [ double click to refresh ] ")
                    {
                        parsingMessage.Visible = false;
                    }
                    else
                        parsingMessage.Visible = true;
                }
                else
                    parsingMessage.Visible = false;

            }
            catch (Exception x)
            {
                x.ToString();
            }
        }

        private void viewSupportSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"support_site.htm");
            }
            catch
            {
                Process.Start(@"iexplore.exe", "http://support.sircapsalot.net");
            }
        }

        private void hostLANBotServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hostLANBotServerToolStripMenuItem.Checked)
            {
                string txt = File.ReadAllText(addFile);

                // what i need to do is split the strings?

                string[] nn = txt.Split(new char[1] { '+' });

                string newtxt = "";

                foreach (string n in nn)
                {

                    if (n.Contains("loadLevel"))
                    {
                        txt = txt.Replace("+" + n, "");
                    }

                    if (n.Contains("gameMode"))
                    {
                        txt = txt.Replace("+" + n, "");
                    }
                    if (n.Contains("ai"))
                    {
                        txt = txt.Replace("+" + n, "");
                    }
                }
                newtxt = txt;

                File.WriteAllText(addFile, newtxt);

                hostLANBotServerToolStripMenuItem.Checked = false;
                hostLANBotServerToolStripMenuItem.ForeColor = Control.DefaultForeColor;
            }
            else // if they are enabling
            {
                if (playLANBotServerToolStripMenuItem.Checked == true)
                {
                    string txt = File.ReadAllText(addFile);

                    // what i need to do is split the strings?

                    string[] nn = txt.Split(new char[1] { '+' });

                    string newtxt = "";

                    foreach (string n in nn)
                    {

                        if (n.Contains("joinServer"))
                        {
                            txt = txt.Replace("+" + n, "");
                        }
                    }
                    newtxt = txt;

                    File.WriteAllText(addFile, newtxt);

                    playLANBotServerToolStripMenuItem.Checked = false;
                    playLANBotServerToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                }

                HostServer hs = new HostServer();
                hs.ShowDialog();

                //continue...
                if (File.ReadAllText(addFile).Contains("loadLevel"))
                {
                    hostLANBotServerToolStripMenuItem.Checked = true;
                    hostLANBotServerToolStripMenuItem.ForeColor = Color.SteelBlue;

                    playLANBotServerToolStripMenuItem.Checked = false;
                    playLANBotServerToolStripMenuItem.ForeColor = Control.DefaultForeColor;
                    if (MessageBoxEx.Show("Would you like to host the game now?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        launchBF2();
                    }
                    else
                    {
                    }
                }
            }
        }

        private void deleteParameter(string parameterName)
        {
            try
            {
                string txt = File.ReadAllText(addFile);

                // what i need to do is split the strings?

                string[] nn = txt.Split(new char[1] { '+' });

                string newtxt = "";

                foreach (string n in nn)
                {

                    if (n.Contains(parameterName))
                    {
                        txt = txt.Replace("+" + n, "");
                    }
                }
                newtxt = txt;

                File.WriteAllText(addFile, newtxt);
            }
            catch (Exception x)
            {
                _const.handleError("Could not modify additional parameters! Please restart BF2 Modder.\n\n\t" + x.Message, true);
                File.WriteAllText(addFile, "");
                this.Close();
            }
        }

        private void file_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BF2BotNamer botNamer = new BF2BotNamer();
            botNamer.ShowDialog();
        }

        private void testFunctions()
        {
            //put the tests here for onload...

        }

        private void copyTheDir(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            if (Directory.Exists(selPath + "\\mods\\bf2modder"))
            {
                if (MessageBoxEx.Show("The BF2 Modder mod already exists. Would you still like to run the batch?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    creatingModFolder creating = new creatingModFolder(selPath + "\\mods\\bf2", selPath + "\\mods\\bf2modder", false);

                    creating.ShowDialog();
                }
                else
                {
                    creatingModFolder creating = new creatingModFolder(selPath + "\\mods\\bf2", selPath + "\\mods\\bf2modder", true);

                    creating.ShowDialog();
                }
            }



        }

        private void showBF2M0dd3r(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void editChanged_Tick_1(object sender, EventArgs e)
        {
            if (File.Exists(appDir + @"\modCreated.cfg"))
            {
                btnLoadArchive.Checked = true;
                btnLoadArchive.ForeColor = Color.Black;
            }
            else
            {
                btnLoadArchive.Checked = false;
                btnLoadArchive.ForeColor = Color.White;
            }
        }

        private void launchDefaultBF2_Click(object sender, EventArgs e)
        {
        }

        private void fromOriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewMod();
        }

        private void pluginsTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                pluginsToolStripMenuItem.DropDownItems.Add("Plugin Manager", null, this.launchPluginManager);

                pluginsToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());

                pluginsToolStripMenuItem.DropDownItems.Add("Refresh...                      ", null, this.refreshPlugins);

                pluginsToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());

                ToolStripMenuItem bf2BotSwap = new ToolStripMenuItem("BF2 BotSwap", pluginImage);
                bf2BotSwap.ShortcutKeys = Keys.F2;
                bf2BotSwap.Image = pluginImage;
                bf2BotSwap.Click += new EventHandler(this.bF2BotSwapToolStripMenuItem_Click);

                pluginsToolStripMenuItem.DropDownItems.Add(bf2BotSwap);

                ToolStripMenuItem bf2TickIt = new ToolStripMenuItem("BF2 TickIT", pluginImage);
                bf2TickIt.ShortcutKeys = Keys.F7;
                bf2TickIt.Image = pluginImage;
                bf2TickIt.Click += new EventHandler(this.bF2TickITToolStripMenuItem_Click);


                ToolStripMenuItem bf2BotNamer = new ToolStripMenuItem("BF2 BotNamer", pluginImage);
                bf2BotNamer.ShortcutKeys = Keys.F8;
                bf2BotNamer.Image = pluginImage;
                bf2BotNamer.Click += new EventHandler(this.toolStripMenuItem2_Click);

                pluginsToolStripMenuItem.DropDownItems.Add(bf2TickIt);
                pluginsToolStripMenuItem.DropDownItems.Add(bf2BotNamer);
                pluginsToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());

                DirectoryInfo di = new DirectoryInfo(pluginsPath);

                foreach (DirectoryInfo pluginName in di.GetDirectories())
                {

                    if (File.Exists(pluginsPath + "\\" + pluginName.Name + "\\" + pluginName.Name + ".exe"))
                    {
                        ToolStripMenuItem newItem = new ToolStripMenuItem(pluginName.Name, pluginImage);
                        newItem.Click += new EventHandler(this.launchPlugin);

                        pluginsToolStripMenuItem.DropDownItems.Add(newItem.Text, pluginImage, this.launchPlugin);
                    }
                    else
                    {
                        //dont add it

                    }
                }

                pluginsTimer.Enabled = false;
            }
            catch (Exception x)
            {
                _const.handleError("There was an error trying to populate the plugins. Send this error report to support@sircapsalot.net >\n\n\t" + x.Message, true);
                pluginsTimer.Enabled = true;
            }
        }

        void launchPlugin(object sender, EventArgs e)
        {
            try
            {

                ToolStripMenuItem senderr = (ToolStripMenuItem)sender;

                Process pluginProcess = new Process();

                pluginProcess.StartInfo.FileName = pluginsPath + "\\" + senderr.Text + "\\" + senderr.Text + ".exe";
                status.Text = "plugin running...";
                pluginProcess.Start();
                pluginProcess.WaitForExit();
                status.Text = "plugin exited...";
            }
            catch (Exception x)
            {
                _const.handleError("There was an error launching a plugin, " + x.Message, false);
            }
        }

        private void refreshPlugins(object sender, EventArgs e)
        {
            pluginsToolStripMenuItem.DropDownItems.Clear();
            pluginsTimer.Enabled = true;
        }

        private void launchPluginManager(object sender, EventArgs e)
        {
            pluginManager pm = new pluginManager();
            pm.Show();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            ServerSettings sv = new ServerSettings();
            sv.ShowDialog();
        }

        private void chkd(object sender, EventArgs e)
        {
            ToolStripMenuItem se = (ToolStripMenuItem)sender;

            if (se.Checked)
            {
                // they are disabling...
                se.ForeColor = Control.DefaultForeColor;
            }
            else
                se.ForeColor = Color.SteelBlue;
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ribbonPanel3_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar5_ItemClick(object sender, EventArgs e)
        {

        }

        private void loadRecentMod(object sender, EventArgs e)
        {
            // this will be triggered by pressing a recent mod button.


        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show(appDir);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }


        private void buttonItem15_Click(object sender, EventArgs e)
        {
            CreateNewMod();
        }

        private void restartBF2M_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void closeMod_Click_1(object sender, EventArgs e)
        {
            closeTheMod();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            optionsScreen opts = new optionsScreen();
            opts.ShowDialog();
        }

        private void saveCurrentMod_Click(object sender, EventArgs e)
        {
            saveMod(modName);
        }

        private void svHolder_ExpandedChanged(object sender, ExpandedChangeEventArgs e)
        {
            // load Server Settings
        }

        private void btnApplyServerSettings_Click(object sender, EventArgs e)
        {
            serverSettings.ApplySettings();
        }

        private void btnRefreshServerSettings_Click(object sender, EventArgs e)
        {
            serverSettings = new svSettings();
            sv.SelectedObject = serverSettings;
        }

        private void btnViewCommonClient_Click(object sender, EventArgs e)
        {
            try
            {
                string bfDir = File.ReadAllText(_const.fileConfigFile);

                string common_client = bfDir + "\\mods\\bf2modder\\Common_client.zip";

                fillDirectories(common_client);
            }
            catch (Exception x)
            {
                _const.handleError("There was an error trying to view the common_client.zip\n\n\t" + x.Message, false);
            }

        }

        private void refreshButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                refreshButton.Popup(MousePosition.X, MousePosition.Y);
            }
        }

        private void selectMod_MouseUp(object sender, MouseEventArgs e)
        {
            selectMod.Popup(MousePosition.X, MousePosition.Y);
        }

        private void ribbonControl1_DoubleClick(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    this.WindowState = FormWindowState.Maximized;
                    break;

                case FormWindowState.Maximized:
                    this.WindowState = FormWindowState.Normal;
                    break;

                default:
                    this.WindowState = FormWindowState.Maximized;
                    break;
            }
        }

        private void btnViewCommonServer_Click(object sender, EventArgs e)
        {
            try
            {
                string bfDir = File.ReadAllText(_const.fileConfigFile);

                string common_server = bfDir + "\\mods\\bf2modder\\Common_server.zip";

                fillDirectories(common_server);
            }
            catch (Exception x)
            {
                _const.handleError("There was an error trying to view the common_server.zip\n\n\t" + x.Message, false);
            }
        }

        private void btnViewMenuClient_Click(object sender, EventArgs e)
        {
            try
            {
                string bfDir = File.ReadAllText(_const.fileConfigFile);

                string menu_client = bfDir + "\\mods\\bf2modder\\Menu_client.zip";

                fillDirectories(menu_client);
            }
            catch (Exception x)
            {
                _const.handleError("There was an error trying to view the Menu_client.zip\n\n\t" + x.Message, false);
            }
        }

        private void btnViewMenuServer_Click(object sender, EventArgs e)
        {
            try
            {
                string bfDir = File.ReadAllText(_const.fileConfigFile);

                string menu_server = bfDir + "\\mods\\bf2modder\\Menu_server.zip";

                fillDirectories(menu_server);
            }
            catch (Exception x)
            {
                _const.handleError("There was an error trying to view the Menu_server.zip\n\n\t" + x.Message, false);
            }
        }

        private void btnViewObjectsClient_Click(object sender, EventArgs e)
        {
            try
            {
                string bfDir = File.ReadAllText(_const.fileConfigFile);

                string objects_client = bfDir + "\\mods\\bf2modder\\Objects_client.zip";

                fillDirectories(objects_client);
            }
            catch (Exception x)
            {
                _const.handleError("There was an error trying to view the Objects_client.zip\n\n\t" + x.Message, false);
            }
        }

        private void btnAddNewFile(object sender, EventArgs e)
        {
            Node clickedNode = file.SelectedNode;
            Node addingNode = new Node();

            clickedNode.Nodes.Add(addingNode);

            file.SelectedNode = addingNode;

            addingNode.BeginEdit("File Name.tweak");
        }

        private void btnAddNewDir_Click_1(object sender, EventArgs e)
        {
            //get the clicked node,
            Node clickedNode = file.SelectedNode;
            Node addingNode = new Node();

            clickedNode.Nodes.Add(addingNode);

            file.SelectedNode = addingNode;

            addingNode.BeginEdit("Enter Directory Name Here");
        }

        private void editCurrentItem_Click(object sender, EventArgs e)
        {
            file.SelectedNode.BeginEdit(file.SelectedNode.Text);
        }

        private void tabs_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            closeFile();
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
        }

        private void file_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    switch (MessageBoxEx.Show("Are you sure you want to delete " + file.SelectedNode.Text + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            file.Nodes.Remove(file.SelectedNode);
                            break;

                        default:
                            //do nothing
                            break;
                    }


                }
            }
            catch (Exception x)
            {
                _const.handleError("Could not remove " + file.SelectedNode.Text + "! \n\n\t" + x.Message, false);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchCurrentFile(txtFind.Text);
        }

        private void searchCurrentFile(string searchQuery)
        {
            string searchQ = searchStyle.Text;

            switch (searchQ)
            {
                case "...in editor":


                    int srch = curEdit.Find(searchQuery);

                    //negative 1 if not found :)

                    if (srch == -1)
                    {
                        _const.handleError("\"" + searchQuery + "\" not found.", false);
                    }
                    else
                    {
                        curEdit.Focus();
                        curEdit.Select(srch, (searchQuery.Length));

                        //if (txtFind.Items.Contains(txtFind.Text))
                        //{

                        //}
                        //else
                        //    txtFind.Items.Add(txtFind.Text);
                    }
                    break;

                case "...in archive":

                    Node childNode = null;

                    bool count = false;

                    for (int i = 0 ; i < file.Nodes[0].Nodes.Count ; i++)
                    {
                        childNode = file.Nodes[0].Nodes[i];

                        if (childNode.Text.Contains(searchQuery))
                        {
                            count = true;
                            break;
                        }
                    }

                    if (!count)
                    {
                        // 
                        _const.handleError("\"" + searchQuery + "\" was not found in the archive.", false);
                    }
                    else
                    {
                        file.SelectedNode = childNode;
                        file.Focus();
                    }

                    file.SelectedNode = childNode;

                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
            txtFind.Focus();
        }

        private void btnSendBugReport_Click(object sender, EventArgs e)
        {
            bugReport newBugReport = new bugReport();
            newBugReport.ShowDialog();

        }

        private void btnSearchNetwork_Click(object sender, EventArgs e)
        {
            searchNetwork(txtComputerName.Text);
        }

        private void btnExecuteBatchReplace_Click(object sender, EventArgs e)
        {
            batchReplace(txtBatchReplaceFrom.Text, txtBatchReplaceTo.Text);
        }

        private void batchReplace(string source, string dest)
        {

            if (txtBatchReplaceFrom.Text == "")
            {
                _const.handleError("You need to type source text which will be replaced.", false);
            }
            else
            {
                if (txtBatchReplaceTo.Text == "")
                {
                    if (MessageBoxEx.Show("Replace \"" + txtBatchReplaceFrom + "\" with nothing?", "BF2 Modder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (TabItem tab in tabs.Tabs)
                        {
                            // foreach tab, search through the text...
                            SyntaxRichTextBox pages = (SyntaxRichTextBox)tab.AttachedControl.Controls[0];

                            string[] newLines = pages.Lines;

                            string searchQuery = txtBatchReplaceFrom.Text;

                            for (int i = 0 ; i < pages.Lines.Length ; i++)
                            {

                                if (pages.Lines[i].Contains(searchQuery))
                                {
                                    string newStr = pages.Lines[i].Replace(searchQuery, txtBatchReplaceTo.Text);
                                    newLines[i] = newStr;
                                }
                                else
                                {
                                    //skip...
                                    newLines[i] = pages.Lines[i];
                                }
                            }

                            pages.Lines = newLines;

                        }
                        _const.alert("Batch Replace Finished...");
                    }
                }
                else
                {
                    foreach (TabItem tab in tabs.Tabs)
                    {
                        // foreach tab, search through the text...
                        SyntaxRichTextBox pages = (SyntaxRichTextBox)tab.AttachedControl.Controls[0];

                        string[] newLines = pages.Lines;

                        string searchQuery = txtBatchReplaceFrom.Text;

                        for (int i = 0 ; i < pages.Lines.Length ; i++)
                        {

                            if (pages.Lines[i].Contains(searchQuery))
                            {
                                string newStr = pages.Lines[i].Replace(searchQuery, txtBatchReplaceTo.Text);
                                newLines[i] = newStr;
                            }
                            else
                            {
                                //skip...
                                newLines[i] = pages.Lines[i];
                            }
                        }

                        pages.Lines = newLines;

                    }
                    _const.alert("Batch Replace Finished...");
                }
            }
        }

        private void btnMainMenu_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseModHeirarchy_Click(object sender, EventArgs e)
        {
            closeTheMod();
        }
        
        private void btnUndo_Click(object sender, EventArgs e)
        {
            curEdit.Focus();
            curEdit.Undo();
            
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            curEdit.Focus();
            curEdit.Redo();
        }

        private void btnRevertChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string txtToUse = originalContent[tabs.Tabs.IndexOf(tabs.SelectedTab)];
                MessageBox.Show("Reverting to : " + txtToUse);
                curEdit.Focus();
            }
            catch (Exception x)
            {
                if (!x.Message.Contains("Object reference"))
                    _const.handleError("Could not revert all changes!", true);
               

            }
            curEdit.Focus();
        }

        private void btnRevertToOriginal_Click(object sender, EventArgs e)
        {

        }

        private void labelItem10_Click(object sender, EventArgs e)
        {

        }
    }
}