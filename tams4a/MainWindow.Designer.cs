﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tams4a
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitTAMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRoadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTreatmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteSignsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSep = new System.Windows.Forms.ToolStripMenuItem();
            this.roadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potholesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.governingDistressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSLDistributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surfaceTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionalClassificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signRecommendationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportRecommendationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidewalkDistressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roadsWithSidewalksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.severeRoadDistressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDARampsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drainageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOthersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.uxMap = new DotSpatial.Controls.Map();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.tabControlControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.treatmentPreventative = new System.Windows.Forms.TextBox();
            this.treatmentRehabilitation = new System.Windows.Forms.TextBox();
            this.treatmentPreventativePatching = new System.Windows.Forms.TextBox();
            this.treatmentReconstruction = new System.Windows.Forms.TextBox();
            this.treatmentPatching = new System.Windows.Forms.TextBox();
            this.treatmentRoutine = new System.Windows.Forms.TextBox();
            this.rslBlue = new System.Windows.Forms.TextBox();
            this.rslDeepSkyBlue = new System.Windows.Forms.TextBox();
            this.rslGreen = new System.Windows.Forms.TextBox();
            this.rslLimeGreen = new System.Windows.Forms.TextBox();
            this.rslYellow = new System.Windows.Forms.TextBox();
            this.rslDarkRed = new System.Windows.Forms.TextBox();
            this.rslOrange = new System.Windows.Forms.TextBox();
            this.rslRed = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripZoomExt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.buttonModePan = new System.Windows.Forms.ToolStripButton();
            this.buttonModeSelect = new System.Windows.Forms.ToolStripButton();
            this.buttonModeTable = new System.Windows.Forms.ToolStripButton();
            this.buttonModeZoomin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelId = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxFind = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSnapShot = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.tabControlControls.SuspendLayout();
            this.mapPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.toolStripMenuItemSep,
            this.roadToolStripMenuItem,
            this.signToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.customReportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.quitTAMSToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Enabled = false;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.infoToolStripMenuItem.Text = "I&nfo";
            this.infoToolStripMenuItem.Visible = false;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.displayToolStripMenuItem.Text = "&Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.closeProjectToolStripMenuItem.Text = "&Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // quitTAMSToolStripMenuItem
            // 
            this.quitTAMSToolStripMenuItem.Name = "quitTAMSToolStripMenuItem";
            this.quitTAMSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitTAMSToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.quitTAMSToolStripMenuItem.Text = "&Quit TAMS";
            this.quitTAMSToolStripMenuItem.Click += new System.EventHandler(this.quitTAMS4_click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.manuelToolStripMenuItem,
            this.reportProblemsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.logsToolStripMenuItem.Text = "&Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // manuelToolStripMenuItem
            // 
            this.manuelToolStripMenuItem.Name = "manuelToolStripMenuItem";
            this.manuelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.manuelToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.manuelToolStripMenuItem.Text = "Manual";
            this.manuelToolStripMenuItem.ToolTipText = "View the TAMS4 manual online";
            this.manuelToolStripMenuItem.Click += new System.EventHandler(this.manuelToolStripMenuItem_Click);
            // 
            // reportProblemsToolStripMenuItem
            // 
            this.reportProblemsToolStripMenuItem.Name = "reportProblemsToolStripMenuItem";
            this.reportProblemsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.reportProblemsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.reportProblemsToolStripMenuItem.Text = "Report Problems";
            this.reportProblemsToolStripMenuItem.ToolTipText = "Submit a bug report to the TAMS4 development team.";
            this.reportProblemsToolStripMenuItem.Click += new System.EventHandler(this.reportProblemsToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importRoadsToolStripMenuItem,
            this.editTreatmentsToolStripMenuItem,
            this.favoriteSignsToolStripMenuItem,
            this.importCSVToolStripMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.advancedToolStripMenuItem.Text = "Advanced";
            // 
            // importRoadsToolStripMenuItem
            // 
            this.importRoadsToolStripMenuItem.Enabled = false;
            this.importRoadsToolStripMenuItem.Name = "importRoadsToolStripMenuItem";
            this.importRoadsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importRoadsToolStripMenuItem.Text = "Import &Roads";
            this.importRoadsToolStripMenuItem.ToolTipText = "Attempt to import road data from TAMS2 or TAMS3";
            this.importRoadsToolStripMenuItem.Click += new System.EventHandler(this.importRoadsToolStripMenuItem_Click);
            // 
            // editTreatmentsToolStripMenuItem
            // 
            this.editTreatmentsToolStripMenuItem.Name = "editTreatmentsToolStripMenuItem";
            this.editTreatmentsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editTreatmentsToolStripMenuItem.Text = "Edit &Treatments";
            this.editTreatmentsToolStripMenuItem.ToolTipText = "Opens the treatment editor";
            this.editTreatmentsToolStripMenuItem.Click += new System.EventHandler(this.editTreatmentsToolStripMenuItem_Click);
            // 
            // favoriteSignsToolStripMenuItem
            // 
            this.favoriteSignsToolStripMenuItem.Enabled = false;
            this.favoriteSignsToolStripMenuItem.Name = "favoriteSignsToolStripMenuItem";
            this.favoriteSignsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.favoriteSignsToolStripMenuItem.Text = "&Favorite Signs";
            this.favoriteSignsToolStripMenuItem.ToolTipText = "Manage your favorite signs";
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importCSVToolStripMenuItem.Text = "Import CSV";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.importCSVToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSep
            // 
            this.toolStripMenuItemSep.Enabled = false;
            this.toolStripMenuItemSep.Name = "toolStripMenuItemSep";
            this.toolStripMenuItemSep.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItemSep.Text = "|";
            // 
            // roadToolStripMenuItem
            // 
            this.roadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.graphsToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.roadToolStripMenuItem.Enabled = false;
            this.roadToolStripMenuItem.Name = "roadToolStripMenuItem";
            this.roadToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.roadToolStripMenuItem.Text = "Road";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.potholesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Enabled = false;
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.G)));
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // potholesToolStripMenuItem
            // 
            this.potholesToolStripMenuItem.Name = "potholesToolStripMenuItem";
            this.potholesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.potholesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.potholesToolStripMenuItem.Text = "Potholes";
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.governingDistressesToolStripMenuItem,
            this.rSLDistributionToolStripMenuItem,
            this.surfaceTypeToolStripMenuItem,
            this.functionalClassificationToolStripMenuItem});
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.graphsToolStripMenuItem.Text = "Graphs";
            // 
            // governingDistressesToolStripMenuItem
            // 
            this.governingDistressesToolStripMenuItem.Name = "governingDistressesToolStripMenuItem";
            this.governingDistressesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.governingDistressesToolStripMenuItem.Text = "Governing Distresses";
            // 
            // rSLDistributionToolStripMenuItem
            // 
            this.rSLDistributionToolStripMenuItem.Name = "rSLDistributionToolStripMenuItem";
            this.rSLDistributionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.rSLDistributionToolStripMenuItem.Text = "RSL Distribution";
            // 
            // surfaceTypeToolStripMenuItem
            // 
            this.surfaceTypeToolStripMenuItem.Name = "surfaceTypeToolStripMenuItem";
            this.surfaceTypeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.surfaceTypeToolStripMenuItem.Text = "Surface Type";
            // 
            // functionalClassificationToolStripMenuItem
            // 
            this.functionalClassificationToolStripMenuItem.Name = "functionalClassificationToolStripMenuItem";
            this.functionalClassificationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.functionalClassificationToolStripMenuItem.Text = "Functional Classification";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Enabled = false;
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // signToolStripMenuItem
            // 
            this.signToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInventoryToolStripMenuItem,
            this.signRecommendationsToolStripMenuItem,
            this.supportInventoryToolStripMenuItem,
            this.supportRecommendationsToolStripMenuItem});
            this.signToolStripMenuItem.Enabled = false;
            this.signToolStripMenuItem.Name = "signToolStripMenuItem";
            this.signToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.signToolStripMenuItem.Text = "Sign";
            // 
            // signInventoryToolStripMenuItem
            // 
            this.signInventoryToolStripMenuItem.Name = "signInventoryToolStripMenuItem";
            this.signInventoryToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.signInventoryToolStripMenuItem.Text = "Sign Inventory";
            // 
            // signRecommendationsToolStripMenuItem
            // 
            this.signRecommendationsToolStripMenuItem.Name = "signRecommendationsToolStripMenuItem";
            this.signRecommendationsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.signRecommendationsToolStripMenuItem.Text = "Sign Recommendations";
            // 
            // supportInventoryToolStripMenuItem
            // 
            this.supportInventoryToolStripMenuItem.Name = "supportInventoryToolStripMenuItem";
            this.supportInventoryToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.supportInventoryToolStripMenuItem.Text = "Support Inventory";
            // 
            // supportRecommendationsToolStripMenuItem
            // 
            this.supportRecommendationsToolStripMenuItem.Name = "supportRecommendationsToolStripMenuItem";
            this.supportRecommendationsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.supportRecommendationsToolStripMenuItem.Text = "Support Recommendations";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidewalkDistressToolStripMenuItem,
            this.roadsWithSidewalksToolStripMenuItem,
            this.severeRoadDistressToolStripMenuItem,
            this.aDARampsToolStripMenuItem,
            this.drainageToolStripMenuItem,
            this.accidentsToolStripMenuItem,
            this.allOthersToolStripMenuItem,
            this.customOutputToolStripMenuItem});
            this.otherToolStripMenuItem.Enabled = false;
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // sidewalkDistressToolStripMenuItem
            // 
            this.sidewalkDistressToolStripMenuItem.Name = "sidewalkDistressToolStripMenuItem";
            this.sidewalkDistressToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sidewalkDistressToolStripMenuItem.Text = "Sidewalk Distress";
            // 
            // roadsWithSidewalksToolStripMenuItem
            // 
            this.roadsWithSidewalksToolStripMenuItem.Name = "roadsWithSidewalksToolStripMenuItem";
            this.roadsWithSidewalksToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.roadsWithSidewalksToolStripMenuItem.Text = "Roads With Sidewalks";
            // 
            // severeRoadDistressToolStripMenuItem
            // 
            this.severeRoadDistressToolStripMenuItem.Name = "severeRoadDistressToolStripMenuItem";
            this.severeRoadDistressToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.severeRoadDistressToolStripMenuItem.Text = "Severe Road Distress";
            // 
            // aDARampsToolStripMenuItem
            // 
            this.aDARampsToolStripMenuItem.Name = "aDARampsToolStripMenuItem";
            this.aDARampsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aDARampsToolStripMenuItem.Text = "ADA Ramps";
            // 
            // drainageToolStripMenuItem
            // 
            this.drainageToolStripMenuItem.Name = "drainageToolStripMenuItem";
            this.drainageToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.drainageToolStripMenuItem.Text = "Drainage";
            // 
            // accidentsToolStripMenuItem
            // 
            this.accidentsToolStripMenuItem.Name = "accidentsToolStripMenuItem";
            this.accidentsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.accidentsToolStripMenuItem.Text = "Accidents";
            // 
            // allOthersToolStripMenuItem
            // 
            this.allOthersToolStripMenuItem.Name = "allOthersToolStripMenuItem";
            this.allOthersToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.allOthersToolStripMenuItem.Text = "All Others";
            // 
            // customOutputToolStripMenuItem
            // 
            this.customOutputToolStripMenuItem.Name = "customOutputToolStripMenuItem";
            this.customOutputToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.customOutputToolStripMenuItem.Text = "Custom Output";
            this.customOutputToolStripMenuItem.Visible = false;
            // 
            // customReportToolStripMenuItem
            // 
            this.customReportToolStripMenuItem.Name = "customReportToolStripMenuItem";
            this.customReportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.customReportToolStripMenuItem.Text = "Custom";
            this.customReportToolStripMenuItem.Click += new System.EventHandler(this.customReportToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 856);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel2.Text = "dot";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // appManager1
            // 
            this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
            this.appManager1.DockManager = null;
            this.appManager1.HeaderControl = null;
            this.appManager1.Legend = null;
            this.appManager1.Map = this.uxMap;
            this.appManager1.ProgressHandler = null;
            this.appManager1.ShowExtensionsDialogMode = DotSpatial.Controls.ShowExtensionsDialogMode.Default;
            // 
            // uxMap
            // 
            this.uxMap.AllowDrop = true;
            this.uxMap.AutoSize = true;
            this.uxMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxMap.BackColor = System.Drawing.Color.LightGray;
            this.uxMap.CollectAfterDraw = false;
            this.uxMap.CollisionDetection = false;
            this.uxMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxMap.Enabled = false;
            this.uxMap.ExtendBuffer = false;
            this.uxMap.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
            this.uxMap.IsBusy = false;
            this.uxMap.IsZoomedToMaxExtent = false;
            this.uxMap.Legend = null;
            this.uxMap.Location = new System.Drawing.Point(0, 25);
            this.uxMap.Name = "uxMap";
            this.uxMap.ProgressHandler = null;
            this.uxMap.ProjectionModeDefine = DotSpatial.Controls.ActionMode.PromptOnce;
            this.uxMap.ProjectionModeReproject = DotSpatial.Controls.ActionMode.PromptOnce;
            this.uxMap.RedrawLayersWhileResizing = false;
            this.uxMap.SelectionEnabled = true;
            this.uxMap.Size = new System.Drawing.Size(863, 799);
            this.uxMap.TabIndex = 9;
            this.uxMap.ZoomOutFartherThanMaxExtent = false;
            this.uxMap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxMap_KeyDown);
            this.uxMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxMap_MouseDown);
            this.uxMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uxMap_MouseUp);
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidePanel.AutoScroll = true;
            this.sidePanel.AutoScrollMinSize = new System.Drawing.Size(0, 771);
            this.sidePanel.AutoSize = true;
            this.sidePanel.Controls.Add(this.tabControlControls);
            this.sidePanel.Location = new System.Drawing.Point(0, 35);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(5);
            this.sidePanel.MaximumSize = new System.Drawing.Size(230, 2410);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(230, 824);
            this.sidePanel.TabIndex = 0;
            // 
            // tabControlControls
            // 
            this.tabControlControls.Controls.Add(this.tabPage1);
            this.tabControlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlControls.Location = new System.Drawing.Point(0, 0);
            this.tabControlControls.MaximumSize = new System.Drawing.Size(226, 2410);
            this.tabControlControls.Name = "tabControlControls";
            this.tabControlControls.SelectedIndex = 0;
            this.tabControlControls.Size = new System.Drawing.Size(213, 824);
            this.tabControlControls.TabIndex = 0;
            this.tabControlControls.SelectedIndexChanged += new System.EventHandler(this.tabControlControls_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(205, 798);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mapPanel
            // 
            this.mapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPanel.AutoScroll = true;
            this.mapPanel.AutoSize = true;
            this.mapPanel.Controls.Add(this.treatmentPreventative);
            this.mapPanel.Controls.Add(this.treatmentRehabilitation);
            this.mapPanel.Controls.Add(this.treatmentPreventativePatching);
            this.mapPanel.Controls.Add(this.treatmentReconstruction);
            this.mapPanel.Controls.Add(this.treatmentPatching);
            this.mapPanel.Controls.Add(this.treatmentRoutine);
            this.mapPanel.Controls.Add(this.rslBlue);
            this.mapPanel.Controls.Add(this.rslDeepSkyBlue);
            this.mapPanel.Controls.Add(this.rslGreen);
            this.mapPanel.Controls.Add(this.rslLimeGreen);
            this.mapPanel.Controls.Add(this.rslYellow);
            this.mapPanel.Controls.Add(this.rslDarkRed);
            this.mapPanel.Controls.Add(this.rslOrange);
            this.mapPanel.Controls.Add(this.rslRed);
            this.mapPanel.Controls.Add(this.uxMap);
            this.mapPanel.Controls.Add(this.toolStrip1);
            this.mapPanel.Location = new System.Drawing.Point(226, 35);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(863, 824);
            this.mapPanel.TabIndex = 1;
            // 
            // treatmentPreventative
            // 
            this.treatmentPreventative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.treatmentPreventative.BackColor = System.Drawing.Color.Yellow;
            this.treatmentPreventative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatmentPreventative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatmentPreventative.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentPreventative.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treatmentPreventative.Location = new System.Drawing.Point(713, 708);
            this.treatmentPreventative.Name = "treatmentPreventative";
            this.treatmentPreventative.ReadOnly = true;
            this.treatmentPreventative.Size = new System.Drawing.Size(136, 23);
            this.treatmentPreventative.TabIndex = 0;
            this.treatmentPreventative.Text = "Preventative";
            this.treatmentPreventative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treatmentPreventative.Visible = false;
            // 
            // treatmentRehabilitation
            // 
            this.treatmentRehabilitation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.treatmentRehabilitation.BackColor = System.Drawing.Color.Red;
            this.treatmentRehabilitation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatmentRehabilitation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatmentRehabilitation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentRehabilitation.ForeColor = System.Drawing.SystemColors.Info;
            this.treatmentRehabilitation.Location = new System.Drawing.Point(713, 766);
            this.treatmentRehabilitation.Name = "treatmentRehabilitation";
            this.treatmentRehabilitation.ReadOnly = true;
            this.treatmentRehabilitation.Size = new System.Drawing.Size(136, 23);
            this.treatmentRehabilitation.TabIndex = 1;
            this.treatmentRehabilitation.Text = "Rehabilitation";
            this.treatmentRehabilitation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treatmentRehabilitation.Visible = false;
            // 
            // treatmentPreventativePatching
            // 
            this.treatmentPreventativePatching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.treatmentPreventativePatching.BackColor = System.Drawing.Color.Orange;
            this.treatmentPreventativePatching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatmentPreventativePatching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatmentPreventativePatching.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentPreventativePatching.ForeColor = System.Drawing.SystemColors.Desktop;
            this.treatmentPreventativePatching.Location = new System.Drawing.Point(713, 737);
            this.treatmentPreventativePatching.Name = "treatmentPreventativePatching";
            this.treatmentPreventativePatching.ReadOnly = true;
            this.treatmentPreventativePatching.Size = new System.Drawing.Size(136, 23);
            this.treatmentPreventativePatching.TabIndex = 2;
            this.treatmentPreventativePatching.Text = "Preventative/Patching";
            this.treatmentPreventativePatching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treatmentPreventativePatching.Visible = false;
            // 
            // treatmentReconstruction
            // 
            this.treatmentReconstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.treatmentReconstruction.BackColor = System.Drawing.Color.DarkRed;
            this.treatmentReconstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatmentReconstruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatmentReconstruction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentReconstruction.ForeColor = System.Drawing.SystemColors.Info;
            this.treatmentReconstruction.Location = new System.Drawing.Point(713, 795);
            this.treatmentReconstruction.Name = "treatmentReconstruction";
            this.treatmentReconstruction.ReadOnly = true;
            this.treatmentReconstruction.Size = new System.Drawing.Size(136, 23);
            this.treatmentReconstruction.TabIndex = 3;
            this.treatmentReconstruction.Text = "Reconstruction";
            this.treatmentReconstruction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treatmentReconstruction.Visible = false;
            // 
            // treatmentPatching
            // 
            this.treatmentPatching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.treatmentPatching.BackColor = System.Drawing.Color.LimeGreen;
            this.treatmentPatching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatmentPatching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatmentPatching.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentPatching.ForeColor = System.Drawing.SystemColors.Info;
            this.treatmentPatching.Location = new System.Drawing.Point(713, 679);
            this.treatmentPatching.Name = "treatmentPatching";
            this.treatmentPatching.ReadOnly = true;
            this.treatmentPatching.Size = new System.Drawing.Size(136, 23);
            this.treatmentPatching.TabIndex = 4;
            this.treatmentPatching.Text = "Patching";
            this.treatmentPatching.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treatmentPatching.Visible = false;
            // 
            // treatmentRoutine
            // 
            this.treatmentRoutine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.treatmentRoutine.BackColor = System.Drawing.Color.Blue;
            this.treatmentRoutine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatmentRoutine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatmentRoutine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentRoutine.ForeColor = System.Drawing.SystemColors.Info;
            this.treatmentRoutine.Location = new System.Drawing.Point(713, 650);
            this.treatmentRoutine.Name = "treatmentRoutine";
            this.treatmentRoutine.ReadOnly = true;
            this.treatmentRoutine.Size = new System.Drawing.Size(136, 23);
            this.treatmentRoutine.TabIndex = 5;
            this.treatmentRoutine.Text = "Routine";
            this.treatmentRoutine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.treatmentRoutine.Visible = false;
            // 
            // rslBlue
            // 
            this.rslBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rslBlue.BackColor = System.Drawing.Color.Blue;
            this.rslBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rslBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rslBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslBlue.ForeColor = System.Drawing.SystemColors.Info;
            this.rslBlue.Location = new System.Drawing.Point(790, 592);
            this.rslBlue.Name = "rslBlue";
            this.rslBlue.ReadOnly = true;
            this.rslBlue.Size = new System.Drawing.Size(59, 23);
            this.rslBlue.TabIndex = 1;
            this.rslBlue.Text = "1 9 - 20";
            this.rslBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rslDeepSkyBlue
            // 
            this.rslDeepSkyBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rslDeepSkyBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rslDeepSkyBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rslDeepSkyBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rslDeepSkyBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslDeepSkyBlue.ForeColor = System.Drawing.SystemColors.Info;
            this.rslDeepSkyBlue.Location = new System.Drawing.Point(790, 621);
            this.rslDeepSkyBlue.Name = "rslDeepSkyBlue";
            this.rslDeepSkyBlue.ReadOnly = true;
            this.rslDeepSkyBlue.Size = new System.Drawing.Size(59, 23);
            this.rslDeepSkyBlue.TabIndex = 2;
            this.rslDeepSkyBlue.Text = "16 - 18";
            this.rslDeepSkyBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rslGreen
            // 
            this.rslGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rslGreen.BackColor = System.Drawing.Color.Green;
            this.rslGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rslGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rslGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslGreen.ForeColor = System.Drawing.SystemColors.Info;
            this.rslGreen.Location = new System.Drawing.Point(790, 650);
            this.rslGreen.Name = "rslGreen";
            this.rslGreen.ReadOnly = true;
            this.rslGreen.Size = new System.Drawing.Size(59, 23);
            this.rslGreen.TabIndex = 3;
            this.rslGreen.Text = "13 - 15";
            this.rslGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rslLimeGreen
            // 
            this.rslLimeGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rslLimeGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.rslLimeGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rslLimeGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rslLimeGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslLimeGreen.ForeColor = System.Drawing.SystemColors.Info;
            this.rslLimeGreen.Location = new System.Drawing.Point(790, 679);
            this.rslLimeGreen.Name = "rslLimeGreen";
            this.rslLimeGreen.ReadOnly = true;
            this.rslLimeGreen.Size = new System.Drawing.Size(59, 23);
            this.rslLimeGreen.TabIndex = 4;
            this.rslLimeGreen.Text = "10 - 12";
            this.rslLimeGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rslYellow
            // 
            this.rslYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rslYellow.BackColor = System.Drawing.Color.Yellow;
            this.rslYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rslYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rslYellow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslYellow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rslYellow.Location = new System.Drawing.Point(790, 708);
            this.rslYellow.Name = "rslYellow";
            this.rslYellow.ReadOnly = true;
            this.rslYellow.Size = new System.Drawing.Size(59, 23);
            this.rslYellow.TabIndex = 5;
            this.rslYellow.Text = "7 - 9";
            this.rslYellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rslDarkRed
            // 
            this.rslDarkRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rslDarkRed.BackColor = System.Drawing.Color.DarkRed;
            this.rslDarkRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rslDarkRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rslDarkRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslDarkRed.ForeColor = System.Drawing.SystemColors.Info;
            this.rslDarkRed.Location = new System.Drawing.Point(790, 795);
            this.rslDarkRed.Name = "rslDarkRed";
            this.rslDarkRed.ReadOnly = true;
            this.rslDarkRed.Size = new System.Drawing.Size(59, 23);
            this.rslDarkRed.TabIndex = 8;
            this.rslDarkRed.Text = "0";
            this.rslDarkRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rslOrange
            // 
            this.rslOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rslOrange.BackColor = System.Drawing.Color.Orange;
            this.rslOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rslOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rslOrange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslOrange.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rslOrange.Location = new System.Drawing.Point(790, 737);
            this.rslOrange.Name = "rslOrange";
            this.rslOrange.ReadOnly = true;
            this.rslOrange.Size = new System.Drawing.Size(59, 23);
            this.rslOrange.TabIndex = 6;
            this.rslOrange.Text = "4 - 6";
            this.rslOrange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rslRed
            // 
            this.rslRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rslRed.BackColor = System.Drawing.Color.Red;
            this.rslRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rslRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rslRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rslRed.ForeColor = System.Drawing.SystemColors.Info;
            this.rslRed.Location = new System.Drawing.Point(790, 766);
            this.rslRed.Name = "rslRed";
            this.rslRed.ReadOnly = true;
            this.rslRed.Size = new System.Drawing.Size(59, 23);
            this.rslRed.TabIndex = 7;
            this.rslRed.Text = "1 - 3";
            this.rslRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripZoomIn,
            this.toolStripZoomOut,
            this.toolStripZoomExt,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.buttonModePan,
            this.buttonModeSelect,
            this.buttonModeTable,
            this.buttonModeZoomin,
            this.toolStripSeparator2,
            this.labelId,
            this.toolStripComboBoxFind,
            this.toolStripTextBoxSearch,
            this.toolStripButtonSearch,
            this.toolStripButtonSnapShot});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Zoom:";
            // 
            // toolStripZoomIn
            // 
            this.toolStripZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomIn.Image = global::tams4a.Properties.Resources.zoom_in;
            this.toolStripZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomIn.Name = "toolStripZoomIn";
            this.toolStripZoomIn.Size = new System.Drawing.Size(23, 22);
            this.toolStripZoomIn.Text = "Zoom In";
            this.toolStripZoomIn.Click += new System.EventHandler(this.toolStripZoomIn_Click);
            // 
            // toolStripZoomOut
            // 
            this.toolStripZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomOut.Image = global::tams4a.Properties.Resources.zoom_out;
            this.toolStripZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomOut.Name = "toolStripZoomOut";
            this.toolStripZoomOut.Size = new System.Drawing.Size(23, 22);
            this.toolStripZoomOut.Text = "Zoom Out";
            this.toolStripZoomOut.Click += new System.EventHandler(this.toolStripZoomOut_Click);
            // 
            // toolStripZoomExt
            // 
            this.toolStripZoomExt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomExt.Image = global::tams4a.Properties.Resources.zoom_ext;
            this.toolStripZoomExt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomExt.Name = "toolStripZoomExt";
            this.toolStripZoomExt.Size = new System.Drawing.Size(23, 22);
            this.toolStripZoomExt.Text = "Zoom to Fit";
            this.toolStripZoomExt.Click += new System.EventHandler(this.toolStripZoomExt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel2.Text = "Mode:";
            // 
            // buttonModePan
            // 
            this.buttonModePan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonModePan.Image = global::tams4a.Properties.Resources.pan;
            this.buttonModePan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonModePan.Name = "buttonModePan";
            this.buttonModePan.Size = new System.Drawing.Size(23, 22);
            this.buttonModePan.Text = "Pan";
            this.buttonModePan.ToolTipText = "Pan Map";
            this.buttonModePan.Click += new System.EventHandler(this.setMode_Click);
            // 
            // buttonModeSelect
            // 
            this.buttonModeSelect.Checked = true;
            this.buttonModeSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonModeSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonModeSelect.Image = global::tams4a.Properties.Resources.info;
            this.buttonModeSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonModeSelect.Name = "buttonModeSelect";
            this.buttonModeSelect.Size = new System.Drawing.Size(23, 22);
            this.buttonModeSelect.Text = "Select";
            this.buttonModeSelect.ToolTipText = "Select Item(s)";
            this.buttonModeSelect.Click += new System.EventHandler(this.setMode_Click);
            // 
            // buttonModeTable
            // 
            this.buttonModeTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonModeTable.Image = ((System.Drawing.Image)(resources.GetObject("buttonModeTable.Image")));
            this.buttonModeTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonModeTable.Name = "buttonModeTable";
            this.buttonModeTable.Size = new System.Drawing.Size(23, 22);
            this.buttonModeTable.Text = "Data Table";
            this.buttonModeTable.Click += new System.EventHandler(this.setMode_Click);
            // 
            // buttonModeZoomin
            // 
            this.buttonModeZoomin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonModeZoomin.Image = global::tams4a.Properties.Resources.zoom_select;
            this.buttonModeZoomin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonModeZoomin.Name = "buttonModeZoomin";
            this.buttonModeZoomin.Size = new System.Drawing.Size(23, 22);
            this.buttonModeZoomin.Text = "Zoom To Selection";
            this.buttonModeZoomin.Click += new System.EventHandler(this.setMode_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // labelId
            // 
            this.labelId.Enabled = false;
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(30, 22);
            this.labelId.Text = "Find";
            // 
            // toolStripComboBoxFind
            // 
            this.toolStripComboBoxFind.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxFind.Items.AddRange(new object[] {
            "ID",
            "Street"});
            this.toolStripComboBoxFind.Name = "toolStripComboBoxFind";
            this.toolStripComboBoxFind.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxSearch.ToolTipText = "Find Shape by ID";
            this.toolStripTextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxSearch_keyDown);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = global::tams4a.Properties.Resources.go;
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearch.Text = "toolStripButton6";
            this.toolStripButtonSearch.ToolTipText = "Search";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // toolStripButtonSnapShot
            // 
            this.toolStripButtonSnapShot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSnapShot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSnapShot.Image")));
            this.toolStripButtonSnapShot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSnapShot.Name = "toolStripButtonSnapShot";
            this.toolStripButtonSnapShot.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSnapShot.Text = "toolStripButtonSnapShot";
            this.toolStripButtonSnapShot.ToolTipText = "Take Snap Shot of the Map";
            this.toolStripButtonSnapShot.Click += new System.EventHandler(this.toolStripButtonSnapShot_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1087, 878);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainWindow";
            this.Text = "TAMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.window_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkHotKeys);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.tabControlControls.ResumeLayout(false);
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private DotSpatial.Controls.AppManager appManager1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripZoomExt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton buttonModePan;
        private System.Windows.Forms.ToolStripButton buttonModeSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitTAMSToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControlControls;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton buttonModeTable;
        private System.Windows.Forms.ToolTip toolTip;
        protected System.Windows.Forms.ToolStripLabel labelId;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportProblemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton buttonModeZoomin;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem importRoadsToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSnapShot;
        private System.Windows.Forms.ToolStripMenuItem editTreatmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelToolStripMenuItem;
        public DotSpatial.Controls.Map uxMap;
        private System.Windows.Forms.ToolStripMenuItem favoriteSignsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSep;
        private System.Windows.Forms.ToolStripMenuItem roadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potholesToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signRecommendationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportRecommendationsToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem supportInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidewalkDistressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem severeRoadDistressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDARampsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drainageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOthersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roadsWithSidewalksToolStripMenuItem;
        public Dictionary<TextBox, Color> rslLegend = new Dictionary<TextBox, Color>();
        public System.Windows.Forms.TextBox rslRed;
        public System.Windows.Forms.TextBox rslBlue;
        public System.Windows.Forms.TextBox rslDeepSkyBlue;
        public System.Windows.Forms.TextBox rslGreen;
        public System.Windows.Forms.TextBox rslLimeGreen;
        public System.Windows.Forms.TextBox rslYellow;
        public System.Windows.Forms.TextBox rslDarkRed;
        public System.Windows.Forms.TextBox rslOrange;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        public Dictionary<TextBox, Color> treatmentLegend = new Dictionary<TextBox, Color>();
        public System.Windows.Forms.TextBox treatmentPatching;
        public System.Windows.Forms.TextBox treatmentRoutine;
        public System.Windows.Forms.TextBox treatmentPreventative;
        public System.Windows.Forms.TextBox treatmentRehabilitation;
        public System.Windows.Forms.TextBox treatmentPreventativePatching;
        public System.Windows.Forms.TextBox treatmentReconstruction;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem governingDistressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSLDistributionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surfaceTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionalClassificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFind;
        private ToolStripMenuItem customReportToolStripMenuItem;
    }
}

