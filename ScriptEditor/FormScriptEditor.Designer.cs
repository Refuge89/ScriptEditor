﻿namespace ScriptEditor
{
    partial class FormScriptEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScriptEditor));
            this.lstActions = new System.Windows.Forms.ListView();
            this.columnDelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblId = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtScriptId = new System.Windows.Forms.TextBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblCommandCondition = new System.Windows.Forms.Label();
            this.btnCommandCondition = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtCommandComment = new System.Windows.Forms.TextBox();
            this.grpDataFlags = new System.Windows.Forms.GroupBox();
            this.chkAbortScript = new System.Windows.Forms.CheckBox();
            this.chkTargetSelf = new System.Windows.Forms.CheckBox();
            this.chkSwapFinal = new System.Windows.Forms.CheckBox();
            this.chkSwapInitial = new System.Windows.Forms.CheckBox();
            this.grpBuddy = new System.Windows.Forms.GroupBox();
            this.lblTargetType = new System.Windows.Forms.Label();
            this.txtTargetParam1 = new System.Windows.Forms.TextBox();
            this.cmbTargetType = new System.Windows.Forms.ComboBox();
            this.lblTargetParam2 = new System.Windows.Forms.Label();
            this.txtTargetParam2 = new System.Windows.Forms.TextBox();
            this.lblTargetParam1 = new System.Windows.Forms.Label();
            this.txtCommandDelay = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.cmbCommandId = new System.Windows.Forms.ComboBox();
            this.frmCommandTalk = new System.Windows.Forms.Panel();
            this.lblTalkTextPreview = new System.Windows.Forms.Label();
            this.lblTalkBroadcastId = new System.Windows.Forms.Label();
            this.lblTalkTooltip = new System.Windows.Forms.Label();
            this.txtTalkText4 = new System.Windows.Forms.TextBox();
            this.txtTalkText3 = new System.Windows.Forms.TextBox();
            this.txtTalkText2 = new System.Windows.Forms.TextBox();
            this.txtTalkText1 = new System.Windows.Forms.TextBox();
            this.btnTalkText4 = new System.Windows.Forms.Button();
            this.btnTalkText3 = new System.Windows.Forms.Button();
            this.btnTalkText2 = new System.Windows.Forms.Button();
            this.btnTalkText1 = new System.Windows.Forms.Button();
            this.cmbTalkChatType = new System.Windows.Forms.ComboBox();
            this.lblTalkChatType = new System.Windows.Forms.Label();
            this.btnActionDelete = new System.Windows.Forms.Button();
            this.btnActionAdd = new System.Windows.Forms.Button();
            this.lblScriptId = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.frmCommandEmote = new System.Windows.Forms.Panel();
            this.lblEmoteTooltip = new System.Windows.Forms.Label();
            this.cmbEmoteId = new System.Windows.Forms.ComboBox();
            this.lblEmoteId = new System.Windows.Forms.Label();
            this.frmCommandFieldSet = new System.Windows.Forms.Panel();
            this.lvlFieldSetValue = new System.Windows.Forms.Label();
            this.lblFieldSetField = new System.Windows.Forms.Label();
            this.txtFieldSetValue = new System.Windows.Forms.TextBox();
            this.cmbFieldSetFields = new System.Windows.Forms.ComboBox();
            this.lblFieldSetTooltip = new System.Windows.Forms.Label();
            this.frmCommandMoveTo = new System.Windows.Forms.Panel();
            this.chkMoveToFlagsPointMovement = new System.Windows.Forms.CheckBox();
            this.chkMoveToFlagsForce = new System.Windows.Forms.CheckBox();
            this.lblMoveToO = new System.Windows.Forms.Label();
            this.lblMoveToZ = new System.Windows.Forms.Label();
            this.lblMoveToY = new System.Windows.Forms.Label();
            this.lblMoveToX = new System.Windows.Forms.Label();
            this.txtMoveToO = new System.Windows.Forms.TextBox();
            this.txtMoveToZ = new System.Windows.Forms.TextBox();
            this.txtMoveToY = new System.Windows.Forms.TextBox();
            this.txtMoveToX = new System.Windows.Forms.TextBox();
            this.grpMoveToOptions = new System.Windows.Forms.GroupBox();
            this.chkMoveOptions256 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions128 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions64 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions32 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions16 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions8 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions4 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions2 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions1 = new System.Windows.Forms.CheckBox();
            this.lblMoveToTime = new System.Windows.Forms.Label();
            this.txtMoveToTime = new System.Windows.Forms.TextBox();
            this.lblMoveToType = new System.Windows.Forms.Label();
            this.cmbMoveToType = new System.Windows.Forms.ComboBox();
            this.lblMoveToTooltip = new System.Windows.Forms.Label();
            this.frmCommandTeleport = new System.Windows.Forms.Panel();
            this.grpTeleportOptions = new System.Windows.Forms.GroupBox();
            this.chkTeleportOptions32 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions16 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions8 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions4 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions2 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions1 = new System.Windows.Forms.CheckBox();
            this.lblTeleportO = new System.Windows.Forms.Label();
            this.lblTeleportZ = new System.Windows.Forms.Label();
            this.lblTeleportY = new System.Windows.Forms.Label();
            this.lblTeleportX = new System.Windows.Forms.Label();
            this.lblTeleportMapId = new System.Windows.Forms.Label();
            this.txtTeleportO = new System.Windows.Forms.TextBox();
            this.cmbTeleportMap = new System.Windows.Forms.ComboBox();
            this.txtTeleportZ = new System.Windows.Forms.TextBox();
            this.txtTeleportY = new System.Windows.Forms.TextBox();
            this.txtTeleportX = new System.Windows.Forms.TextBox();
            this.lblTeleportTooltip = new System.Windows.Forms.Label();
            this.frmCommandQuestComplete = new System.Windows.Forms.Panel();
            this.lblQuestCompleteId = new System.Windows.Forms.Label();
            this.lblQuestCompleteDistance = new System.Windows.Forms.Label();
            this.txtQuestCompleteDistance = new System.Windows.Forms.TextBox();
            this.btnQuestCompleteId = new System.Windows.Forms.Button();
            this.lblQuestCompleteTooltip = new System.Windows.Forms.Label();
            this.frmCommandKillCredit = new System.Windows.Forms.Panel();
            this.cmbKillCreditType = new System.Windows.Forms.ComboBox();
            this.lblKillCreditCreatureId = new System.Windows.Forms.Label();
            this.lblKillCreditType = new System.Windows.Forms.Label();
            this.btnKillCreditCreatureId = new System.Windows.Forms.Button();
            this.lblKillCreditTooltip = new System.Windows.Forms.Label();
            this.frmCommandRespawnGameobject = new System.Windows.Forms.Panel();
            this.lblRespawnGameobjectDelay = new System.Windows.Forms.Label();
            this.lblRespawnGameobjectGuid = new System.Windows.Forms.Label();
            this.txtRespawnGameobjectDelay = new System.Windows.Forms.TextBox();
            this.txtRespawnGameobjectGuid = new System.Windows.Forms.TextBox();
            this.lblRespawnGameobjectTooltip = new System.Windows.Forms.Label();
            this.frmCommandSummonCreature = new System.Windows.Forms.Panel();
            this.lblSummonCreatureDespawnType = new System.Windows.Forms.Label();
            this.cmbSummonCreatureDespawnType = new System.Windows.Forms.ComboBox();
            this.lblSummonCreatureO = new System.Windows.Forms.Label();
            this.lblSummonCreatureZ = new System.Windows.Forms.Label();
            this.lblSummonCreatureY = new System.Windows.Forms.Label();
            this.lblSummonCreatureX = new System.Windows.Forms.Label();
            this.txtSummonCreatureO = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureZ = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureY = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureX = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureUniqueRange = new System.Windows.Forms.Label();
            this.lblSummonCreatureUniqueLimit = new System.Windows.Forms.Label();
            this.txtSummonCreatureUniqueRange = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureUniqueLimit = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureAttackTarget = new System.Windows.Forms.Label();
            this.cmbSummonCreatureAttackTarget = new System.Windows.Forms.ComboBox();
            this.lblSummonCreatureFacingOptions = new System.Windows.Forms.Label();
            this.cmbSummonCreatureFacingOptions = new System.Windows.Forms.ComboBox();
            this.lblSummonCreatureDelay = new System.Windows.Forms.Label();
            this.txtSummonCreatureDelay = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureId = new System.Windows.Forms.Label();
            this.grpSummonCreatureFlags = new System.Windows.Forms.GroupBox();
            this.chkSummonCreatureFlags1 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags8 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags4 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags2 = new System.Windows.Forms.CheckBox();
            this.btnSummonCreatureId = new System.Windows.Forms.Button();
            this.lblSummonCreatureTooltip = new System.Windows.Forms.Label();
            this.frmCommandDoor = new System.Windows.Forms.Panel();
            this.lblDoorResetDelay = new System.Windows.Forms.Label();
            this.lblDoorGuid = new System.Windows.Forms.Label();
            this.txtDoorResetDelay = new System.Windows.Forms.TextBox();
            this.txtDoorGuid = new System.Windows.Forms.TextBox();
            this.lblDoorTooltip = new System.Windows.Forms.Label();
            this.frmCommandRemoveAura = new System.Windows.Forms.Panel();
            this.btnRemoveAuraSpellId = new System.Windows.Forms.Button();
            this.lblRemoveAuraSpellId = new System.Windows.Forms.Label();
            this.lblRemoveAuraTooltip = new System.Windows.Forms.Label();
            this.frmCommandCastSpell = new System.Windows.Forms.Panel();
            this.grpCastSpellFlags = new System.Windows.Forms.GroupBox();
            this.chkCastSpellFlags128 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags64 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags32 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags16 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags4 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags1 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags2 = new System.Windows.Forms.CheckBox();
            this.btnCastSpellId = new System.Windows.Forms.Button();
            this.lblCastSpellId = new System.Windows.Forms.Label();
            this.lblCastSpellTooltip = new System.Windows.Forms.Label();
            this.frmCommandPlaySound = new System.Windows.Forms.Panel();
            this.btnPlaySoundId = new System.Windows.Forms.Button();
            this.grpPlaySoundFlags = new System.Windows.Forms.GroupBox();
            this.chkPlaySoundFlags2 = new System.Windows.Forms.CheckBox();
            this.chkPlaySoundFlags1 = new System.Windows.Forms.CheckBox();
            this.lblPlaySoundId = new System.Windows.Forms.Label();
            this.lblPlaySoundTooltip = new System.Windows.Forms.Label();
            this.frmCommandCreateItem = new System.Windows.Forms.Panel();
            this.lblCreateItemAmount = new System.Windows.Forms.Label();
            this.txtCreateItemAmount = new System.Windows.Forms.TextBox();
            this.btnCreateItemId = new System.Windows.Forms.Button();
            this.lblCreateItemId = new System.Windows.Forms.Label();
            this.lblCreateItemTooltip = new System.Windows.Forms.Label();
            this.frmCommandDespawnCreature = new System.Windows.Forms.Panel();
            this.lblDespawnCreatureDelay = new System.Windows.Forms.Label();
            this.txtDespawnCreatureDelay = new System.Windows.Forms.TextBox();
            this.lblDespawnCreatureTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetEquipment = new System.Windows.Forms.Panel();
            this.lblSetEquipmentRanged = new System.Windows.Forms.Label();
            this.lblSetEquipmentOffHand = new System.Windows.Forms.Label();
            this.lblSetEquipmentMainHand = new System.Windows.Forms.Label();
            this.btnSetEquipmentRanged = new System.Windows.Forms.Button();
            this.btnSetEquipmentOffHand = new System.Windows.Forms.Button();
            this.btnSetEquipmentMainHand = new System.Windows.Forms.Button();
            this.cmbSetEquipmentUseDefault = new System.Windows.Forms.ComboBox();
            this.lblSetEquipmentUseDefault = new System.Windows.Forms.Label();
            this.lblSetEquipmentTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetMovement = new System.Windows.Forms.Panel();
            this.lblSetMovementAngle = new System.Windows.Forms.Label();
            this.txtSetMovementAngle = new System.Windows.Forms.TextBox();
            this.txtSetMovementDistance = new System.Windows.Forms.TextBox();
            this.txtSetMovementIntParam = new System.Windows.Forms.TextBox();
            this.cmbSetMovementBoolParam = new System.Windows.Forms.ComboBox();
            this.lblSetMovementDistance = new System.Windows.Forms.Label();
            this.lblSetMovementIntParam = new System.Windows.Forms.Label();
            this.lblSetMovementBoolParam = new System.Windows.Forms.Label();
            this.cmbSetMovementType = new System.Windows.Forms.ComboBox();
            this.lblSetMovementType = new System.Windows.Forms.Label();
            this.lblSetMovementTooltip = new System.Windows.Forms.Label();
            this.frmCommandActiveObject = new System.Windows.Forms.Panel();
            this.cmbActiveObjectSetActive = new System.Windows.Forms.ComboBox();
            this.lblActiveObjectSetActive = new System.Windows.Forms.Label();
            this.lblActiveObjectTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetFaction = new System.Windows.Forms.Panel();
            this.btnSetFactionId = new System.Windows.Forms.Button();
            this.grpSetFactionFlags = new System.Windows.Forms.GroupBox();
            this.chkSetFactionFlag4 = new System.Windows.Forms.CheckBox();
            this.chkSetFactionFlag2 = new System.Windows.Forms.CheckBox();
            this.chkSetFactionFlag1 = new System.Windows.Forms.CheckBox();
            this.lblSetFactionId = new System.Windows.Forms.Label();
            this.lblSetFactionTooltip = new System.Windows.Forms.Label();
            this.frmCommandMorphOrMount = new System.Windows.Forms.Panel();
            this.cmbMorphOrMountType = new System.Windows.Forms.ComboBox();
            this.lblMorphOrMountId = new System.Windows.Forms.Label();
            this.lblMorphOrMountType = new System.Windows.Forms.Label();
            this.btnMorphOrMountId = new System.Windows.Forms.Button();
            this.lblMorphOrMountTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetRun = new System.Windows.Forms.Panel();
            this.cmbSetRunMode = new System.Windows.Forms.ComboBox();
            this.lblSetRunMode = new System.Windows.Forms.Label();
            this.lblSetRunTooltip = new System.Windows.Forms.Label();
            this.frmCommandModifyFlags = new System.Windows.Forms.Panel();
            this.chkModifyFlags536870912 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags268435456 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags134217728 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags67108864 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags33554432 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags16777216 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags8388608 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags4194304 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags2097152 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags1048576 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags524288 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags262144 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags131072 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags65536 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags32768 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags16384 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags8192 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags4096 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags2048 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags1024 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags512 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags256 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags128 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags64 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags32 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags16 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags8 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags4 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags2 = new System.Windows.Forms.CheckBox();
            this.chkModifyFlags1 = new System.Windows.Forms.CheckBox();
            this.cmbModifyFlagsMode = new System.Windows.Forms.ComboBox();
            this.lblModifyFlagsMode = new System.Windows.Forms.Label();
            this.cmbModifyFlagsFieldId = new System.Windows.Forms.ComboBox();
            this.lblModifyFlagsField = new System.Windows.Forms.Label();
            this.lblModifyFlagsTooltip = new System.Windows.Forms.Label();
            this.frmCommandInterruptCasts = new System.Windows.Forms.Panel();
            this.cmbInterruptCastsWithDelayed = new System.Windows.Forms.ComboBox();
            this.lblInterruptCastsSpellId = new System.Windows.Forms.Label();
            this.lblInterruptCastsWithDelayed = new System.Windows.Forms.Label();
            this.btnInterruptCastsSpellId = new System.Windows.Forms.Button();
            this.lblInterruptCastsTooltip = new System.Windows.Forms.Label();
            this.frmCommandUpdateEntry = new System.Windows.Forms.Panel();
            this.cmbUpdateEntryTeam = new System.Windows.Forms.ComboBox();
            this.lblUpdateEntryCreatureId = new System.Windows.Forms.Label();
            this.lblUpdateEntryTeam = new System.Windows.Forms.Label();
            this.btnUpdateEntryCreatureId = new System.Windows.Forms.Button();
            this.lblUpdateEntryTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetStandState = new System.Windows.Forms.Panel();
            this.cmbSetStandState = new System.Windows.Forms.ComboBox();
            this.lblSetStandState = new System.Windows.Forms.Label();
            this.lblSetStandStateTooltip = new System.Windows.Forms.Label();
            this.frmCommandModifyThreat = new System.Windows.Forms.Panel();
            this.lblModifyThreatPercent = new System.Windows.Forms.Label();
            this.txtModifyThreatPercent = new System.Windows.Forms.TextBox();
            this.cmbModifyThreatTarget = new System.Windows.Forms.ComboBox();
            this.lblModifyThreatTarget = new System.Windows.Forms.Label();
            this.lblModifyThreatTooltip = new System.Windows.Forms.Label();
            this.frmCommandSendTaxiPath = new System.Windows.Forms.Panel();
            this.lblSendTaxiPath = new System.Windows.Forms.Label();
            this.txtSendTaxiPath = new System.Windows.Forms.TextBox();
            this.btnSendTaxiPathId = new System.Windows.Forms.Button();
            this.lblSendTaxiPathId = new System.Windows.Forms.Label();
            this.lblSendTaxiPathTooltip = new System.Windows.Forms.Label();
            this.frmCommandTerminateScript = new System.Windows.Forms.Panel();
            this.lblTerminateScriptCondition = new System.Windows.Forms.Label();
            this.cmbTerminateScriptCondition = new System.Windows.Forms.ComboBox();
            this.lblTerminateScriptCreatureId = new System.Windows.Forms.Label();
            this.lblTerminateScriptSearchRadius = new System.Windows.Forms.Label();
            this.txtTerminateScriptSearchRadius = new System.Windows.Forms.TextBox();
            this.btnTerminateScriptCreatureId = new System.Windows.Forms.Button();
            this.lblTerminateScriptTooltip = new System.Windows.Forms.Label();
            this.frmCommandTerminateCondition = new System.Windows.Forms.Panel();
            this.btnTerminateConditionQuest = new System.Windows.Forms.Button();
            this.lblTerminateConditionRule = new System.Windows.Forms.Label();
            this.cmbTerminateConditionRule = new System.Windows.Forms.ComboBox();
            this.lblTerminateConditionId = new System.Windows.Forms.Label();
            this.lblTerminateConditionQuestId = new System.Windows.Forms.Label();
            this.btnTerminateConditionId = new System.Windows.Forms.Button();
            this.lblTerminateConditionTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetHomePosition = new System.Windows.Forms.Panel();
            this.lblSetHomePositionO = new System.Windows.Forms.Label();
            this.lblSetHomePositionZ = new System.Windows.Forms.Label();
            this.txtSetHomePositionO = new System.Windows.Forms.TextBox();
            this.txtSetHomePositionZ = new System.Windows.Forms.TextBox();
            this.lblSetHomePositionY = new System.Windows.Forms.Label();
            this.lblSetHomePositionX = new System.Windows.Forms.Label();
            this.txtSetHomePositionY = new System.Windows.Forms.TextBox();
            this.txtSetHomePositionX = new System.Windows.Forms.TextBox();
            this.cmbSetHomePositionMode = new System.Windows.Forms.ComboBox();
            this.lblSetHomePositionMode = new System.Windows.Forms.Label();
            this.lblSetHomePositionTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetFacing = new System.Windows.Forms.Panel();
            this.lblSetFacingOrientation = new System.Windows.Forms.Label();
            this.txtSetFacingOrientation = new System.Windows.Forms.TextBox();
            this.cmbSetFacingMode = new System.Windows.Forms.ComboBox();
            this.lblSetFacingMode = new System.Windows.Forms.Label();
            this.lblSetFacingTooltip = new System.Windows.Forms.Label();
            this.frmCommandMeetingStone = new System.Windows.Forms.Panel();
            this.btnMeetingStoneAreaId = new System.Windows.Forms.Button();
            this.lblMeetingStoneAreaId = new System.Windows.Forms.Label();
            this.lblMeetingStoneTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetData = new System.Windows.Forms.Panel();
            this.lblSetDataValue = new System.Windows.Forms.Label();
            this.txtSetDataValue = new System.Windows.Forms.TextBox();
            this.lblSetDataField = new System.Windows.Forms.Label();
            this.txtSetDataField = new System.Windows.Forms.TextBox();
            this.cmbSetDataMode = new System.Windows.Forms.ComboBox();
            this.lblSetDataMode = new System.Windows.Forms.Label();
            this.lblSetDataTooltip = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.frmCommandStartScript = new System.Windows.Forms.Panel();
            this.btnStartScriptEdit4 = new System.Windows.Forms.Button();
            this.btnStartScriptEdit3 = new System.Windows.Forms.Button();
            this.btnStartScriptEdit2 = new System.Windows.Forms.Button();
            this.btnStartScriptEdit1 = new System.Windows.Forms.Button();
            this.txtStartScriptChance4 = new System.Windows.Forms.TextBox();
            this.txtStartScriptId4 = new System.Windows.Forms.TextBox();
            this.txtStartScriptChance3 = new System.Windows.Forms.TextBox();
            this.txtStartScriptId3 = new System.Windows.Forms.TextBox();
            this.txtStartScriptChance2 = new System.Windows.Forms.TextBox();
            this.txtStartScriptId2 = new System.Windows.Forms.TextBox();
            this.txtStartScriptChance1 = new System.Windows.Forms.TextBox();
            this.txtStartScriptId1 = new System.Windows.Forms.TextBox();
            this.lblStartScriptChance = new System.Windows.Forms.Label();
            this.lblStartScriptId = new System.Windows.Forms.Label();
            this.lblStartScriptTooltip = new System.Windows.Forms.Label();
            this.lblNoAction = new System.Windows.Forms.Label();
            this.btnActionCopy = new System.Windows.Forms.Button();
            this.btnViewRaw = new System.Windows.Forms.Button();
            this.frmCommandSetPhase = new System.Windows.Forms.Panel();
            this.lblSetPhasePhase = new System.Windows.Forms.Label();
            this.lblSetPhaseMode = new System.Windows.Forms.Label();
            this.txtSetPhasePhase = new System.Windows.Forms.TextBox();
            this.cmbSetPhaseMode = new System.Windows.Forms.ComboBox();
            this.lblSetPhaseTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetRandomPhase = new System.Windows.Forms.Panel();
            this.lblSetRandomPhase4 = new System.Windows.Forms.Label();
            this.txtSetRandomPhase4 = new System.Windows.Forms.TextBox();
            this.lblSetRandomPhase3 = new System.Windows.Forms.Label();
            this.txtSetRandomPhase3 = new System.Windows.Forms.TextBox();
            this.txtSetRandomPhase1 = new System.Windows.Forms.TextBox();
            this.lblSetRandomPhase2 = new System.Windows.Forms.Label();
            this.lblSetRandomPhase1 = new System.Windows.Forms.Label();
            this.txtSetRandomPhase2 = new System.Windows.Forms.TextBox();
            this.lblSetRandomPhaseTooltip = new System.Windows.Forms.Label();
            this.frmCommandFlee = new System.Windows.Forms.Panel();
            this.cmbFleeMode = new System.Windows.Forms.ComboBox();
            this.lblFleeMode = new System.Windows.Forms.Label();
            this.lblFleeTooltip = new System.Windows.Forms.Label();
            this.frmCommandCallForHelp = new System.Windows.Forms.Panel();
            this.lblCallForHelpRadius = new System.Windows.Forms.Label();
            this.txtCallForHelpRadius = new System.Windows.Forms.TextBox();
            this.lblCallForHelpTooltip = new System.Windows.Forms.Label();
            this.frmCommandGameEvent = new System.Windows.Forms.Panel();
            this.cmbGameEventOverwrite = new System.Windows.Forms.ComboBox();
            this.lblGameEventOverwrite = new System.Windows.Forms.Label();
            this.cmbGameEventAction = new System.Windows.Forms.ComboBox();
            this.lblGameEventId = new System.Windows.Forms.Label();
            this.lblGameEventAction = new System.Windows.Forms.Label();
            this.btnGameEventId = new System.Windows.Forms.Button();
            this.lblCommandGameEventTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetSpellsTemplate = new System.Windows.Forms.Panel();
            this.btnSetSpellsTemplate4 = new System.Windows.Forms.Button();
            this.txtSetSpellsTemplateChance4 = new System.Windows.Forms.TextBox();
            this.btnSetSpellsTemplate3 = new System.Windows.Forms.Button();
            this.txtSetSpellsTemplateChance3 = new System.Windows.Forms.TextBox();
            this.btnSetSpellsTemplate2 = new System.Windows.Forms.Button();
            this.txtSetSpellsTemplateChance2 = new System.Windows.Forms.TextBox();
            this.btnSetSpellsTemplate1 = new System.Windows.Forms.Button();
            this.txtSetSpellsTemplateChance1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSetSpellsTempalteId = new System.Windows.Forms.Label();
            this.lblSetSpellsTemplateTooltip = new System.Windows.Forms.Label();
            this.grpGeneral.SuspendLayout();
            this.grpDataFlags.SuspendLayout();
            this.grpBuddy.SuspendLayout();
            this.frmCommandTalk.SuspendLayout();
            this.frmCommandEmote.SuspendLayout();
            this.frmCommandFieldSet.SuspendLayout();
            this.frmCommandMoveTo.SuspendLayout();
            this.grpMoveToOptions.SuspendLayout();
            this.frmCommandTeleport.SuspendLayout();
            this.grpTeleportOptions.SuspendLayout();
            this.frmCommandQuestComplete.SuspendLayout();
            this.frmCommandKillCredit.SuspendLayout();
            this.frmCommandRespawnGameobject.SuspendLayout();
            this.frmCommandSummonCreature.SuspendLayout();
            this.grpSummonCreatureFlags.SuspendLayout();
            this.frmCommandDoor.SuspendLayout();
            this.frmCommandRemoveAura.SuspendLayout();
            this.frmCommandCastSpell.SuspendLayout();
            this.grpCastSpellFlags.SuspendLayout();
            this.frmCommandPlaySound.SuspendLayout();
            this.grpPlaySoundFlags.SuspendLayout();
            this.frmCommandCreateItem.SuspendLayout();
            this.frmCommandDespawnCreature.SuspendLayout();
            this.frmCommandSetEquipment.SuspendLayout();
            this.frmCommandSetMovement.SuspendLayout();
            this.frmCommandActiveObject.SuspendLayout();
            this.frmCommandSetFaction.SuspendLayout();
            this.grpSetFactionFlags.SuspendLayout();
            this.frmCommandMorphOrMount.SuspendLayout();
            this.frmCommandSetRun.SuspendLayout();
            this.frmCommandModifyFlags.SuspendLayout();
            this.frmCommandInterruptCasts.SuspendLayout();
            this.frmCommandUpdateEntry.SuspendLayout();
            this.frmCommandSetStandState.SuspendLayout();
            this.frmCommandModifyThreat.SuspendLayout();
            this.frmCommandSendTaxiPath.SuspendLayout();
            this.frmCommandTerminateScript.SuspendLayout();
            this.frmCommandTerminateCondition.SuspendLayout();
            this.frmCommandSetHomePosition.SuspendLayout();
            this.frmCommandSetFacing.SuspendLayout();
            this.frmCommandMeetingStone.SuspendLayout();
            this.frmCommandSetData.SuspendLayout();
            this.frmCommandStartScript.SuspendLayout();
            this.frmCommandSetPhase.SuspendLayout();
            this.frmCommandSetRandomPhase.SuspendLayout();
            this.frmCommandFlee.SuspendLayout();
            this.frmCommandCallForHelp.SuspendLayout();
            this.frmCommandGameEvent.SuspendLayout();
            this.frmCommandSetSpellsTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstActions
            // 
            this.lstActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDelay,
            this.columnCommand,
            this.columnComment});
            this.lstActions.FullRowSelect = true;
            this.lstActions.GridLines = true;
            this.lstActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstActions.HideSelection = false;
            this.lstActions.Location = new System.Drawing.Point(20, 62);
            this.lstActions.MultiSelect = false;
            this.lstActions.Name = "lstActions";
            this.lstActions.Size = new System.Drawing.Size(355, 520);
            this.lstActions.TabIndex = 0;
            this.lstActions.UseCompatibleStateImageBehavior = false;
            this.lstActions.View = System.Windows.Forms.View.Details;
            this.lstActions.SelectedIndexChanged += new System.EventHandler(this.lstActions_SelectedIndexChanged);
            // 
            // columnDelay
            // 
            this.columnDelay.Text = "Delay";
            this.columnDelay.Width = 50;
            // 
            // columnCommand
            // 
            this.columnCommand.Text = "Command";
            // 
            // columnComment
            // 
            this.columnComment.Text = "Comment";
            this.columnComment.Width = 240;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "No script loaded.";
            // 
            // cmbTable
            // 
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "event_scripts",
            "gossip_scripts",
            "gameobject_scripts",
            "spell_scripts",
            "quest_start_scripts",
            "quest_end_scripts",
            "creature_movement_scripts",
            "creature_spells_scripts",
            "creature_ai_scripts"});
            this.cmbTable.Location = new System.Drawing.Point(672, 24);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(154, 21);
            this.cmbTable.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(833, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(72, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtScriptId
            // 
            this.txtScriptId.Location = new System.Drawing.Point(590, 25);
            this.txtScriptId.Name = "txtScriptId";
            this.txtScriptId.Size = new System.Drawing.Size(76, 20);
            this.txtScriptId.TabIndex = 4;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblCommandCondition);
            this.grpGeneral.Controls.Add(this.btnCommandCondition);
            this.grpGeneral.Controls.Add(this.lblComment);
            this.grpGeneral.Controls.Add(this.txtCommandComment);
            this.grpGeneral.Controls.Add(this.grpDataFlags);
            this.grpGeneral.Controls.Add(this.grpBuddy);
            this.grpGeneral.Controls.Add(this.txtCommandDelay);
            this.grpGeneral.Controls.Add(this.lblDelay);
            this.grpGeneral.Controls.Add(this.lblCommand);
            this.grpGeneral.Controls.Add(this.cmbCommandId);
            this.grpGeneral.Enabled = false;
            this.grpGeneral.Location = new System.Drawing.Point(410, 62);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(495, 182);
            this.grpGeneral.TabIndex = 5;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Command Data";
            // 
            // lblCommandCondition
            // 
            this.lblCommandCondition.AutoSize = true;
            this.lblCommandCondition.Location = new System.Drawing.Point(21, 109);
            this.lblCommandCondition.Name = "lblCommandCondition";
            this.lblCommandCondition.Size = new System.Drawing.Size(54, 13);
            this.lblCommandCondition.TabIndex = 14;
            this.lblCommandCondition.Text = "Condition:";
            // 
            // btnCommandCondition
            // 
            this.btnCommandCondition.Location = new System.Drawing.Point(24, 125);
            this.btnCommandCondition.Name = "btnCommandCondition";
            this.btnCommandCondition.Size = new System.Drawing.Size(133, 21);
            this.btnCommandCondition.TabIndex = 13;
            this.btnCommandCondition.Text = "-NONE-";
            this.btnCommandCondition.UseVisualStyleBackColor = true;
            this.btnCommandCondition.Click += new System.EventHandler(this.btnCommandCondition_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(22, 158);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 12;
            this.lblComment.Text = "Comment:";
            // 
            // txtCommandComment
            // 
            this.txtCommandComment.Location = new System.Drawing.Point(81, 155);
            this.txtCommandComment.Name = "txtCommandComment";
            this.txtCommandComment.Size = new System.Drawing.Size(392, 20);
            this.txtCommandComment.TabIndex = 11;
            this.txtCommandComment.Leave += new System.EventHandler(this.txtCommandComment_Leave);
            // 
            // grpDataFlags
            // 
            this.grpDataFlags.Controls.Add(this.chkAbortScript);
            this.grpDataFlags.Controls.Add(this.chkTargetSelf);
            this.grpDataFlags.Controls.Add(this.chkSwapFinal);
            this.grpDataFlags.Controls.Add(this.chkSwapInitial);
            this.grpDataFlags.Location = new System.Drawing.Point(321, 19);
            this.grpDataFlags.Name = "grpDataFlags";
            this.grpDataFlags.Size = new System.Drawing.Size(152, 128);
            this.grpDataFlags.TabIndex = 10;
            this.grpDataFlags.TabStop = false;
            this.grpDataFlags.Text = "Data Flags";
            // 
            // chkAbortScript
            // 
            this.chkAbortScript.AutoSize = true;
            this.chkAbortScript.Location = new System.Drawing.Point(6, 90);
            this.chkAbortScript.Name = "chkAbortScript";
            this.chkAbortScript.Size = new System.Drawing.Size(132, 17);
            this.chkAbortScript.TabIndex = 3;
            this.chkAbortScript.Text = "Abort Script On Failure";
            this.chkAbortScript.UseVisualStyleBackColor = true;
            this.chkAbortScript.CheckedChanged += new System.EventHandler(this.chkAbortScript_CheckedChanged);
            // 
            // chkTargetSelf
            // 
            this.chkTargetSelf.AutoSize = true;
            this.chkTargetSelf.Location = new System.Drawing.Point(6, 69);
            this.chkTargetSelf.Name = "chkTargetSelf";
            this.chkTargetSelf.Size = new System.Drawing.Size(78, 17);
            this.chkTargetSelf.TabIndex = 2;
            this.chkTargetSelf.Text = "Target Self";
            this.chkTargetSelf.UseVisualStyleBackColor = true;
            this.chkTargetSelf.CheckedChanged += new System.EventHandler(this.chkTargetSelf_CheckedChanged);
            // 
            // chkSwapFinal
            // 
            this.chkSwapFinal.AutoSize = true;
            this.chkSwapFinal.Location = new System.Drawing.Point(6, 48);
            this.chkSwapFinal.Name = "chkSwapFinal";
            this.chkSwapFinal.Size = new System.Drawing.Size(117, 17);
            this.chkSwapFinal.TabIndex = 1;
            this.chkSwapFinal.Text = "Swap Final Targets";
            this.chkSwapFinal.UseVisualStyleBackColor = true;
            this.chkSwapFinal.CheckedChanged += new System.EventHandler(this.chkSwapFinal_CheckedChanged);
            // 
            // chkSwapInitial
            // 
            this.chkSwapInitial.AutoSize = true;
            this.chkSwapInitial.Location = new System.Drawing.Point(6, 26);
            this.chkSwapInitial.Name = "chkSwapInitial";
            this.chkSwapInitial.Size = new System.Drawing.Size(119, 17);
            this.chkSwapInitial.TabIndex = 0;
            this.chkSwapInitial.Text = "Swap Initial Targets";
            this.chkSwapInitial.UseVisualStyleBackColor = true;
            this.chkSwapInitial.CheckedChanged += new System.EventHandler(this.chkSwapInitial_CheckedChanged);
            // 
            // grpBuddy
            // 
            this.grpBuddy.Controls.Add(this.lblTargetType);
            this.grpBuddy.Controls.Add(this.txtTargetParam1);
            this.grpBuddy.Controls.Add(this.cmbTargetType);
            this.grpBuddy.Controls.Add(this.lblTargetParam2);
            this.grpBuddy.Controls.Add(this.txtTargetParam2);
            this.grpBuddy.Controls.Add(this.lblTargetParam1);
            this.grpBuddy.Location = new System.Drawing.Point(162, 19);
            this.grpBuddy.Name = "grpBuddy";
            this.grpBuddy.Size = new System.Drawing.Size(153, 128);
            this.grpBuddy.TabIndex = 9;
            this.grpBuddy.TabStop = false;
            this.grpBuddy.Text = "Target";
            // 
            // lblTargetType
            // 
            this.lblTargetType.AutoSize = true;
            this.lblTargetType.Location = new System.Drawing.Point(22, 77);
            this.lblTargetType.Name = "lblTargetType";
            this.lblTargetType.Size = new System.Drawing.Size(107, 13);
            this.lblTargetType.TabIndex = 9;
            this.lblTargetType.Text = "Target for this action:";
            // 
            // txtTargetParam1
            // 
            this.txtTargetParam1.Location = new System.Drawing.Point(64, 23);
            this.txtTargetParam1.Name = "txtTargetParam1";
            this.txtTargetParam1.Size = new System.Drawing.Size(83, 20);
            this.txtTargetParam1.TabIndex = 4;
            this.txtTargetParam1.Leave += new System.EventHandler(this.txtTargetParam1_Leave);
            // 
            // cmbTargetType
            // 
            this.cmbTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetType.FormattingEnabled = true;
            this.cmbTargetType.Location = new System.Drawing.Point(9, 94);
            this.cmbTargetType.Name = "cmbTargetType";
            this.cmbTargetType.Size = new System.Drawing.Size(138, 21);
            this.cmbTargetType.TabIndex = 6;
            this.cmbTargetType.SelectedIndexChanged += new System.EventHandler(this.cmbTargetType_SelectedIndexChanged);
            // 
            // lblTargetParam2
            // 
            this.lblTargetParam2.AutoSize = true;
            this.lblTargetParam2.Location = new System.Drawing.Point(6, 49);
            this.lblTargetParam2.Name = "lblTargetParam2";
            this.lblTargetParam2.Size = new System.Drawing.Size(43, 13);
            this.lblTargetParam2.TabIndex = 8;
            this.lblTargetParam2.Text = "Radius:";
            // 
            // txtTargetParam2
            // 
            this.txtTargetParam2.Location = new System.Drawing.Point(64, 49);
            this.txtTargetParam2.Name = "txtTargetParam2";
            this.txtTargetParam2.Size = new System.Drawing.Size(83, 20);
            this.txtTargetParam2.TabIndex = 5;
            this.txtTargetParam2.Leave += new System.EventHandler(this.txtTargetParam2_Leave);
            // 
            // lblTargetParam1
            // 
            this.lblTargetParam1.AutoSize = true;
            this.lblTargetParam1.Location = new System.Drawing.Point(6, 26);
            this.lblTargetParam1.Name = "lblTargetParam1";
            this.lblTargetParam1.Size = new System.Drawing.Size(19, 13);
            this.lblTargetParam1.TabIndex = 7;
            this.lblTargetParam1.Text = "Id:";
            // 
            // txtCommandDelay
            // 
            this.txtCommandDelay.Location = new System.Drawing.Point(24, 42);
            this.txtCommandDelay.Name = "txtCommandDelay";
            this.txtCommandDelay.Size = new System.Drawing.Size(132, 20);
            this.txtCommandDelay.TabIndex = 3;
            this.txtCommandDelay.Leave += new System.EventHandler(this.txtCommandDelay_Leave);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(20, 26);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(51, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay (s):";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(21, 67);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(57, 13);
            this.lblCommand.TabIndex = 1;
            this.lblCommand.Text = "Command:";
            // 
            // cmbCommandId
            // 
            this.cmbCommandId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommandId.FormattingEnabled = true;
            this.cmbCommandId.Location = new System.Drawing.Point(23, 83);
            this.cmbCommandId.Name = "cmbCommandId";
            this.cmbCommandId.Size = new System.Drawing.Size(133, 21);
            this.cmbCommandId.TabIndex = 0;
            this.cmbCommandId.SelectedIndexChanged += new System.EventHandler(this.cmbCommandId_SelectedIndexChanged);
            // 
            // frmCommandTalk
            // 
            this.frmCommandTalk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTalk.Controls.Add(this.lblTalkTextPreview);
            this.frmCommandTalk.Controls.Add(this.lblTalkBroadcastId);
            this.frmCommandTalk.Controls.Add(this.lblTalkTooltip);
            this.frmCommandTalk.Controls.Add(this.txtTalkText4);
            this.frmCommandTalk.Controls.Add(this.txtTalkText3);
            this.frmCommandTalk.Controls.Add(this.txtTalkText2);
            this.frmCommandTalk.Controls.Add(this.txtTalkText1);
            this.frmCommandTalk.Controls.Add(this.btnTalkText4);
            this.frmCommandTalk.Controls.Add(this.btnTalkText3);
            this.frmCommandTalk.Controls.Add(this.btnTalkText2);
            this.frmCommandTalk.Controls.Add(this.btnTalkText1);
            this.frmCommandTalk.Controls.Add(this.cmbTalkChatType);
            this.frmCommandTalk.Controls.Add(this.lblTalkChatType);
            this.frmCommandTalk.Location = new System.Drawing.Point(410, 250);
            this.frmCommandTalk.Name = "frmCommandTalk";
            this.frmCommandTalk.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTalk.TabIndex = 6;
            this.frmCommandTalk.Visible = false;
            // 
            // lblTalkTextPreview
            // 
            this.lblTalkTextPreview.AutoSize = true;
            this.lblTalkTextPreview.Location = new System.Drawing.Point(153, 63);
            this.lblTalkTextPreview.Name = "lblTalkTextPreview";
            this.lblTalkTextPreview.Size = new System.Drawing.Size(72, 13);
            this.lblTalkTextPreview.TabIndex = 12;
            this.lblTalkTextPreview.Text = "Text Preview:";
            // 
            // lblTalkBroadcastId
            // 
            this.lblTalkBroadcastId.AutoSize = true;
            this.lblTalkBroadcastId.Location = new System.Drawing.Point(22, 63);
            this.lblTalkBroadcastId.Name = "lblTalkBroadcastId";
            this.lblTalkBroadcastId.Size = new System.Drawing.Size(96, 13);
            this.lblTalkBroadcastId.TabIndex = 11;
            this.lblTalkBroadcastId.Text = "Broadcast Text ID:";
            // 
            // lblTalkTooltip
            // 
            this.lblTalkTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTalkTooltip.Location = new System.Drawing.Point(19, 10);
            this.lblTalkTooltip.Name = "lblTalkTooltip";
            this.lblTalkTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblTalkTooltip.TabIndex = 10;
            this.lblTalkTooltip.Text = "The source says the specified text. Can be used by any WorldObject, including Gam" +
    "eObjects. If you specify multiple text ids, a random one will be chosen.";
            // 
            // txtTalkText4
            // 
            this.txtTalkText4.Location = new System.Drawing.Point(153, 173);
            this.txtTalkText4.Name = "txtTalkText4";
            this.txtTalkText4.ReadOnly = true;
            this.txtTalkText4.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText4.TabIndex = 9;
            // 
            // txtTalkText3
            // 
            this.txtTalkText3.Location = new System.Drawing.Point(153, 144);
            this.txtTalkText3.Name = "txtTalkText3";
            this.txtTalkText3.ReadOnly = true;
            this.txtTalkText3.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText3.TabIndex = 8;
            // 
            // txtTalkText2
            // 
            this.txtTalkText2.Location = new System.Drawing.Point(153, 115);
            this.txtTalkText2.Name = "txtTalkText2";
            this.txtTalkText2.ReadOnly = true;
            this.txtTalkText2.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText2.TabIndex = 7;
            // 
            // txtTalkText1
            // 
            this.txtTalkText1.Location = new System.Drawing.Point(153, 86);
            this.txtTalkText1.Name = "txtTalkText1";
            this.txtTalkText1.ReadOnly = true;
            this.txtTalkText1.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText1.TabIndex = 6;
            // 
            // btnTalkText4
            // 
            this.btnTalkText4.Location = new System.Drawing.Point(19, 172);
            this.btnTalkText4.Name = "btnTalkText4";
            this.btnTalkText4.Size = new System.Drawing.Size(122, 23);
            this.btnTalkText4.TabIndex = 5;
            this.btnTalkText4.Text = "-NONE-";
            this.btnTalkText4.UseVisualStyleBackColor = true;
            this.btnTalkText4.Click += new System.EventHandler(this.btnTalkText4_Click);
            // 
            // btnTalkText3
            // 
            this.btnTalkText3.Location = new System.Drawing.Point(19, 143);
            this.btnTalkText3.Name = "btnTalkText3";
            this.btnTalkText3.Size = new System.Drawing.Size(122, 23);
            this.btnTalkText3.TabIndex = 4;
            this.btnTalkText3.Text = "-NONE-";
            this.btnTalkText3.UseVisualStyleBackColor = true;
            this.btnTalkText3.Click += new System.EventHandler(this.btnTalkText3_Click);
            // 
            // btnTalkText2
            // 
            this.btnTalkText2.Location = new System.Drawing.Point(19, 114);
            this.btnTalkText2.Name = "btnTalkText2";
            this.btnTalkText2.Size = new System.Drawing.Size(122, 23);
            this.btnTalkText2.TabIndex = 3;
            this.btnTalkText2.Text = "-NONE-";
            this.btnTalkText2.UseVisualStyleBackColor = true;
            this.btnTalkText2.Click += new System.EventHandler(this.btnTalkText2_Click);
            // 
            // btnTalkText1
            // 
            this.btnTalkText1.Location = new System.Drawing.Point(19, 85);
            this.btnTalkText1.Name = "btnTalkText1";
            this.btnTalkText1.Size = new System.Drawing.Size(122, 23);
            this.btnTalkText1.TabIndex = 2;
            this.btnTalkText1.Text = "-NONE-";
            this.btnTalkText1.UseVisualStyleBackColor = true;
            this.btnTalkText1.Click += new System.EventHandler(this.btnTalkText1_Click);
            // 
            // cmbTalkChatType
            // 
            this.cmbTalkChatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTalkChatType.FormattingEnabled = true;
            this.cmbTalkChatType.Location = new System.Drawing.Point(153, 201);
            this.cmbTalkChatType.Name = "cmbTalkChatType";
            this.cmbTalkChatType.Size = new System.Drawing.Size(121, 21);
            this.cmbTalkChatType.TabIndex = 1;
            this.cmbTalkChatType.SelectedIndexChanged += new System.EventHandler(this.cmbTalkChatType_SelectedIndexChanged);
            // 
            // lblTalkChatType
            // 
            this.lblTalkChatType.AutoSize = true;
            this.lblTalkChatType.Location = new System.Drawing.Point(39, 209);
            this.lblTalkChatType.Name = "lblTalkChatType";
            this.lblTalkChatType.Size = new System.Drawing.Size(102, 13);
            this.lblTalkChatType.TabIndex = 0;
            this.lblTalkChatType.Text = "Chat Type Override:";
            // 
            // btnActionDelete
            // 
            this.btnActionDelete.Location = new System.Drawing.Point(300, 588);
            this.btnActionDelete.Name = "btnActionDelete";
            this.btnActionDelete.Size = new System.Drawing.Size(75, 23);
            this.btnActionDelete.TabIndex = 7;
            this.btnActionDelete.Text = "Delete";
            this.btnActionDelete.UseVisualStyleBackColor = true;
            this.btnActionDelete.Click += new System.EventHandler(this.btnActionDelete_Click);
            // 
            // btnActionAdd
            // 
            this.btnActionAdd.Location = new System.Drawing.Point(138, 588);
            this.btnActionAdd.Name = "btnActionAdd";
            this.btnActionAdd.Size = new System.Drawing.Size(75, 23);
            this.btnActionAdd.TabIndex = 8;
            this.btnActionAdd.Text = "Add";
            this.btnActionAdd.UseVisualStyleBackColor = true;
            this.btnActionAdd.Click += new System.EventHandler(this.btnActionAdd_Click);
            // 
            // lblScriptId
            // 
            this.lblScriptId.AutoSize = true;
            this.lblScriptId.Location = new System.Drawing.Point(587, 9);
            this.lblScriptId.Name = "lblScriptId";
            this.lblScriptId.Size = new System.Drawing.Size(19, 13);
            this.lblScriptId.TabIndex = 9;
            this.lblScriptId.Text = "Id:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(669, 9);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(37, 13);
            this.lblTable.TabIndex = 10;
            this.lblTable.Text = "Table:";
            // 
            // frmCommandEmote
            // 
            this.frmCommandEmote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandEmote.Controls.Add(this.lblEmoteTooltip);
            this.frmCommandEmote.Controls.Add(this.cmbEmoteId);
            this.frmCommandEmote.Controls.Add(this.lblEmoteId);
            this.frmCommandEmote.Location = new System.Drawing.Point(410, 250);
            this.frmCommandEmote.Name = "frmCommandEmote";
            this.frmCommandEmote.Size = new System.Drawing.Size(495, 332);
            this.frmCommandEmote.TabIndex = 11;
            this.frmCommandEmote.Visible = false;
            // 
            // lblEmoteTooltip
            // 
            this.lblEmoteTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmoteTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblEmoteTooltip.Name = "lblEmoteTooltip";
            this.lblEmoteTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblEmoteTooltip.TabIndex = 2;
            this.lblEmoteTooltip.Text = "The source performs the specified visual emote. Can only be used by Units.";
            // 
            // cmbEmoteId
            // 
            this.cmbEmoteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmoteId.FormattingEnabled = true;
            this.cmbEmoteId.Location = new System.Drawing.Point(99, 58);
            this.cmbEmoteId.Name = "cmbEmoteId";
            this.cmbEmoteId.Size = new System.Drawing.Size(374, 21);
            this.cmbEmoteId.TabIndex = 1;
            this.cmbEmoteId.SelectedIndexChanged += new System.EventHandler(this.cmbEmoteId_SelectedIndexChanged);
            // 
            // lblEmoteId
            // 
            this.lblEmoteId.AutoSize = true;
            this.lblEmoteId.Location = new System.Drawing.Point(44, 61);
            this.lblEmoteId.Name = "lblEmoteId";
            this.lblEmoteId.Size = new System.Drawing.Size(52, 13);
            this.lblEmoteId.TabIndex = 0;
            this.lblEmoteId.Text = "Emote Id:";
            // 
            // frmCommandFieldSet
            // 
            this.frmCommandFieldSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandFieldSet.Controls.Add(this.lvlFieldSetValue);
            this.frmCommandFieldSet.Controls.Add(this.lblFieldSetField);
            this.frmCommandFieldSet.Controls.Add(this.txtFieldSetValue);
            this.frmCommandFieldSet.Controls.Add(this.cmbFieldSetFields);
            this.frmCommandFieldSet.Controls.Add(this.lblFieldSetTooltip);
            this.frmCommandFieldSet.Location = new System.Drawing.Point(410, 250);
            this.frmCommandFieldSet.Name = "frmCommandFieldSet";
            this.frmCommandFieldSet.Size = new System.Drawing.Size(495, 332);
            this.frmCommandFieldSet.TabIndex = 12;
            this.frmCommandFieldSet.Visible = false;
            // 
            // lvlFieldSetValue
            // 
            this.lvlFieldSetValue.AutoSize = true;
            this.lvlFieldSetValue.Location = new System.Drawing.Point(59, 93);
            this.lvlFieldSetValue.Name = "lvlFieldSetValue";
            this.lvlFieldSetValue.Size = new System.Drawing.Size(37, 13);
            this.lvlFieldSetValue.TabIndex = 4;
            this.lvlFieldSetValue.Text = "Value:";
            // 
            // lblFieldSetField
            // 
            this.lblFieldSetField.AutoSize = true;
            this.lblFieldSetField.Location = new System.Drawing.Point(64, 61);
            this.lblFieldSetField.Name = "lblFieldSetField";
            this.lblFieldSetField.Size = new System.Drawing.Size(32, 13);
            this.lblFieldSetField.TabIndex = 3;
            this.lblFieldSetField.Text = "Field:";
            // 
            // txtFieldSetValue
            // 
            this.txtFieldSetValue.Location = new System.Drawing.Point(99, 90);
            this.txtFieldSetValue.Name = "txtFieldSetValue";
            this.txtFieldSetValue.Size = new System.Drawing.Size(374, 20);
            this.txtFieldSetValue.TabIndex = 2;
            this.txtFieldSetValue.Leave += new System.EventHandler(this.txtFieldSetValue_Leave);
            // 
            // cmbFieldSetFields
            // 
            this.cmbFieldSetFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldSetFields.FormattingEnabled = true;
            this.cmbFieldSetFields.Location = new System.Drawing.Point(99, 58);
            this.cmbFieldSetFields.Name = "cmbFieldSetFields";
            this.cmbFieldSetFields.Size = new System.Drawing.Size(374, 21);
            this.cmbFieldSetFields.TabIndex = 1;
            this.cmbFieldSetFields.SelectedIndexChanged += new System.EventHandler(this.cmbFieldSetFields_SelectedIndexChanged);
            // 
            // lblFieldSetTooltip
            // 
            this.lblFieldSetTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFieldSetTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblFieldSetTooltip.Name = "lblFieldSetTooltip";
            this.lblFieldSetTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblFieldSetTooltip.TabIndex = 0;
            this.lblFieldSetTooltip.Text = "Sets the chosen update field to the value specified. Can be used on any object, b" +
    "ut the fields are different based on the type. Only use if you know what you are" +
    " doing.";
            // 
            // frmCommandMoveTo
            // 
            this.frmCommandMoveTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandMoveTo.Controls.Add(this.chkMoveToFlagsPointMovement);
            this.frmCommandMoveTo.Controls.Add(this.chkMoveToFlagsForce);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToO);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToZ);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToY);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToX);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToO);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToZ);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToY);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToX);
            this.frmCommandMoveTo.Controls.Add(this.grpMoveToOptions);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToTime);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToTime);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToType);
            this.frmCommandMoveTo.Controls.Add(this.cmbMoveToType);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToTooltip);
            this.frmCommandMoveTo.Location = new System.Drawing.Point(410, 250);
            this.frmCommandMoveTo.Name = "frmCommandMoveTo";
            this.frmCommandMoveTo.Size = new System.Drawing.Size(495, 332);
            this.frmCommandMoveTo.TabIndex = 13;
            this.frmCommandMoveTo.Visible = false;
            // 
            // chkMoveToFlagsPointMovement
            // 
            this.chkMoveToFlagsPointMovement.AutoSize = true;
            this.chkMoveToFlagsPointMovement.Location = new System.Drawing.Point(20, 271);
            this.chkMoveToFlagsPointMovement.Name = "chkMoveToFlagsPointMovement";
            this.chkMoveToFlagsPointMovement.Size = new System.Drawing.Size(175, 17);
            this.chkMoveToFlagsPointMovement.TabIndex = 15;
            this.chkMoveToFlagsPointMovement.Text = "Use Point Movement Generator";
            this.chkMoveToFlagsPointMovement.UseVisualStyleBackColor = true;
            this.chkMoveToFlagsPointMovement.CheckedChanged += new System.EventHandler(this.chkMoveToFlagsPointMovement_CheckedChanged);
            // 
            // chkMoveToFlagsForce
            // 
            this.chkMoveToFlagsForce.AutoSize = true;
            this.chkMoveToFlagsForce.Location = new System.Drawing.Point(20, 248);
            this.chkMoveToFlagsForce.Name = "chkMoveToFlagsForce";
            this.chkMoveToFlagsForce.Size = new System.Drawing.Size(106, 17);
            this.chkMoveToFlagsForce.TabIndex = 14;
            this.chkMoveToFlagsForce.Text = "Force Movement";
            this.chkMoveToFlagsForce.UseVisualStyleBackColor = true;
            this.chkMoveToFlagsForce.CheckedChanged += new System.EventHandler(this.chkMoveToFlagsForce_CheckedChanged);
            // 
            // lblMoveToO
            // 
            this.lblMoveToO.AutoSize = true;
            this.lblMoveToO.Location = new System.Drawing.Point(131, 195);
            this.lblMoveToO.Name = "lblMoveToO";
            this.lblMoveToO.Size = new System.Drawing.Size(61, 13);
            this.lblMoveToO.TabIndex = 13;
            this.lblMoveToO.Text = "Orientation:";
            // 
            // lblMoveToZ
            // 
            this.lblMoveToZ.AutoSize = true;
            this.lblMoveToZ.Location = new System.Drawing.Point(23, 195);
            this.lblMoveToZ.Name = "lblMoveToZ";
            this.lblMoveToZ.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToZ.TabIndex = 12;
            this.lblMoveToZ.Text = "Z coordinate:";
            // 
            // lblMoveToY
            // 
            this.lblMoveToY.AutoSize = true;
            this.lblMoveToY.Location = new System.Drawing.Point(132, 155);
            this.lblMoveToY.Name = "lblMoveToY";
            this.lblMoveToY.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToY.TabIndex = 11;
            this.lblMoveToY.Text = "Y coordinate:";
            // 
            // lblMoveToX
            // 
            this.lblMoveToX.AutoSize = true;
            this.lblMoveToX.Location = new System.Drawing.Point(23, 155);
            this.lblMoveToX.Name = "lblMoveToX";
            this.lblMoveToX.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToX.TabIndex = 10;
            this.lblMoveToX.Text = "X coordinate:";
            // 
            // txtMoveToO
            // 
            this.txtMoveToO.Location = new System.Drawing.Point(128, 212);
            this.txtMoveToO.Name = "txtMoveToO";
            this.txtMoveToO.Size = new System.Drawing.Size(92, 20);
            this.txtMoveToO.TabIndex = 9;
            this.txtMoveToO.Leave += new System.EventHandler(this.txtMoveToO_Leave);
            // 
            // txtMoveToZ
            // 
            this.txtMoveToZ.Location = new System.Drawing.Point(19, 212);
            this.txtMoveToZ.Name = "txtMoveToZ";
            this.txtMoveToZ.Size = new System.Drawing.Size(92, 20);
            this.txtMoveToZ.TabIndex = 8;
            this.txtMoveToZ.Leave += new System.EventHandler(this.txtMoveToZ_Leave);
            // 
            // txtMoveToY
            // 
            this.txtMoveToY.Location = new System.Drawing.Point(128, 172);
            this.txtMoveToY.Name = "txtMoveToY";
            this.txtMoveToY.Size = new System.Drawing.Size(92, 20);
            this.txtMoveToY.TabIndex = 7;
            this.txtMoveToY.Leave += new System.EventHandler(this.txtMoveToY_Leave);
            // 
            // txtMoveToX
            // 
            this.txtMoveToX.Location = new System.Drawing.Point(19, 172);
            this.txtMoveToX.Name = "txtMoveToX";
            this.txtMoveToX.Size = new System.Drawing.Size(92, 20);
            this.txtMoveToX.TabIndex = 6;
            this.txtMoveToX.Leave += new System.EventHandler(this.txtMoveToX_Leave);
            // 
            // grpMoveToOptions
            // 
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions256);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions128);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions64);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions32);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions16);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions8);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions4);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions2);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions1);
            this.grpMoveToOptions.Location = new System.Drawing.Point(249, 58);
            this.grpMoveToOptions.Name = "grpMoveToOptions";
            this.grpMoveToOptions.Size = new System.Drawing.Size(224, 254);
            this.grpMoveToOptions.TabIndex = 5;
            this.grpMoveToOptions.TabStop = false;
            this.grpMoveToOptions.Text = "Move Options";
            // 
            // chkMoveOptions256
            // 
            this.chkMoveOptions256.AutoSize = true;
            this.chkMoveOptions256.Location = new System.Drawing.Point(8, 227);
            this.chkMoveOptions256.Name = "chkMoveOptions256";
            this.chkMoveOptions256.Size = new System.Drawing.Size(153, 17);
            this.chkMoveOptions256.TabIndex = 8;
            this.chkMoveOptions256.Text = "MOVE_STRAIGHT_PATH";
            this.chkMoveOptions256.UseVisualStyleBackColor = true;
            this.chkMoveOptions256.CheckedChanged += new System.EventHandler(this.chkMoveOptions256_CheckedChanged);
            // 
            // chkMoveOptions128
            // 
            this.chkMoveOptions128.AutoSize = true;
            this.chkMoveOptions128.Location = new System.Drawing.Point(8, 202);
            this.chkMoveOptions128.Name = "chkMoveOptions128";
            this.chkMoveOptions128.Size = new System.Drawing.Size(202, 17);
            this.chkMoveOptions128.TabIndex = 7;
            this.chkMoveOptions128.Text = "MOVE_EXCLUDE_STEEP_SLOPES";
            this.chkMoveOptions128.UseVisualStyleBackColor = true;
            this.chkMoveOptions128.CheckedChanged += new System.EventHandler(this.chkMoveOptions128_CheckedChanged);
            // 
            // chkMoveOptions64
            // 
            this.chkMoveOptions64.AutoSize = true;
            this.chkMoveOptions64.Location = new System.Drawing.Point(8, 177);
            this.chkMoveOptions64.Name = "chkMoveOptions64";
            this.chkMoveOptions64.Size = new System.Drawing.Size(178, 17);
            this.chkMoveOptions64.TabIndex = 6;
            this.chkMoveOptions64.Text = "MOVE_FORCE_DESTINATION";
            this.chkMoveOptions64.UseVisualStyleBackColor = true;
            this.chkMoveOptions64.CheckedChanged += new System.EventHandler(this.chkMoveOptions64_CheckedChanged);
            // 
            // chkMoveOptions32
            // 
            this.chkMoveOptions32.AutoSize = true;
            this.chkMoveOptions32.Location = new System.Drawing.Point(8, 152);
            this.chkMoveOptions32.Name = "chkMoveOptions32";
            this.chkMoveOptions32.Size = new System.Drawing.Size(107, 17);
            this.chkMoveOptions32.TabIndex = 5;
            this.chkMoveOptions32.Text = "MOVE_FALLING";
            this.chkMoveOptions32.UseVisualStyleBackColor = true;
            this.chkMoveOptions32.CheckedChanged += new System.EventHandler(this.chkMoveOptions32_CheckedChanged);
            // 
            // chkMoveOptions16
            // 
            this.chkMoveOptions16.AutoSize = true;
            this.chkMoveOptions16.Location = new System.Drawing.Point(8, 127);
            this.chkMoveOptions16.Name = "chkMoveOptions16";
            this.chkMoveOptions16.Size = new System.Drawing.Size(100, 17);
            this.chkMoveOptions16.TabIndex = 4;
            this.chkMoveOptions16.Text = "MOVE_CYCLIC";
            this.chkMoveOptions16.UseVisualStyleBackColor = true;
            this.chkMoveOptions16.CheckedChanged += new System.EventHandler(this.chkMoveOptions16_CheckedChanged);
            // 
            // chkMoveOptions8
            // 
            this.chkMoveOptions8.AutoSize = true;
            this.chkMoveOptions8.Location = new System.Drawing.Point(8, 102);
            this.chkMoveOptions8.Name = "chkMoveOptions8";
            this.chkMoveOptions8.Size = new System.Drawing.Size(120, 17);
            this.chkMoveOptions8.TabIndex = 3;
            this.chkMoveOptions8.Text = "MOVE_FLY_MODE";
            this.chkMoveOptions8.UseVisualStyleBackColor = true;
            this.chkMoveOptions8.CheckedChanged += new System.EventHandler(this.chkMoveOptions8_CheckedChanged);
            // 
            // chkMoveOptions4
            // 
            this.chkMoveOptions4.AutoSize = true;
            this.chkMoveOptions4.Location = new System.Drawing.Point(8, 77);
            this.chkMoveOptions4.Name = "chkMoveOptions4";
            this.chkMoveOptions4.Size = new System.Drawing.Size(125, 17);
            this.chkMoveOptions4.TabIndex = 2;
            this.chkMoveOptions4.Text = "MOVE_RUN_MODE";
            this.chkMoveOptions4.UseVisualStyleBackColor = true;
            this.chkMoveOptions4.CheckedChanged += new System.EventHandler(this.chkMoveOptions4_CheckedChanged);
            // 
            // chkMoveOptions2
            // 
            this.chkMoveOptions2.AutoSize = true;
            this.chkMoveOptions2.Location = new System.Drawing.Point(8, 52);
            this.chkMoveOptions2.Name = "chkMoveOptions2";
            this.chkMoveOptions2.Size = new System.Drawing.Size(132, 17);
            this.chkMoveOptions2.TabIndex = 1;
            this.chkMoveOptions2.Text = "MOVE_WALK_MODE";
            this.chkMoveOptions2.UseVisualStyleBackColor = true;
            this.chkMoveOptions2.CheckedChanged += new System.EventHandler(this.chkMoveOptions2_CheckedChanged);
            // 
            // chkMoveOptions1
            // 
            this.chkMoveOptions1.AutoSize = true;
            this.chkMoveOptions1.Location = new System.Drawing.Point(8, 27);
            this.chkMoveOptions1.Name = "chkMoveOptions1";
            this.chkMoveOptions1.Size = new System.Drawing.Size(136, 17);
            this.chkMoveOptions1.TabIndex = 0;
            this.chkMoveOptions1.Text = "MOVE_PATHFINDING";
            this.chkMoveOptions1.UseVisualStyleBackColor = true;
            this.chkMoveOptions1.CheckedChanged += new System.EventHandler(this.chkMoveOptions1_CheckedChanged);
            // 
            // lblMoveToTime
            // 
            this.lblMoveToTime.AutoSize = true;
            this.lblMoveToTime.Location = new System.Drawing.Point(23, 107);
            this.lblMoveToTime.Name = "lblMoveToTime";
            this.lblMoveToTime.Size = new System.Drawing.Size(55, 13);
            this.lblMoveToTime.TabIndex = 4;
            this.lblMoveToTime.Text = "Time (ms):";
            // 
            // txtMoveToTime
            // 
            this.txtMoveToTime.Location = new System.Drawing.Point(20, 123);
            this.txtMoveToTime.Name = "txtMoveToTime";
            this.txtMoveToTime.Size = new System.Drawing.Size(200, 20);
            this.txtMoveToTime.TabIndex = 3;
            this.txtMoveToTime.Leave += new System.EventHandler(this.txtMoveToTime_Leave);
            // 
            // lblMoveToType
            // 
            this.lblMoveToType.AutoSize = true;
            this.lblMoveToType.Location = new System.Drawing.Point(23, 58);
            this.lblMoveToType.Name = "lblMoveToType";
            this.lblMoveToType.Size = new System.Drawing.Size(93, 13);
            this.lblMoveToType.TabIndex = 2;
            this.lblMoveToType.Text = "Coordinates Type:";
            // 
            // cmbMoveToType
            // 
            this.cmbMoveToType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveToType.FormattingEnabled = true;
            this.cmbMoveToType.Location = new System.Drawing.Point(20, 75);
            this.cmbMoveToType.Name = "cmbMoveToType";
            this.cmbMoveToType.Size = new System.Drawing.Size(200, 21);
            this.cmbMoveToType.TabIndex = 1;
            this.cmbMoveToType.SelectedIndexChanged += new System.EventHandler(this.cmbMoveToType_SelectedIndexChanged);
            // 
            // lblMoveToTooltip
            // 
            this.lblMoveToTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoveToTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblMoveToTooltip.Name = "lblMoveToTooltip";
            this.lblMoveToTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblMoveToTooltip.TabIndex = 0;
            this.lblMoveToTooltip.Text = "The source unit moves to a specified location. Change the coordinates type if you" +
    " want it to move to the position of another WorldObject instead of an absolute m" +
    "ap coordinate.";
            // 
            // frmCommandTeleport
            // 
            this.frmCommandTeleport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTeleport.Controls.Add(this.grpTeleportOptions);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportO);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportZ);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportY);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportX);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportMapId);
            this.frmCommandTeleport.Controls.Add(this.txtTeleportO);
            this.frmCommandTeleport.Controls.Add(this.cmbTeleportMap);
            this.frmCommandTeleport.Controls.Add(this.txtTeleportZ);
            this.frmCommandTeleport.Controls.Add(this.txtTeleportY);
            this.frmCommandTeleport.Controls.Add(this.txtTeleportX);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportTooltip);
            this.frmCommandTeleport.Location = new System.Drawing.Point(410, 250);
            this.frmCommandTeleport.Name = "frmCommandTeleport";
            this.frmCommandTeleport.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTeleport.TabIndex = 14;
            this.frmCommandTeleport.Visible = false;
            // 
            // grpTeleportOptions
            // 
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions32);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions16);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions8);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions4);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions2);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions1);
            this.grpTeleportOptions.Location = new System.Drawing.Point(273, 61);
            this.grpTeleportOptions.Name = "grpTeleportOptions";
            this.grpTeleportOptions.Size = new System.Drawing.Size(200, 171);
            this.grpTeleportOptions.TabIndex = 12;
            this.grpTeleportOptions.TabStop = false;
            this.grpTeleportOptions.Text = "Teleport Options";
            // 
            // chkTeleportOptions32
            // 
            this.chkTeleportOptions32.AutoSize = true;
            this.chkTeleportOptions32.Location = new System.Drawing.Point(10, 140);
            this.chkTeleportOptions32.Name = "chkTeleportOptions32";
            this.chkTeleportOptions32.Size = new System.Drawing.Size(142, 17);
            this.chkTeleportOptions32.TabIndex = 5;
            this.chkTeleportOptions32.Text = "FORCE_MAP_CHANGE";
            this.chkTeleportOptions32.UseVisualStyleBackColor = true;
            this.chkTeleportOptions32.CheckedChanged += new System.EventHandler(this.chkTeleportOptions32_CheckedChanged);
            // 
            // chkTeleportOptions16
            // 
            this.chkTeleportOptions16.AutoSize = true;
            this.chkTeleportOptions16.Location = new System.Drawing.Point(10, 117);
            this.chkTeleportOptions16.Name = "chkTeleportOptions16";
            this.chkTeleportOptions16.Size = new System.Drawing.Size(87, 17);
            this.chkTeleportOptions16.TabIndex = 4;
            this.chkTeleportOptions16.Text = "FOR_SPELL";
            this.chkTeleportOptions16.UseVisualStyleBackColor = true;
            this.chkTeleportOptions16.CheckedChanged += new System.EventHandler(this.chkTeleportOptions16_CheckedChanged);
            // 
            // chkTeleportOptions8
            // 
            this.chkTeleportOptions8.AutoSize = true;
            this.chkTeleportOptions8.Location = new System.Drawing.Point(10, 94);
            this.chkTeleportOptions8.Name = "chkTeleportOptions8";
            this.chkTeleportOptions8.Size = new System.Drawing.Size(147, 17);
            this.chkTeleportOptions8.TabIndex = 3;
            this.chkTeleportOptions8.Text = "NOT_UNSUMMON_PET";
            this.chkTeleportOptions8.UseVisualStyleBackColor = true;
            this.chkTeleportOptions8.CheckedChanged += new System.EventHandler(this.chkTeleportOptions8_CheckedChanged);
            // 
            // chkTeleportOptions4
            // 
            this.chkTeleportOptions4.AutoSize = true;
            this.chkTeleportOptions4.Location = new System.Drawing.Point(10, 71);
            this.chkTeleportOptions4.Name = "chkTeleportOptions4";
            this.chkTeleportOptions4.Size = new System.Drawing.Size(140, 17);
            this.chkTeleportOptions4.TabIndex = 2;
            this.chkTeleportOptions4.Text = "NOT_LEAVE_COMBAT";
            this.chkTeleportOptions4.UseVisualStyleBackColor = true;
            this.chkTeleportOptions4.CheckedChanged += new System.EventHandler(this.chkTeleportOptions4_CheckedChanged);
            // 
            // chkTeleportOptions2
            // 
            this.chkTeleportOptions2.AutoSize = true;
            this.chkTeleportOptions2.Location = new System.Drawing.Point(10, 48);
            this.chkTeleportOptions2.Name = "chkTeleportOptions2";
            this.chkTeleportOptions2.Size = new System.Drawing.Size(162, 17);
            this.chkTeleportOptions2.TabIndex = 1;
            this.chkTeleportOptions2.Text = "NOT_LEAVE_TRANSPORT";
            this.chkTeleportOptions2.UseVisualStyleBackColor = true;
            this.chkTeleportOptions2.CheckedChanged += new System.EventHandler(this.chkTeleportOptions2_CheckedChanged);
            // 
            // chkTeleportOptions1
            // 
            this.chkTeleportOptions1.AutoSize = true;
            this.chkTeleportOptions1.Location = new System.Drawing.Point(10, 25);
            this.chkTeleportOptions1.Name = "chkTeleportOptions1";
            this.chkTeleportOptions1.Size = new System.Drawing.Size(81, 17);
            this.chkTeleportOptions1.TabIndex = 0;
            this.chkTeleportOptions1.Text = "GM_MODE";
            this.chkTeleportOptions1.UseVisualStyleBackColor = true;
            this.chkTeleportOptions1.CheckedChanged += new System.EventHandler(this.chkTeleportOptions1_CheckedChanged);
            // 
            // lblTeleportO
            // 
            this.lblTeleportO.AutoSize = true;
            this.lblTeleportO.Location = new System.Drawing.Point(37, 211);
            this.lblTeleportO.Name = "lblTeleportO";
            this.lblTeleportO.Size = new System.Drawing.Size(61, 13);
            this.lblTeleportO.TabIndex = 11;
            this.lblTeleportO.Text = "Orientation:";
            // 
            // lblTeleportZ
            // 
            this.lblTeleportZ.AutoSize = true;
            this.lblTeleportZ.Location = new System.Drawing.Point(28, 175);
            this.lblTeleportZ.Name = "lblTeleportZ";
            this.lblTeleportZ.Size = new System.Drawing.Size(70, 13);
            this.lblTeleportZ.TabIndex = 10;
            this.lblTeleportZ.Text = "Z coordinate:";
            // 
            // lblTeleportY
            // 
            this.lblTeleportY.AutoSize = true;
            this.lblTeleportY.Location = new System.Drawing.Point(28, 139);
            this.lblTeleportY.Name = "lblTeleportY";
            this.lblTeleportY.Size = new System.Drawing.Size(70, 13);
            this.lblTeleportY.TabIndex = 9;
            this.lblTeleportY.Text = "Y coordinate:";
            // 
            // lblTeleportX
            // 
            this.lblTeleportX.AutoSize = true;
            this.lblTeleportX.Location = new System.Drawing.Point(28, 104);
            this.lblTeleportX.Name = "lblTeleportX";
            this.lblTeleportX.Size = new System.Drawing.Size(70, 13);
            this.lblTeleportX.TabIndex = 8;
            this.lblTeleportX.Text = "X coordinate:";
            // 
            // lblTeleportMapId
            // 
            this.lblTeleportMapId.AutoSize = true;
            this.lblTeleportMapId.Location = new System.Drawing.Point(55, 71);
            this.lblTeleportMapId.Name = "lblTeleportMapId";
            this.lblTeleportMapId.Size = new System.Drawing.Size(43, 13);
            this.lblTeleportMapId.TabIndex = 7;
            this.lblTeleportMapId.Text = "Map Id:";
            // 
            // txtTeleportO
            // 
            this.txtTeleportO.Location = new System.Drawing.Point(101, 208);
            this.txtTeleportO.Name = "txtTeleportO";
            this.txtTeleportO.Size = new System.Drawing.Size(142, 20);
            this.txtTeleportO.TabIndex = 6;
            this.txtTeleportO.Leave += new System.EventHandler(this.txtTeleportO_Leave);
            // 
            // cmbTeleportMap
            // 
            this.cmbTeleportMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeleportMap.FormattingEnabled = true;
            this.cmbTeleportMap.Location = new System.Drawing.Point(101, 64);
            this.cmbTeleportMap.Name = "cmbTeleportMap";
            this.cmbTeleportMap.Size = new System.Drawing.Size(142, 21);
            this.cmbTeleportMap.TabIndex = 5;
            this.cmbTeleportMap.SelectedIndexChanged += new System.EventHandler(this.cmbTeleportMap_SelectedIndexChanged);
            // 
            // txtTeleportZ
            // 
            this.txtTeleportZ.Location = new System.Drawing.Point(101, 172);
            this.txtTeleportZ.Name = "txtTeleportZ";
            this.txtTeleportZ.Size = new System.Drawing.Size(142, 20);
            this.txtTeleportZ.TabIndex = 4;
            this.txtTeleportZ.Leave += new System.EventHandler(this.txtTeleportZ_Leave);
            // 
            // txtTeleportY
            // 
            this.txtTeleportY.Location = new System.Drawing.Point(101, 136);
            this.txtTeleportY.Name = "txtTeleportY";
            this.txtTeleportY.Size = new System.Drawing.Size(142, 20);
            this.txtTeleportY.TabIndex = 3;
            this.txtTeleportY.Leave += new System.EventHandler(this.txtTeleportY_Leave);
            // 
            // txtTeleportX
            // 
            this.txtTeleportX.Location = new System.Drawing.Point(101, 100);
            this.txtTeleportX.Name = "txtTeleportX";
            this.txtTeleportX.Size = new System.Drawing.Size(142, 20);
            this.txtTeleportX.TabIndex = 2;
            this.txtTeleportX.Leave += new System.EventHandler(this.txtTeleportX_Leave);
            // 
            // lblTeleportTooltip
            // 
            this.lblTeleportTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTeleportTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblTeleportTooltip.Name = "lblTeleportTooltip";
            this.lblTeleportTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblTeleportTooltip.TabIndex = 0;
            this.lblTeleportTooltip.Text = "Teleports the source unit to the specified coordinates. Creatures can only be tel" +
    "eported on the same map.";
            // 
            // frmCommandQuestComplete
            // 
            this.frmCommandQuestComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteId);
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteDistance);
            this.frmCommandQuestComplete.Controls.Add(this.txtQuestCompleteDistance);
            this.frmCommandQuestComplete.Controls.Add(this.btnQuestCompleteId);
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteTooltip);
            this.frmCommandQuestComplete.Location = new System.Drawing.Point(410, 250);
            this.frmCommandQuestComplete.Name = "frmCommandQuestComplete";
            this.frmCommandQuestComplete.Size = new System.Drawing.Size(495, 332);
            this.frmCommandQuestComplete.TabIndex = 15;
            this.frmCommandQuestComplete.Visible = false;
            // 
            // lblQuestCompleteId
            // 
            this.lblQuestCompleteId.AutoSize = true;
            this.lblQuestCompleteId.Location = new System.Drawing.Point(46, 61);
            this.lblQuestCompleteId.Name = "lblQuestCompleteId";
            this.lblQuestCompleteId.Size = new System.Drawing.Size(50, 13);
            this.lblQuestCompleteId.TabIndex = 4;
            this.lblQuestCompleteId.Text = "Quest Id:";
            // 
            // lblQuestCompleteDistance
            // 
            this.lblQuestCompleteDistance.AutoSize = true;
            this.lblQuestCompleteDistance.Location = new System.Drawing.Point(44, 93);
            this.lblQuestCompleteDistance.Name = "lblQuestCompleteDistance";
            this.lblQuestCompleteDistance.Size = new System.Drawing.Size(52, 13);
            this.lblQuestCompleteDistance.TabIndex = 3;
            this.lblQuestCompleteDistance.Text = "Distance:";
            // 
            // txtQuestCompleteDistance
            // 
            this.txtQuestCompleteDistance.Location = new System.Drawing.Point(99, 90);
            this.txtQuestCompleteDistance.Name = "txtQuestCompleteDistance";
            this.txtQuestCompleteDistance.Size = new System.Drawing.Size(374, 20);
            this.txtQuestCompleteDistance.TabIndex = 2;
            this.txtQuestCompleteDistance.Leave += new System.EventHandler(this.txtQuestCompleteDistance_Leave);
            // 
            // btnQuestCompleteId
            // 
            this.btnQuestCompleteId.Location = new System.Drawing.Point(99, 58);
            this.btnQuestCompleteId.Name = "btnQuestCompleteId";
            this.btnQuestCompleteId.Size = new System.Drawing.Size(374, 23);
            this.btnQuestCompleteId.TabIndex = 1;
            this.btnQuestCompleteId.Text = "-NONE-";
            this.btnQuestCompleteId.UseVisualStyleBackColor = true;
            this.btnQuestCompleteId.Click += new System.EventHandler(this.btnQuestCompleteId_Click);
            // 
            // lblQuestCompleteTooltip
            // 
            this.lblQuestCompleteTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestCompleteTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblQuestCompleteTooltip.Name = "lblQuestCompleteTooltip";
            this.lblQuestCompleteTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblQuestCompleteTooltip.TabIndex = 0;
            this.lblQuestCompleteTooltip.Text = "Completes the specified quest for the player. If a maximum distance is provided, " +
    "but the player is out of range, the quest will be marked as failed instead.";
            // 
            // frmCommandKillCredit
            // 
            this.frmCommandKillCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandKillCredit.Controls.Add(this.cmbKillCreditType);
            this.frmCommandKillCredit.Controls.Add(this.lblKillCreditCreatureId);
            this.frmCommandKillCredit.Controls.Add(this.lblKillCreditType);
            this.frmCommandKillCredit.Controls.Add(this.btnKillCreditCreatureId);
            this.frmCommandKillCredit.Controls.Add(this.lblKillCreditTooltip);
            this.frmCommandKillCredit.Location = new System.Drawing.Point(410, 250);
            this.frmCommandKillCredit.Name = "frmCommandKillCredit";
            this.frmCommandKillCredit.Size = new System.Drawing.Size(495, 332);
            this.frmCommandKillCredit.TabIndex = 16;
            this.frmCommandKillCredit.Visible = false;
            // 
            // cmbKillCreditType
            // 
            this.cmbKillCreditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKillCreditType.FormattingEnabled = true;
            this.cmbKillCreditType.Location = new System.Drawing.Point(99, 90);
            this.cmbKillCreditType.Name = "cmbKillCreditType";
            this.cmbKillCreditType.Size = new System.Drawing.Size(374, 21);
            this.cmbKillCreditType.TabIndex = 5;
            this.cmbKillCreditType.SelectedIndexChanged += new System.EventHandler(this.cmbKillCreditType_SelectedIndexChanged);
            // 
            // lblKillCreditCreatureId
            // 
            this.lblKillCreditCreatureId.AutoSize = true;
            this.lblKillCreditCreatureId.Location = new System.Drawing.Point(34, 61);
            this.lblKillCreditCreatureId.Name = "lblKillCreditCreatureId";
            this.lblKillCreditCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblKillCreditCreatureId.TabIndex = 4;
            this.lblKillCreditCreatureId.Text = "Creature Id:";
            // 
            // lblKillCreditType
            // 
            this.lblKillCreditType.AutoSize = true;
            this.lblKillCreditType.Location = new System.Drawing.Point(62, 93);
            this.lblKillCreditType.Name = "lblKillCreditType";
            this.lblKillCreditType.Size = new System.Drawing.Size(34, 13);
            this.lblKillCreditType.TabIndex = 3;
            this.lblKillCreditType.Text = "Type:";
            // 
            // btnKillCreditCreatureId
            // 
            this.btnKillCreditCreatureId.Location = new System.Drawing.Point(99, 58);
            this.btnKillCreditCreatureId.Name = "btnKillCreditCreatureId";
            this.btnKillCreditCreatureId.Size = new System.Drawing.Size(374, 23);
            this.btnKillCreditCreatureId.TabIndex = 1;
            this.btnKillCreditCreatureId.Text = "-NONE-";
            this.btnKillCreditCreatureId.UseVisualStyleBackColor = true;
            this.btnKillCreditCreatureId.Click += new System.EventHandler(this.btnKillCreditCreatureId_Click);
            // 
            // lblKillCreditTooltip
            // 
            this.lblKillCreditTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKillCreditTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblKillCreditTooltip.Name = "lblKillCreditTooltip";
            this.lblKillCreditTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblKillCreditTooltip.TabIndex = 0;
            this.lblKillCreditTooltip.Text = "Gives the player or his group credit for killing the specified creature.";
            // 
            // frmCommandRespawnGameobject
            // 
            this.frmCommandRespawnGameobject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectDelay);
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectGuid);
            this.frmCommandRespawnGameobject.Controls.Add(this.txtRespawnGameobjectDelay);
            this.frmCommandRespawnGameobject.Controls.Add(this.txtRespawnGameobjectGuid);
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectTooltip);
            this.frmCommandRespawnGameobject.Location = new System.Drawing.Point(410, 250);
            this.frmCommandRespawnGameobject.Name = "frmCommandRespawnGameobject";
            this.frmCommandRespawnGameobject.Size = new System.Drawing.Size(495, 332);
            this.frmCommandRespawnGameobject.TabIndex = 17;
            this.frmCommandRespawnGameobject.Visible = false;
            // 
            // lblRespawnGameobjectDelay
            // 
            this.lblRespawnGameobjectDelay.AutoSize = true;
            this.lblRespawnGameobjectDelay.Location = new System.Drawing.Point(59, 93);
            this.lblRespawnGameobjectDelay.Name = "lblRespawnGameobjectDelay";
            this.lblRespawnGameobjectDelay.Size = new System.Drawing.Size(37, 13);
            this.lblRespawnGameobjectDelay.TabIndex = 4;
            this.lblRespawnGameobjectDelay.Text = "Delay:";
            // 
            // lblRespawnGameobjectGuid
            // 
            this.lblRespawnGameobjectGuid.AutoSize = true;
            this.lblRespawnGameobjectGuid.Location = new System.Drawing.Point(59, 61);
            this.lblRespawnGameobjectGuid.Name = "lblRespawnGameobjectGuid";
            this.lblRespawnGameobjectGuid.Size = new System.Drawing.Size(37, 13);
            this.lblRespawnGameobjectGuid.TabIndex = 3;
            this.lblRespawnGameobjectGuid.Text = "GUID:";
            // 
            // txtRespawnGameobjectDelay
            // 
            this.txtRespawnGameobjectDelay.Location = new System.Drawing.Point(99, 90);
            this.txtRespawnGameobjectDelay.Name = "txtRespawnGameobjectDelay";
            this.txtRespawnGameobjectDelay.Size = new System.Drawing.Size(374, 20);
            this.txtRespawnGameobjectDelay.TabIndex = 2;
            this.txtRespawnGameobjectDelay.Leave += new System.EventHandler(this.txtRespawnGameobjectDelay_Leave);
            // 
            // txtRespawnGameobjectGuid
            // 
            this.txtRespawnGameobjectGuid.Location = new System.Drawing.Point(99, 58);
            this.txtRespawnGameobjectGuid.Name = "txtRespawnGameobjectGuid";
            this.txtRespawnGameobjectGuid.Size = new System.Drawing.Size(374, 20);
            this.txtRespawnGameobjectGuid.TabIndex = 1;
            this.txtRespawnGameobjectGuid.Leave += new System.EventHandler(this.txtRespawnGameobjectGuid_Leave);
            // 
            // lblRespawnGameobjectTooltip
            // 
            this.lblRespawnGameobjectTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRespawnGameobjectTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblRespawnGameobjectTooltip.Name = "lblRespawnGameobjectTooltip";
            this.lblRespawnGameobjectTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblRespawnGameobjectTooltip.TabIndex = 0;
            this.lblRespawnGameobjectTooltip.Text = "Respawns the GameObject with the specified GUID, and then despawns it again when " +
    "the delay expires.";
            // 
            // frmCommandSummonCreature
            // 
            this.frmCommandSummonCreature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureDespawnType);
            this.frmCommandSummonCreature.Controls.Add(this.cmbSummonCreatureDespawnType);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureO);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureZ);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureY);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureX);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureO);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureZ);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureY);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureX);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureUniqueRange);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureUniqueLimit);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureUniqueRange);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureUniqueLimit);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureAttackTarget);
            this.frmCommandSummonCreature.Controls.Add(this.cmbSummonCreatureAttackTarget);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureFacingOptions);
            this.frmCommandSummonCreature.Controls.Add(this.cmbSummonCreatureFacingOptions);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureDelay);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureDelay);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureId);
            this.frmCommandSummonCreature.Controls.Add(this.grpSummonCreatureFlags);
            this.frmCommandSummonCreature.Controls.Add(this.btnSummonCreatureId);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureTooltip);
            this.frmCommandSummonCreature.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSummonCreature.Name = "frmCommandSummonCreature";
            this.frmCommandSummonCreature.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSummonCreature.TabIndex = 18;
            this.frmCommandSummonCreature.Visible = false;
            // 
            // lblSummonCreatureDespawnType
            // 
            this.lblSummonCreatureDespawnType.AutoSize = true;
            this.lblSummonCreatureDespawnType.Location = new System.Drawing.Point(47, 138);
            this.lblSummonCreatureDespawnType.Name = "lblSummonCreatureDespawnType";
            this.lblSummonCreatureDespawnType.Size = new System.Drawing.Size(78, 13);
            this.lblSummonCreatureDespawnType.TabIndex = 23;
            this.lblSummonCreatureDespawnType.Text = "Despawn type:";
            // 
            // cmbSummonCreatureDespawnType
            // 
            this.cmbSummonCreatureDespawnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummonCreatureDespawnType.FormattingEnabled = true;
            this.cmbSummonCreatureDespawnType.Location = new System.Drawing.Point(131, 134);
            this.cmbSummonCreatureDespawnType.Name = "cmbSummonCreatureDespawnType";
            this.cmbSummonCreatureDespawnType.Size = new System.Drawing.Size(143, 21);
            this.cmbSummonCreatureDespawnType.TabIndex = 22;
            this.cmbSummonCreatureDespawnType.SelectedIndexChanged += new System.EventHandler(this.cmbSummonCreatureDespawnType_SelectedIndexChanged);
            // 
            // lblSummonCreatureO
            // 
            this.lblSummonCreatureO.AutoSize = true;
            this.lblSummonCreatureO.Location = new System.Drawing.Point(64, 260);
            this.lblSummonCreatureO.Name = "lblSummonCreatureO";
            this.lblSummonCreatureO.Size = new System.Drawing.Size(61, 13);
            this.lblSummonCreatureO.TabIndex = 21;
            this.lblSummonCreatureO.Text = "Orientation:";
            // 
            // lblSummonCreatureZ
            // 
            this.lblSummonCreatureZ.AutoSize = true;
            this.lblSummonCreatureZ.Location = new System.Drawing.Point(55, 231);
            this.lblSummonCreatureZ.Name = "lblSummonCreatureZ";
            this.lblSummonCreatureZ.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureZ.TabIndex = 20;
            this.lblSummonCreatureZ.Text = "Z coordinate:";
            // 
            // lblSummonCreatureY
            // 
            this.lblSummonCreatureY.AutoSize = true;
            this.lblSummonCreatureY.Location = new System.Drawing.Point(55, 201);
            this.lblSummonCreatureY.Name = "lblSummonCreatureY";
            this.lblSummonCreatureY.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureY.TabIndex = 19;
            this.lblSummonCreatureY.Text = "Y coordinate:";
            // 
            // lblSummonCreatureX
            // 
            this.lblSummonCreatureX.AutoSize = true;
            this.lblSummonCreatureX.Location = new System.Drawing.Point(55, 169);
            this.lblSummonCreatureX.Name = "lblSummonCreatureX";
            this.lblSummonCreatureX.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureX.TabIndex = 18;
            this.lblSummonCreatureX.Text = "X coordinate:";
            // 
            // txtSummonCreatureO
            // 
            this.txtSummonCreatureO.Location = new System.Drawing.Point(131, 259);
            this.txtSummonCreatureO.Name = "txtSummonCreatureO";
            this.txtSummonCreatureO.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureO.TabIndex = 17;
            this.txtSummonCreatureO.Leave += new System.EventHandler(this.txtSummonCreatureO_Leave);
            // 
            // txtSummonCreatureZ
            // 
            this.txtSummonCreatureZ.Location = new System.Drawing.Point(132, 228);
            this.txtSummonCreatureZ.Name = "txtSummonCreatureZ";
            this.txtSummonCreatureZ.Size = new System.Drawing.Size(142, 20);
            this.txtSummonCreatureZ.TabIndex = 16;
            this.txtSummonCreatureZ.Leave += new System.EventHandler(this.txtSummonCreatureZ_Leave);
            // 
            // txtSummonCreatureY
            // 
            this.txtSummonCreatureY.Location = new System.Drawing.Point(131, 197);
            this.txtSummonCreatureY.Name = "txtSummonCreatureY";
            this.txtSummonCreatureY.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureY.TabIndex = 15;
            this.txtSummonCreatureY.Leave += new System.EventHandler(this.txtSummonCreatureY_Leave);
            // 
            // txtSummonCreatureX
            // 
            this.txtSummonCreatureX.Location = new System.Drawing.Point(131, 166);
            this.txtSummonCreatureX.Name = "txtSummonCreatureX";
            this.txtSummonCreatureX.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureX.TabIndex = 14;
            this.txtSummonCreatureX.Leave += new System.EventHandler(this.txtSummonCreatureX_Leave);
            // 
            // lblSummonCreatureUniqueRange
            // 
            this.lblSummonCreatureUniqueRange.AutoSize = true;
            this.lblSummonCreatureUniqueRange.Location = new System.Drawing.Point(389, 283);
            this.lblSummonCreatureUniqueRange.Name = "lblSummonCreatureUniqueRange";
            this.lblSummonCreatureUniqueRange.Size = new System.Drawing.Size(74, 13);
            this.lblSummonCreatureUniqueRange.TabIndex = 13;
            this.lblSummonCreatureUniqueRange.Text = "Unique range:";
            // 
            // lblSummonCreatureUniqueLimit
            // 
            this.lblSummonCreatureUniqueLimit.AutoSize = true;
            this.lblSummonCreatureUniqueLimit.Location = new System.Drawing.Point(293, 283);
            this.lblSummonCreatureUniqueLimit.Name = "lblSummonCreatureUniqueLimit";
            this.lblSummonCreatureUniqueLimit.Size = new System.Drawing.Size(64, 13);
            this.lblSummonCreatureUniqueLimit.TabIndex = 12;
            this.lblSummonCreatureUniqueLimit.Text = "Unique limit:";
            // 
            // txtSummonCreatureUniqueRange
            // 
            this.txtSummonCreatureUniqueRange.Location = new System.Drawing.Point(388, 302);
            this.txtSummonCreatureUniqueRange.Name = "txtSummonCreatureUniqueRange";
            this.txtSummonCreatureUniqueRange.Size = new System.Drawing.Size(85, 20);
            this.txtSummonCreatureUniqueRange.TabIndex = 11;
            this.txtSummonCreatureUniqueRange.Leave += new System.EventHandler(this.txtSummonCreatureUniqueRange_Leave);
            // 
            // txtSummonCreatureUniqueLimit
            // 
            this.txtSummonCreatureUniqueLimit.Location = new System.Drawing.Point(292, 302);
            this.txtSummonCreatureUniqueLimit.Name = "txtSummonCreatureUniqueLimit";
            this.txtSummonCreatureUniqueLimit.Size = new System.Drawing.Size(85, 20);
            this.txtSummonCreatureUniqueLimit.TabIndex = 10;
            this.txtSummonCreatureUniqueLimit.Leave += new System.EventHandler(this.txtSummonCreatureUniqueLimit_Leave);
            // 
            // lblSummonCreatureAttackTarget
            // 
            this.lblSummonCreatureAttackTarget.AutoSize = true;
            this.lblSummonCreatureAttackTarget.Location = new System.Drawing.Point(293, 236);
            this.lblSummonCreatureAttackTarget.Name = "lblSummonCreatureAttackTarget";
            this.lblSummonCreatureAttackTarget.Size = new System.Drawing.Size(71, 13);
            this.lblSummonCreatureAttackTarget.TabIndex = 9;
            this.lblSummonCreatureAttackTarget.Text = "Attack target:";
            // 
            // cmbSummonCreatureAttackTarget
            // 
            this.cmbSummonCreatureAttackTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummonCreatureAttackTarget.FormattingEnabled = true;
            this.cmbSummonCreatureAttackTarget.Location = new System.Drawing.Point(292, 255);
            this.cmbSummonCreatureAttackTarget.Name = "cmbSummonCreatureAttackTarget";
            this.cmbSummonCreatureAttackTarget.Size = new System.Drawing.Size(181, 21);
            this.cmbSummonCreatureAttackTarget.TabIndex = 8;
            this.cmbSummonCreatureAttackTarget.SelectedIndexChanged += new System.EventHandler(this.cmbSummonCreatureAttackTarget_SelectedIndexChanged);
            // 
            // lblSummonCreatureFacingOptions
            // 
            this.lblSummonCreatureFacingOptions.AutoSize = true;
            this.lblSummonCreatureFacingOptions.Location = new System.Drawing.Point(293, 191);
            this.lblSummonCreatureFacingOptions.Name = "lblSummonCreatureFacingOptions";
            this.lblSummonCreatureFacingOptions.Size = new System.Drawing.Size(79, 13);
            this.lblSummonCreatureFacingOptions.TabIndex = 7;
            this.lblSummonCreatureFacingOptions.Text = "Facing options:";
            // 
            // cmbSummonCreatureFacingOptions
            // 
            this.cmbSummonCreatureFacingOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummonCreatureFacingOptions.FormattingEnabled = true;
            this.cmbSummonCreatureFacingOptions.Items.AddRange(new object[] {
            "Provided Orientation",
            "Face Summoner",
            "Face Target"});
            this.cmbSummonCreatureFacingOptions.Location = new System.Drawing.Point(292, 210);
            this.cmbSummonCreatureFacingOptions.Name = "cmbSummonCreatureFacingOptions";
            this.cmbSummonCreatureFacingOptions.Size = new System.Drawing.Size(181, 21);
            this.cmbSummonCreatureFacingOptions.TabIndex = 6;
            this.cmbSummonCreatureFacingOptions.SelectedIndexChanged += new System.EventHandler(this.cmbSummonCreatureFacingOptions_SelectedIndexChanged);
            // 
            // lblSummonCreatureDelay
            // 
            this.lblSummonCreatureDelay.AutoSize = true;
            this.lblSummonCreatureDelay.Location = new System.Drawing.Point(20, 106);
            this.lblSummonCreatureDelay.Name = "lblSummonCreatureDelay";
            this.lblSummonCreatureDelay.Size = new System.Drawing.Size(105, 13);
            this.lblSummonCreatureDelay.TabIndex = 5;
            this.lblSummonCreatureDelay.Text = "Despawn delay (ms):";
            // 
            // txtSummonCreatureDelay
            // 
            this.txtSummonCreatureDelay.Location = new System.Drawing.Point(131, 103);
            this.txtSummonCreatureDelay.Name = "txtSummonCreatureDelay";
            this.txtSummonCreatureDelay.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureDelay.TabIndex = 4;
            this.txtSummonCreatureDelay.Leave += new System.EventHandler(this.txtSummonCreatureDelay_Leave);
            // 
            // lblSummonCreatureId
            // 
            this.lblSummonCreatureId.AutoSize = true;
            this.lblSummonCreatureId.Location = new System.Drawing.Point(20, 72);
            this.lblSummonCreatureId.Name = "lblSummonCreatureId";
            this.lblSummonCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblSummonCreatureId.TabIndex = 3;
            this.lblSummonCreatureId.Text = "Creature Id:";
            // 
            // grpSummonCreatureFlags
            // 
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags1);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags8);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags4);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags2);
            this.grpSummonCreatureFlags.Location = new System.Drawing.Point(292, 58);
            this.grpSummonCreatureFlags.Name = "grpSummonCreatureFlags";
            this.grpSummonCreatureFlags.Size = new System.Drawing.Size(181, 125);
            this.grpSummonCreatureFlags.TabIndex = 2;
            this.grpSummonCreatureFlags.TabStop = false;
            this.grpSummonCreatureFlags.Text = "Summon Flags";
            // 
            // chkSummonCreatureFlags1
            // 
            this.chkSummonCreatureFlags1.AutoSize = true;
            this.chkSummonCreatureFlags1.Location = new System.Drawing.Point(10, 24);
            this.chkSummonCreatureFlags1.Name = "chkSummonCreatureFlags1";
            this.chkSummonCreatureFlags1.Size = new System.Drawing.Size(103, 17);
            this.chkSummonCreatureFlags1.TabIndex = 3;
            this.chkSummonCreatureFlags1.Text = "Runs By Default";
            this.chkSummonCreatureFlags1.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags1.CheckedChanged += new System.EventHandler(this.chkSummonCreatureFlags1_CheckedChanged);
            // 
            // chkSummonCreatureFlags8
            // 
            this.chkSummonCreatureFlags8.AutoSize = true;
            this.chkSummonCreatureFlags8.Location = new System.Drawing.Point(10, 99);
            this.chkSummonCreatureFlags8.Name = "chkSummonCreatureFlags8";
            this.chkSummonCreatureFlags8.Size = new System.Drawing.Size(149, 17);
            this.chkSummonCreatureFlags8.TabIndex = 2;
            this.chkSummonCreatureFlags8.Text = "Unique Temporary Spawn";
            this.chkSummonCreatureFlags8.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags8.CheckStateChanged += new System.EventHandler(this.chkSummonCreatureFlags8_CheckStateChanged);
            // 
            // chkSummonCreatureFlags4
            // 
            this.chkSummonCreatureFlags4.AutoSize = true;
            this.chkSummonCreatureFlags4.Location = new System.Drawing.Point(10, 74);
            this.chkSummonCreatureFlags4.Name = "chkSummonCreatureFlags4";
            this.chkSummonCreatureFlags4.Size = new System.Drawing.Size(96, 17);
            this.chkSummonCreatureFlags4.TabIndex = 1;
            this.chkSummonCreatureFlags4.Text = "Unique Spawn";
            this.chkSummonCreatureFlags4.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags4.CheckedChanged += new System.EventHandler(this.chkSummonCreatureFlags4_CheckedChanged);
            // 
            // chkSummonCreatureFlags2
            // 
            this.chkSummonCreatureFlags2.AutoSize = true;
            this.chkSummonCreatureFlags2.Location = new System.Drawing.Point(10, 49);
            this.chkSummonCreatureFlags2.Name = "chkSummonCreatureFlags2";
            this.chkSummonCreatureFlags2.Size = new System.Drawing.Size(120, 17);
            this.chkSummonCreatureFlags2.TabIndex = 0;
            this.chkSummonCreatureFlags2.Text = "Make Active Object";
            this.chkSummonCreatureFlags2.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags2.CheckedChanged += new System.EventHandler(this.chkSummonCreatureFlags2_CheckedChanged);
            // 
            // btnSummonCreatureId
            // 
            this.btnSummonCreatureId.Location = new System.Drawing.Point(83, 67);
            this.btnSummonCreatureId.Name = "btnSummonCreatureId";
            this.btnSummonCreatureId.Size = new System.Drawing.Size(191, 23);
            this.btnSummonCreatureId.TabIndex = 1;
            this.btnSummonCreatureId.Text = "-NONE-";
            this.btnSummonCreatureId.UseVisualStyleBackColor = true;
            this.btnSummonCreatureId.Click += new System.EventHandler(this.btnSummonCreatureId_Click);
            // 
            // lblSummonCreatureTooltip
            // 
            this.lblSummonCreatureTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSummonCreatureTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSummonCreatureTooltip.Name = "lblSummonCreatureTooltip";
            this.lblSummonCreatureTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSummonCreatureTooltip.TabIndex = 0;
            this.lblSummonCreatureTooltip.Text = "Temporarily summons a creature at the given coordinates. It despawns after the sp" +
    "ecified delay.";
            // 
            // frmCommandDoor
            // 
            this.frmCommandDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandDoor.Controls.Add(this.lblDoorResetDelay);
            this.frmCommandDoor.Controls.Add(this.lblDoorGuid);
            this.frmCommandDoor.Controls.Add(this.txtDoorResetDelay);
            this.frmCommandDoor.Controls.Add(this.txtDoorGuid);
            this.frmCommandDoor.Controls.Add(this.lblDoorTooltip);
            this.frmCommandDoor.Location = new System.Drawing.Point(410, 250);
            this.frmCommandDoor.Name = "frmCommandDoor";
            this.frmCommandDoor.Size = new System.Drawing.Size(495, 332);
            this.frmCommandDoor.TabIndex = 19;
            this.frmCommandDoor.Visible = false;
            // 
            // lblDoorResetDelay
            // 
            this.lblDoorResetDelay.AutoSize = true;
            this.lblDoorResetDelay.Location = new System.Drawing.Point(59, 93);
            this.lblDoorResetDelay.Name = "lblDoorResetDelay";
            this.lblDoorResetDelay.Size = new System.Drawing.Size(37, 13);
            this.lblDoorResetDelay.TabIndex = 4;
            this.lblDoorResetDelay.Text = "Delay:";
            // 
            // lblDoorGuid
            // 
            this.lblDoorGuid.AutoSize = true;
            this.lblDoorGuid.Location = new System.Drawing.Point(59, 61);
            this.lblDoorGuid.Name = "lblDoorGuid";
            this.lblDoorGuid.Size = new System.Drawing.Size(37, 13);
            this.lblDoorGuid.TabIndex = 3;
            this.lblDoorGuid.Text = "GUID:";
            // 
            // txtDoorResetDelay
            // 
            this.txtDoorResetDelay.Location = new System.Drawing.Point(99, 90);
            this.txtDoorResetDelay.Name = "txtDoorResetDelay";
            this.txtDoorResetDelay.Size = new System.Drawing.Size(374, 20);
            this.txtDoorResetDelay.TabIndex = 2;
            this.txtDoorResetDelay.Leave += new System.EventHandler(this.txtDoorResetDelay_Leave);
            // 
            // txtDoorGuid
            // 
            this.txtDoorGuid.Location = new System.Drawing.Point(99, 58);
            this.txtDoorGuid.Name = "txtDoorGuid";
            this.txtDoorGuid.Size = new System.Drawing.Size(374, 20);
            this.txtDoorGuid.TabIndex = 1;
            this.txtDoorGuid.Leave += new System.EventHandler(this.txtDoorGuid_Leave);
            // 
            // lblDoorTooltip
            // 
            this.lblDoorTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDoorTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblDoorTooltip.Name = "lblDoorTooltip";
            this.lblDoorTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblDoorTooltip.TabIndex = 0;
            this.lblDoorTooltip.Text = "Opens the specified door GameObject, then resets it back to its original state af" +
    "ter the delay expires. If the provided target is a button, it gets toggled as we" +
    "ll.";
            // 
            // frmCommandRemoveAura
            // 
            this.frmCommandRemoveAura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandRemoveAura.Controls.Add(this.btnRemoveAuraSpellId);
            this.frmCommandRemoveAura.Controls.Add(this.lblRemoveAuraSpellId);
            this.frmCommandRemoveAura.Controls.Add(this.lblRemoveAuraTooltip);
            this.frmCommandRemoveAura.Location = new System.Drawing.Point(410, 250);
            this.frmCommandRemoveAura.Name = "frmCommandRemoveAura";
            this.frmCommandRemoveAura.Size = new System.Drawing.Size(495, 332);
            this.frmCommandRemoveAura.TabIndex = 20;
            this.frmCommandRemoveAura.Visible = false;
            // 
            // btnRemoveAuraSpellId
            // 
            this.btnRemoveAuraSpellId.Location = new System.Drawing.Point(69, 57);
            this.btnRemoveAuraSpellId.Name = "btnRemoveAuraSpellId";
            this.btnRemoveAuraSpellId.Size = new System.Drawing.Size(404, 23);
            this.btnRemoveAuraSpellId.TabIndex = 2;
            this.btnRemoveAuraSpellId.Text = "-NONE-";
            this.btnRemoveAuraSpellId.UseVisualStyleBackColor = true;
            this.btnRemoveAuraSpellId.Click += new System.EventHandler(this.btnRemoveAuraSpellId_Click);
            // 
            // lblRemoveAuraSpellId
            // 
            this.lblRemoveAuraSpellId.AutoSize = true;
            this.lblRemoveAuraSpellId.Location = new System.Drawing.Point(23, 61);
            this.lblRemoveAuraSpellId.Name = "lblRemoveAuraSpellId";
            this.lblRemoveAuraSpellId.Size = new System.Drawing.Size(45, 13);
            this.lblRemoveAuraSpellId.TabIndex = 1;
            this.lblRemoveAuraSpellId.Text = "Spell Id:";
            // 
            // lblRemoveAuraTooltip
            // 
            this.lblRemoveAuraTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRemoveAuraTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblRemoveAuraTooltip.Name = "lblRemoveAuraTooltip";
            this.lblRemoveAuraTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblRemoveAuraTooltip.TabIndex = 0;
            this.lblRemoveAuraTooltip.Text = "Removes any auras from the source Unit caused by the specified spell.";
            // 
            // frmCommandCastSpell
            // 
            this.frmCommandCastSpell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandCastSpell.Controls.Add(this.grpCastSpellFlags);
            this.frmCommandCastSpell.Controls.Add(this.btnCastSpellId);
            this.frmCommandCastSpell.Controls.Add(this.lblCastSpellId);
            this.frmCommandCastSpell.Controls.Add(this.lblCastSpellTooltip);
            this.frmCommandCastSpell.Location = new System.Drawing.Point(410, 250);
            this.frmCommandCastSpell.Name = "frmCommandCastSpell";
            this.frmCommandCastSpell.Size = new System.Drawing.Size(495, 332);
            this.frmCommandCastSpell.TabIndex = 21;
            this.frmCommandCastSpell.Visible = false;
            // 
            // grpCastSpellFlags
            // 
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags128);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags64);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags32);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags16);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags4);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags1);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags2);
            this.grpCastSpellFlags.Location = new System.Drawing.Point(26, 88);
            this.grpCastSpellFlags.Name = "grpCastSpellFlags";
            this.grpCastSpellFlags.Size = new System.Drawing.Size(447, 77);
            this.grpCastSpellFlags.TabIndex = 3;
            this.grpCastSpellFlags.TabStop = false;
            this.grpCastSpellFlags.Text = "Cast Flags";
            // 
            // chkCastSpellFlags128
            // 
            this.chkCastSpellFlags128.AutoSize = true;
            this.chkCastSpellFlags128.Location = new System.Drawing.Point(243, 48);
            this.chkCastSpellFlags128.Name = "chkCastSpellFlags128";
            this.chkCastSpellFlags128.Size = new System.Drawing.Size(87, 17);
            this.chkCastSpellFlags128.TabIndex = 6;
            this.chkCastSpellFlags128.Text = "Not In Melee";
            this.chkCastSpellFlags128.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags128.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags128_CheckedChanged);
            // 
            // chkCastSpellFlags64
            // 
            this.chkCastSpellFlags64.AutoSize = true;
            this.chkCastSpellFlags64.Location = new System.Drawing.Point(146, 48);
            this.chkCastSpellFlags64.Name = "chkCastSpellFlags64";
            this.chkCastSpellFlags64.Size = new System.Drawing.Size(91, 17);
            this.chkCastSpellFlags64.TabIndex = 5;
            this.chkCastSpellFlags64.Text = "Only In Melee";
            this.chkCastSpellFlags64.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags64.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags64_CheckedChanged);
            // 
            // chkCastSpellFlags32
            // 
            this.chkCastSpellFlags32.AutoSize = true;
            this.chkCastSpellFlags32.Location = new System.Drawing.Point(10, 48);
            this.chkCastSpellFlags32.Name = "chkCastSpellFlags32";
            this.chkCastSpellFlags32.Size = new System.Drawing.Size(130, 17);
            this.chkCastSpellFlags32.TabIndex = 4;
            this.chkCastSpellFlags32.Text = "Only If Not Have Aura";
            this.chkCastSpellFlags32.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags32.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags32_CheckedChanged);
            // 
            // chkCastSpellFlags16
            // 
            this.chkCastSpellFlags16.AutoSize = true;
            this.chkCastSpellFlags16.Location = new System.Drawing.Point(259, 21);
            this.chkCastSpellFlags16.Name = "chkCastSpellFlags16";
            this.chkCastSpellFlags16.Size = new System.Drawing.Size(121, 17);
            this.chkCastSpellFlags16.TabIndex = 3;
            this.chkCastSpellFlags16.Text = "Target Unreachable";
            this.chkCastSpellFlags16.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags16.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags16_CheckedChanged);
            // 
            // chkCastSpellFlags4
            // 
            this.chkCastSpellFlags4.AutoSize = true;
            this.chkCastSpellFlags4.Location = new System.Drawing.Point(200, 21);
            this.chkCastSpellFlags4.Name = "chkCastSpellFlags4";
            this.chkCastSpellFlags4.Size = new System.Drawing.Size(53, 17);
            this.chkCastSpellFlags4.TabIndex = 2;
            this.chkCastSpellFlags4.Text = "Force";
            this.chkCastSpellFlags4.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags4.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags4_CheckedChanged);
            // 
            // chkCastSpellFlags1
            // 
            this.chkCastSpellFlags1.AutoSize = true;
            this.chkCastSpellFlags1.Location = new System.Drawing.Point(85, 21);
            this.chkCastSpellFlags1.Name = "chkCastSpellFlags1";
            this.chkCastSpellFlags1.Size = new System.Drawing.Size(109, 17);
            this.chkCastSpellFlags1.TabIndex = 1;
            this.chkCastSpellFlags1.Text = "Interrupt Previous";
            this.chkCastSpellFlags1.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags1.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags1_CheckedChanged);
            // 
            // chkCastSpellFlags2
            // 
            this.chkCastSpellFlags2.AutoSize = true;
            this.chkCastSpellFlags2.Location = new System.Drawing.Point(10, 21);
            this.chkCastSpellFlags2.Name = "chkCastSpellFlags2";
            this.chkCastSpellFlags2.Size = new System.Drawing.Size(71, 17);
            this.chkCastSpellFlags2.TabIndex = 0;
            this.chkCastSpellFlags2.Text = "Triggered";
            this.chkCastSpellFlags2.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags2.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags2_CheckedChanged);
            // 
            // btnCastSpellId
            // 
            this.btnCastSpellId.Location = new System.Drawing.Point(69, 57);
            this.btnCastSpellId.Name = "btnCastSpellId";
            this.btnCastSpellId.Size = new System.Drawing.Size(404, 23);
            this.btnCastSpellId.TabIndex = 2;
            this.btnCastSpellId.Text = "-NONE-";
            this.btnCastSpellId.UseVisualStyleBackColor = true;
            this.btnCastSpellId.Click += new System.EventHandler(this.btnCastSpellId_Click);
            // 
            // lblCastSpellId
            // 
            this.lblCastSpellId.AutoSize = true;
            this.lblCastSpellId.Location = new System.Drawing.Point(23, 61);
            this.lblCastSpellId.Name = "lblCastSpellId";
            this.lblCastSpellId.Size = new System.Drawing.Size(45, 13);
            this.lblCastSpellId.TabIndex = 1;
            this.lblCastSpellId.Text = "Spell Id:";
            // 
            // lblCastSpellTooltip
            // 
            this.lblCastSpellTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCastSpellTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblCastSpellTooltip.Name = "lblCastSpellTooltip";
            this.lblCastSpellTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblCastSpellTooltip.TabIndex = 0;
            this.lblCastSpellTooltip.Text = "The source Unit casts the specified spell on the Unit target.";
            // 
            // frmCommandPlaySound
            // 
            this.frmCommandPlaySound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandPlaySound.Controls.Add(this.btnPlaySoundId);
            this.frmCommandPlaySound.Controls.Add(this.grpPlaySoundFlags);
            this.frmCommandPlaySound.Controls.Add(this.lblPlaySoundId);
            this.frmCommandPlaySound.Controls.Add(this.lblPlaySoundTooltip);
            this.frmCommandPlaySound.Location = new System.Drawing.Point(410, 250);
            this.frmCommandPlaySound.Name = "frmCommandPlaySound";
            this.frmCommandPlaySound.Size = new System.Drawing.Size(495, 332);
            this.frmCommandPlaySound.TabIndex = 22;
            this.frmCommandPlaySound.Visible = false;
            // 
            // btnPlaySoundId
            // 
            this.btnPlaySoundId.Location = new System.Drawing.Point(83, 58);
            this.btnPlaySoundId.Name = "btnPlaySoundId";
            this.btnPlaySoundId.Size = new System.Drawing.Size(390, 23);
            this.btnPlaySoundId.TabIndex = 4;
            this.btnPlaySoundId.Text = "-NONE-";
            this.btnPlaySoundId.UseVisualStyleBackColor = true;
            this.btnPlaySoundId.Click += new System.EventHandler(this.btnPlaySoundId_Click);
            // 
            // grpPlaySoundFlags
            // 
            this.grpPlaySoundFlags.Controls.Add(this.chkPlaySoundFlags2);
            this.grpPlaySoundFlags.Controls.Add(this.chkPlaySoundFlags1);
            this.grpPlaySoundFlags.Location = new System.Drawing.Point(26, 88);
            this.grpPlaySoundFlags.Name = "grpPlaySoundFlags";
            this.grpPlaySoundFlags.Size = new System.Drawing.Size(447, 48);
            this.grpPlaySoundFlags.TabIndex = 3;
            this.grpPlaySoundFlags.TabStop = false;
            this.grpPlaySoundFlags.Text = "Flags";
            // 
            // chkPlaySoundFlags2
            // 
            this.chkPlaySoundFlags2.AutoSize = true;
            this.chkPlaySoundFlags2.Location = new System.Drawing.Point(114, 21);
            this.chkPlaySoundFlags2.Name = "chkPlaySoundFlags2";
            this.chkPlaySoundFlags2.Size = new System.Drawing.Size(124, 17);
            this.chkPlaySoundFlags2.TabIndex = 1;
            this.chkPlaySoundFlags2.Text = "Distance Dependent";
            this.chkPlaySoundFlags2.UseVisualStyleBackColor = true;
            this.chkPlaySoundFlags2.CheckedChanged += new System.EventHandler(this.chkPlaySoundFlags2_CheckedChanged);
            // 
            // chkPlaySoundFlags1
            // 
            this.chkPlaySoundFlags1.AutoSize = true;
            this.chkPlaySoundFlags1.Location = new System.Drawing.Point(10, 21);
            this.chkPlaySoundFlags1.Name = "chkPlaySoundFlags1";
            this.chkPlaySoundFlags1.Size = new System.Drawing.Size(97, 17);
            this.chkPlaySoundFlags1.TabIndex = 0;
            this.chkPlaySoundFlags1.Text = "Only To Target";
            this.chkPlaySoundFlags1.UseVisualStyleBackColor = true;
            this.chkPlaySoundFlags1.CheckedChanged += new System.EventHandler(this.chkPlaySoundFlags1_CheckedChanged);
            // 
            // lblPlaySoundId
            // 
            this.lblPlaySoundId.AutoSize = true;
            this.lblPlaySoundId.Location = new System.Drawing.Point(25, 61);
            this.lblPlaySoundId.Name = "lblPlaySoundId";
            this.lblPlaySoundId.Size = new System.Drawing.Size(53, 13);
            this.lblPlaySoundId.TabIndex = 1;
            this.lblPlaySoundId.Text = "Sound Id:";
            // 
            // lblPlaySoundTooltip
            // 
            this.lblPlaySoundTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlaySoundTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblPlaySoundTooltip.Name = "lblPlaySoundTooltip";
            this.lblPlaySoundTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblPlaySoundTooltip.TabIndex = 0;
            this.lblPlaySoundTooltip.Text = "Plays the specified sound entry.";
            // 
            // frmCommandCreateItem
            // 
            this.frmCommandCreateItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandCreateItem.Controls.Add(this.lblCreateItemAmount);
            this.frmCommandCreateItem.Controls.Add(this.txtCreateItemAmount);
            this.frmCommandCreateItem.Controls.Add(this.btnCreateItemId);
            this.frmCommandCreateItem.Controls.Add(this.lblCreateItemId);
            this.frmCommandCreateItem.Controls.Add(this.lblCreateItemTooltip);
            this.frmCommandCreateItem.Location = new System.Drawing.Point(410, 250);
            this.frmCommandCreateItem.Name = "frmCommandCreateItem";
            this.frmCommandCreateItem.Size = new System.Drawing.Size(495, 332);
            this.frmCommandCreateItem.TabIndex = 23;
            this.frmCommandCreateItem.Visible = false;
            // 
            // lblCreateItemAmount
            // 
            this.lblCreateItemAmount.AutoSize = true;
            this.lblCreateItemAmount.Location = new System.Drawing.Point(50, 93);
            this.lblCreateItemAmount.Name = "lblCreateItemAmount";
            this.lblCreateItemAmount.Size = new System.Drawing.Size(46, 13);
            this.lblCreateItemAmount.TabIndex = 4;
            this.lblCreateItemAmount.Text = "Amount:";
            // 
            // txtCreateItemAmount
            // 
            this.txtCreateItemAmount.Location = new System.Drawing.Point(99, 90);
            this.txtCreateItemAmount.Name = "txtCreateItemAmount";
            this.txtCreateItemAmount.Size = new System.Drawing.Size(374, 20);
            this.txtCreateItemAmount.TabIndex = 3;
            this.txtCreateItemAmount.Leave += new System.EventHandler(this.txtCreateItemAmount_Leave);
            // 
            // btnCreateItemId
            // 
            this.btnCreateItemId.Location = new System.Drawing.Point(99, 58);
            this.btnCreateItemId.Name = "btnCreateItemId";
            this.btnCreateItemId.Size = new System.Drawing.Size(374, 23);
            this.btnCreateItemId.TabIndex = 2;
            this.btnCreateItemId.Text = "-NONE-";
            this.btnCreateItemId.UseVisualStyleBackColor = true;
            this.btnCreateItemId.Click += new System.EventHandler(this.btnCreateItemId_Click);
            // 
            // lblCreateItemId
            // 
            this.lblCreateItemId.AutoSize = true;
            this.lblCreateItemId.Location = new System.Drawing.Point(54, 61);
            this.lblCreateItemId.Name = "lblCreateItemId";
            this.lblCreateItemId.Size = new System.Drawing.Size(42, 13);
            this.lblCreateItemId.TabIndex = 1;
            this.lblCreateItemId.Text = "Item Id:";
            // 
            // lblCreateItemTooltip
            // 
            this.lblCreateItemTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreateItemTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblCreateItemTooltip.Name = "lblCreateItemTooltip";
            this.lblCreateItemTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblCreateItemTooltip.TabIndex = 0;
            this.lblCreateItemTooltip.Text = "Adds the specified item to the target Player\'s inventory.";
            // 
            // frmCommandDespawnCreature
            // 
            this.frmCommandDespawnCreature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandDespawnCreature.Controls.Add(this.lblDespawnCreatureDelay);
            this.frmCommandDespawnCreature.Controls.Add(this.txtDespawnCreatureDelay);
            this.frmCommandDespawnCreature.Controls.Add(this.lblDespawnCreatureTooltip);
            this.frmCommandDespawnCreature.Location = new System.Drawing.Point(410, 250);
            this.frmCommandDespawnCreature.Name = "frmCommandDespawnCreature";
            this.frmCommandDespawnCreature.Size = new System.Drawing.Size(495, 332);
            this.frmCommandDespawnCreature.TabIndex = 24;
            this.frmCommandDespawnCreature.Visible = false;
            // 
            // lblDespawnCreatureDelay
            // 
            this.lblDespawnCreatureDelay.AutoSize = true;
            this.lblDespawnCreatureDelay.Location = new System.Drawing.Point(59, 61);
            this.lblDespawnCreatureDelay.Name = "lblDespawnCreatureDelay";
            this.lblDespawnCreatureDelay.Size = new System.Drawing.Size(37, 13);
            this.lblDespawnCreatureDelay.TabIndex = 2;
            this.lblDespawnCreatureDelay.Text = "Delay:";
            // 
            // txtDespawnCreatureDelay
            // 
            this.txtDespawnCreatureDelay.Location = new System.Drawing.Point(99, 58);
            this.txtDespawnCreatureDelay.Name = "txtDespawnCreatureDelay";
            this.txtDespawnCreatureDelay.Size = new System.Drawing.Size(374, 20);
            this.txtDespawnCreatureDelay.TabIndex = 1;
            this.txtDespawnCreatureDelay.Leave += new System.EventHandler(this.txtDespawnCreatureDelay_Leave);
            // 
            // lblDespawnCreatureTooltip
            // 
            this.lblDespawnCreatureTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDespawnCreatureTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblDespawnCreatureTooltip.Name = "lblDespawnCreatureTooltip";
            this.lblDespawnCreatureTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblDespawnCreatureTooltip.TabIndex = 0;
            this.lblDespawnCreatureTooltip.Text = "Despawns the source Creature after the specified delay.";
            // 
            // frmCommandSetEquipment
            // 
            this.frmCommandSetEquipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentRanged);
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentOffHand);
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentMainHand);
            this.frmCommandSetEquipment.Controls.Add(this.btnSetEquipmentRanged);
            this.frmCommandSetEquipment.Controls.Add(this.btnSetEquipmentOffHand);
            this.frmCommandSetEquipment.Controls.Add(this.btnSetEquipmentMainHand);
            this.frmCommandSetEquipment.Controls.Add(this.cmbSetEquipmentUseDefault);
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentUseDefault);
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentTooltip);
            this.frmCommandSetEquipment.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetEquipment.Name = "frmCommandSetEquipment";
            this.frmCommandSetEquipment.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetEquipment.TabIndex = 25;
            this.frmCommandSetEquipment.Visible = false;
            // 
            // lblSetEquipmentRanged
            // 
            this.lblSetEquipmentRanged.AutoSize = true;
            this.lblSetEquipmentRanged.Location = new System.Drawing.Point(47, 157);
            this.lblSetEquipmentRanged.Name = "lblSetEquipmentRanged";
            this.lblSetEquipmentRanged.Size = new System.Drawing.Size(48, 13);
            this.lblSetEquipmentRanged.TabIndex = 8;
            this.lblSetEquipmentRanged.Text = "Ranged:";
            // 
            // lblSetEquipmentOffHand
            // 
            this.lblSetEquipmentOffHand.AutoSize = true;
            this.lblSetEquipmentOffHand.Location = new System.Drawing.Point(42, 125);
            this.lblSetEquipmentOffHand.Name = "lblSetEquipmentOffHand";
            this.lblSetEquipmentOffHand.Size = new System.Drawing.Size(53, 13);
            this.lblSetEquipmentOffHand.TabIndex = 7;
            this.lblSetEquipmentOffHand.Text = "Off Hand:";
            // 
            // lblSetEquipmentMainHand
            // 
            this.lblSetEquipmentMainHand.AutoSize = true;
            this.lblSetEquipmentMainHand.Location = new System.Drawing.Point(33, 93);
            this.lblSetEquipmentMainHand.Name = "lblSetEquipmentMainHand";
            this.lblSetEquipmentMainHand.Size = new System.Drawing.Size(62, 13);
            this.lblSetEquipmentMainHand.TabIndex = 6;
            this.lblSetEquipmentMainHand.Text = "Main Hand:";
            // 
            // btnSetEquipmentRanged
            // 
            this.btnSetEquipmentRanged.Location = new System.Drawing.Point(99, 152);
            this.btnSetEquipmentRanged.Name = "btnSetEquipmentRanged";
            this.btnSetEquipmentRanged.Size = new System.Drawing.Size(374, 23);
            this.btnSetEquipmentRanged.TabIndex = 5;
            this.btnSetEquipmentRanged.Text = "-NONE-";
            this.btnSetEquipmentRanged.UseVisualStyleBackColor = true;
            this.btnSetEquipmentRanged.Click += new System.EventHandler(this.btnSetEquipmentRanged_Click);
            // 
            // btnSetEquipmentOffHand
            // 
            this.btnSetEquipmentOffHand.Location = new System.Drawing.Point(99, 120);
            this.btnSetEquipmentOffHand.Name = "btnSetEquipmentOffHand";
            this.btnSetEquipmentOffHand.Size = new System.Drawing.Size(374, 23);
            this.btnSetEquipmentOffHand.TabIndex = 4;
            this.btnSetEquipmentOffHand.Text = "-NONE-";
            this.btnSetEquipmentOffHand.UseVisualStyleBackColor = true;
            this.btnSetEquipmentOffHand.Click += new System.EventHandler(this.btnSetEquipmentOffHand_Click);
            // 
            // btnSetEquipmentMainHand
            // 
            this.btnSetEquipmentMainHand.Location = new System.Drawing.Point(99, 88);
            this.btnSetEquipmentMainHand.Name = "btnSetEquipmentMainHand";
            this.btnSetEquipmentMainHand.Size = new System.Drawing.Size(374, 23);
            this.btnSetEquipmentMainHand.TabIndex = 3;
            this.btnSetEquipmentMainHand.Text = "-NONE-";
            this.btnSetEquipmentMainHand.UseVisualStyleBackColor = true;
            this.btnSetEquipmentMainHand.Click += new System.EventHandler(this.btnSetEquipmentMainHand_Click);
            // 
            // cmbSetEquipmentUseDefault
            // 
            this.cmbSetEquipmentUseDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetEquipmentUseDefault.FormattingEnabled = true;
            this.cmbSetEquipmentUseDefault.Items.AddRange(new object[] {
            "Specified Items",
            "Default Equipment"});
            this.cmbSetEquipmentUseDefault.Location = new System.Drawing.Point(99, 58);
            this.cmbSetEquipmentUseDefault.Name = "cmbSetEquipmentUseDefault";
            this.cmbSetEquipmentUseDefault.Size = new System.Drawing.Size(374, 21);
            this.cmbSetEquipmentUseDefault.TabIndex = 2;
            this.cmbSetEquipmentUseDefault.SelectedIndexChanged += new System.EventHandler(this.cmbSetEquipmentUseDefault_SelectedIndexChanged);
            // 
            // lblSetEquipmentUseDefault
            // 
            this.lblSetEquipmentUseDefault.AutoSize = true;
            this.lblSetEquipmentUseDefault.Location = new System.Drawing.Point(60, 61);
            this.lblSetEquipmentUseDefault.Name = "lblSetEquipmentUseDefault";
            this.lblSetEquipmentUseDefault.Size = new System.Drawing.Size(35, 13);
            this.lblSetEquipmentUseDefault.TabIndex = 1;
            this.lblSetEquipmentUseDefault.Text = "Items:";
            // 
            // lblSetEquipmentTooltip
            // 
            this.lblSetEquipmentTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetEquipmentTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetEquipmentTooltip.Name = "lblSetEquipmentTooltip";
            this.lblSetEquipmentTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetEquipmentTooltip.TabIndex = 0;
            this.lblSetEquipmentTooltip.Text = "Changes the equipped item in the specified slot. This is purely visual.";
            // 
            // frmCommandSetMovement
            // 
            this.frmCommandSetMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementAngle);
            this.frmCommandSetMovement.Controls.Add(this.txtSetMovementAngle);
            this.frmCommandSetMovement.Controls.Add(this.txtSetMovementDistance);
            this.frmCommandSetMovement.Controls.Add(this.txtSetMovementIntParam);
            this.frmCommandSetMovement.Controls.Add(this.cmbSetMovementBoolParam);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementDistance);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementIntParam);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementBoolParam);
            this.frmCommandSetMovement.Controls.Add(this.cmbSetMovementType);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementType);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementTooltip);
            this.frmCommandSetMovement.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetMovement.Name = "frmCommandSetMovement";
            this.frmCommandSetMovement.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetMovement.TabIndex = 26;
            this.frmCommandSetMovement.Visible = false;
            // 
            // lblSetMovementAngle
            // 
            this.lblSetMovementAngle.AutoSize = true;
            this.lblSetMovementAngle.Location = new System.Drawing.Point(58, 182);
            this.lblSetMovementAngle.Name = "lblSetMovementAngle";
            this.lblSetMovementAngle.Size = new System.Drawing.Size(37, 13);
            this.lblSetMovementAngle.TabIndex = 13;
            this.lblSetMovementAngle.Text = "Angle:";
            // 
            // txtSetMovementAngle
            // 
            this.txtSetMovementAngle.Location = new System.Drawing.Point(99, 180);
            this.txtSetMovementAngle.Name = "txtSetMovementAngle";
            this.txtSetMovementAngle.Size = new System.Drawing.Size(374, 20);
            this.txtSetMovementAngle.TabIndex = 12;
            this.txtSetMovementAngle.Leave += new System.EventHandler(this.txtSetMovementAngle_Leave);
            // 
            // txtSetMovementDistance
            // 
            this.txtSetMovementDistance.Location = new System.Drawing.Point(99, 150);
            this.txtSetMovementDistance.Name = "txtSetMovementDistance";
            this.txtSetMovementDistance.Size = new System.Drawing.Size(374, 20);
            this.txtSetMovementDistance.TabIndex = 11;
            this.txtSetMovementDistance.Leave += new System.EventHandler(this.txtSetMovementDistance_Leave);
            // 
            // txtSetMovementIntParam
            // 
            this.txtSetMovementIntParam.Location = new System.Drawing.Point(99, 120);
            this.txtSetMovementIntParam.Name = "txtSetMovementIntParam";
            this.txtSetMovementIntParam.Size = new System.Drawing.Size(374, 20);
            this.txtSetMovementIntParam.TabIndex = 10;
            this.txtSetMovementIntParam.Leave += new System.EventHandler(this.txtSetMovementIntParam_Leave);
            // 
            // cmbSetMovementBoolParam
            // 
            this.cmbSetMovementBoolParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetMovementBoolParam.FormattingEnabled = true;
            this.cmbSetMovementBoolParam.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSetMovementBoolParam.Location = new System.Drawing.Point(99, 89);
            this.cmbSetMovementBoolParam.Name = "cmbSetMovementBoolParam";
            this.cmbSetMovementBoolParam.Size = new System.Drawing.Size(374, 21);
            this.cmbSetMovementBoolParam.TabIndex = 9;
            this.cmbSetMovementBoolParam.SelectedIndexChanged += new System.EventHandler(this.cmbSetMovementBoolParam_SelectedIndexChanged);
            // 
            // lblSetMovementDistance
            // 
            this.lblSetMovementDistance.AutoSize = true;
            this.lblSetMovementDistance.Location = new System.Drawing.Point(43, 152);
            this.lblSetMovementDistance.Name = "lblSetMovementDistance";
            this.lblSetMovementDistance.Size = new System.Drawing.Size(52, 13);
            this.lblSetMovementDistance.TabIndex = 8;
            this.lblSetMovementDistance.Text = "Distance:";
            // 
            // lblSetMovementIntParam
            // 
            this.lblSetMovementIntParam.AutoSize = true;
            this.lblSetMovementIntParam.Location = new System.Drawing.Point(40, 122);
            this.lblSetMovementIntParam.Name = "lblSetMovementIntParam";
            this.lblSetMovementIntParam.Size = new System.Drawing.Size(55, 13);
            this.lblSetMovementIntParam.TabIndex = 7;
            this.lblSetMovementIntParam.Text = "Int Param:";
            // 
            // lblSetMovementBoolParam
            // 
            this.lblSetMovementBoolParam.AutoSize = true;
            this.lblSetMovementBoolParam.Location = new System.Drawing.Point(31, 92);
            this.lblSetMovementBoolParam.Name = "lblSetMovementBoolParam";
            this.lblSetMovementBoolParam.Size = new System.Drawing.Size(64, 13);
            this.lblSetMovementBoolParam.TabIndex = 6;
            this.lblSetMovementBoolParam.Text = "Bool Param:";
            // 
            // cmbSetMovementType
            // 
            this.cmbSetMovementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetMovementType.FormattingEnabled = true;
            this.cmbSetMovementType.Items.AddRange(new object[] {
            "Specified Items",
            "Default Equipment"});
            this.cmbSetMovementType.Location = new System.Drawing.Point(99, 58);
            this.cmbSetMovementType.Name = "cmbSetMovementType";
            this.cmbSetMovementType.Size = new System.Drawing.Size(374, 21);
            this.cmbSetMovementType.TabIndex = 2;
            this.cmbSetMovementType.SelectedIndexChanged += new System.EventHandler(this.cmbSetMovementType_SelectedIndexChanged);
            // 
            // lblSetMovementType
            // 
            this.lblSetMovementType.AutoSize = true;
            this.lblSetMovementType.Location = new System.Drawing.Point(26, 61);
            this.lblSetMovementType.Name = "lblSetMovementType";
            this.lblSetMovementType.Size = new System.Drawing.Size(69, 13);
            this.lblSetMovementType.TabIndex = 1;
            this.lblSetMovementType.Text = "Motion Type:";
            // 
            // lblSetMovementTooltip
            // 
            this.lblSetMovementTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetMovementTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetMovementTooltip.Name = "lblSetMovementTooltip";
            this.lblSetMovementTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetMovementTooltip.TabIndex = 0;
            this.lblSetMovementTooltip.Text = "Changes the current movement type used by the source Creature.";
            // 
            // frmCommandActiveObject
            // 
            this.frmCommandActiveObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandActiveObject.Controls.Add(this.cmbActiveObjectSetActive);
            this.frmCommandActiveObject.Controls.Add(this.lblActiveObjectSetActive);
            this.frmCommandActiveObject.Controls.Add(this.lblActiveObjectTooltip);
            this.frmCommandActiveObject.Location = new System.Drawing.Point(410, 250);
            this.frmCommandActiveObject.Name = "frmCommandActiveObject";
            this.frmCommandActiveObject.Size = new System.Drawing.Size(495, 332);
            this.frmCommandActiveObject.TabIndex = 27;
            this.frmCommandActiveObject.Visible = false;
            // 
            // cmbActiveObjectSetActive
            // 
            this.cmbActiveObjectSetActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveObjectSetActive.FormattingEnabled = true;
            this.cmbActiveObjectSetActive.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.cmbActiveObjectSetActive.Location = new System.Drawing.Point(99, 58);
            this.cmbActiveObjectSetActive.Name = "cmbActiveObjectSetActive";
            this.cmbActiveObjectSetActive.Size = new System.Drawing.Size(374, 21);
            this.cmbActiveObjectSetActive.TabIndex = 2;
            this.cmbActiveObjectSetActive.SelectedIndexChanged += new System.EventHandler(this.cmbActiveObjectSetActive_SelectedIndexChanged);
            // 
            // lblActiveObjectSetActive
            // 
            this.lblActiveObjectSetActive.AutoSize = true;
            this.lblActiveObjectSetActive.Location = new System.Drawing.Point(58, 61);
            this.lblActiveObjectSetActive.Name = "lblActiveObjectSetActive";
            this.lblActiveObjectSetActive.Size = new System.Drawing.Size(35, 13);
            this.lblActiveObjectSetActive.TabIndex = 1;
            this.lblActiveObjectSetActive.Text = "State:";
            // 
            // lblActiveObjectTooltip
            // 
            this.lblActiveObjectTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActiveObjectTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblActiveObjectTooltip.Name = "lblActiveObjectTooltip";
            this.lblActiveObjectTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblActiveObjectTooltip.TabIndex = 0;
            this.lblActiveObjectTooltip.Text = "Makes the source WorldObject into an Active Object. That means its always updated" +
    ", even if there are no players around.";
            // 
            // frmCommandSetFaction
            // 
            this.frmCommandSetFaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetFaction.Controls.Add(this.btnSetFactionId);
            this.frmCommandSetFaction.Controls.Add(this.grpSetFactionFlags);
            this.frmCommandSetFaction.Controls.Add(this.lblSetFactionId);
            this.frmCommandSetFaction.Controls.Add(this.lblSetFactionTooltip);
            this.frmCommandSetFaction.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetFaction.Name = "frmCommandSetFaction";
            this.frmCommandSetFaction.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetFaction.TabIndex = 28;
            this.frmCommandSetFaction.Visible = false;
            // 
            // btnSetFactionId
            // 
            this.btnSetFactionId.Location = new System.Drawing.Point(83, 57);
            this.btnSetFactionId.Name = "btnSetFactionId";
            this.btnSetFactionId.Size = new System.Drawing.Size(390, 23);
            this.btnSetFactionId.TabIndex = 5;
            this.btnSetFactionId.Text = "-NONE-";
            this.btnSetFactionId.UseVisualStyleBackColor = true;
            this.btnSetFactionId.Click += new System.EventHandler(this.btnSetFactionId_Click);
            // 
            // grpSetFactionFlags
            // 
            this.grpSetFactionFlags.Controls.Add(this.chkSetFactionFlag4);
            this.grpSetFactionFlags.Controls.Add(this.chkSetFactionFlag2);
            this.grpSetFactionFlags.Controls.Add(this.chkSetFactionFlag1);
            this.grpSetFactionFlags.Location = new System.Drawing.Point(26, 88);
            this.grpSetFactionFlags.Name = "grpSetFactionFlags";
            this.grpSetFactionFlags.Size = new System.Drawing.Size(447, 48);
            this.grpSetFactionFlags.TabIndex = 3;
            this.grpSetFactionFlags.TabStop = false;
            this.grpSetFactionFlags.Text = "Restore Faction On";
            // 
            // chkSetFactionFlag4
            // 
            this.chkSetFactionFlag4.AutoSize = true;
            this.chkSetFactionFlag4.Location = new System.Drawing.Point(186, 21);
            this.chkSetFactionFlag4.Name = "chkSetFactionFlag4";
            this.chkSetFactionFlag4.Size = new System.Drawing.Size(101, 17);
            this.chkSetFactionFlag4.TabIndex = 2;
            this.chkSetFactionFlag4.Text = "Reached Home";
            this.chkSetFactionFlag4.UseVisualStyleBackColor = true;
            this.chkSetFactionFlag4.CheckedChanged += new System.EventHandler(this.chkSetFactionFlag4_CheckedChanged);
            // 
            // chkSetFactionFlag2
            // 
            this.chkSetFactionFlag2.AutoSize = true;
            this.chkSetFactionFlag2.Location = new System.Drawing.Point(90, 21);
            this.chkSetFactionFlag2.Name = "chkSetFactionFlag2";
            this.chkSetFactionFlag2.Size = new System.Drawing.Size(87, 17);
            this.chkSetFactionFlag2.TabIndex = 1;
            this.chkSetFactionFlag2.Text = "Combat Stop";
            this.chkSetFactionFlag2.UseVisualStyleBackColor = true;
            this.chkSetFactionFlag2.CheckedChanged += new System.EventHandler(this.chkSetFactionFlag2_CheckedChanged);
            // 
            // chkSetFactionFlag1
            // 
            this.chkSetFactionFlag1.AutoSize = true;
            this.chkSetFactionFlag1.Location = new System.Drawing.Point(10, 21);
            this.chkSetFactionFlag1.Name = "chkSetFactionFlag1";
            this.chkSetFactionFlag1.Size = new System.Drawing.Size(71, 17);
            this.chkSetFactionFlag1.TabIndex = 0;
            this.chkSetFactionFlag1.Text = "Respawn";
            this.chkSetFactionFlag1.UseVisualStyleBackColor = true;
            this.chkSetFactionFlag1.CheckedChanged += new System.EventHandler(this.chkSetFactionFlag1_CheckedChanged);
            // 
            // lblSetFactionId
            // 
            this.lblSetFactionId.AutoSize = true;
            this.lblSetFactionId.Location = new System.Drawing.Point(24, 61);
            this.lblSetFactionId.Name = "lblSetFactionId";
            this.lblSetFactionId.Size = new System.Drawing.Size(57, 13);
            this.lblSetFactionId.TabIndex = 1;
            this.lblSetFactionId.Text = "Faction Id:";
            // 
            // lblSetFactionTooltip
            // 
            this.lblSetFactionTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetFactionTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetFactionTooltip.Name = "lblSetFactionTooltip";
            this.lblSetFactionTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetFactionTooltip.TabIndex = 0;
            this.lblSetFactionTooltip.Text = "Temporarily changes the source Creature\'s faction to the one specified. Set flags" +
    " to specify when the original faction will be restored.";
            // 
            // frmCommandMorphOrMount
            // 
            this.frmCommandMorphOrMount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandMorphOrMount.Controls.Add(this.cmbMorphOrMountType);
            this.frmCommandMorphOrMount.Controls.Add(this.lblMorphOrMountId);
            this.frmCommandMorphOrMount.Controls.Add(this.lblMorphOrMountType);
            this.frmCommandMorphOrMount.Controls.Add(this.btnMorphOrMountId);
            this.frmCommandMorphOrMount.Controls.Add(this.lblMorphOrMountTooltip);
            this.frmCommandMorphOrMount.Location = new System.Drawing.Point(410, 250);
            this.frmCommandMorphOrMount.Name = "frmCommandMorphOrMount";
            this.frmCommandMorphOrMount.Size = new System.Drawing.Size(495, 332);
            this.frmCommandMorphOrMount.TabIndex = 29;
            this.frmCommandMorphOrMount.Visible = false;
            // 
            // cmbMorphOrMountType
            // 
            this.cmbMorphOrMountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMorphOrMountType.FormattingEnabled = true;
            this.cmbMorphOrMountType.Items.AddRange(new object[] {
            "Creature Id",
            "Display Id"});
            this.cmbMorphOrMountType.Location = new System.Drawing.Point(99, 90);
            this.cmbMorphOrMountType.Name = "cmbMorphOrMountType";
            this.cmbMorphOrMountType.Size = new System.Drawing.Size(374, 21);
            this.cmbMorphOrMountType.TabIndex = 5;
            this.cmbMorphOrMountType.SelectedIndexChanged += new System.EventHandler(this.cmbMorphOrMountType_SelectedIndexChanged);
            // 
            // lblMorphOrMountId
            // 
            this.lblMorphOrMountId.AutoSize = true;
            this.lblMorphOrMountId.Location = new System.Drawing.Point(77, 61);
            this.lblMorphOrMountId.Name = "lblMorphOrMountId";
            this.lblMorphOrMountId.Size = new System.Drawing.Size(19, 13);
            this.lblMorphOrMountId.TabIndex = 4;
            this.lblMorphOrMountId.Text = "Id:";
            // 
            // lblMorphOrMountType
            // 
            this.lblMorphOrMountType.AutoSize = true;
            this.lblMorphOrMountType.Location = new System.Drawing.Point(62, 93);
            this.lblMorphOrMountType.Name = "lblMorphOrMountType";
            this.lblMorphOrMountType.Size = new System.Drawing.Size(34, 13);
            this.lblMorphOrMountType.TabIndex = 3;
            this.lblMorphOrMountType.Text = "Type:";
            // 
            // btnMorphOrMountId
            // 
            this.btnMorphOrMountId.Location = new System.Drawing.Point(99, 58);
            this.btnMorphOrMountId.Name = "btnMorphOrMountId";
            this.btnMorphOrMountId.Size = new System.Drawing.Size(374, 23);
            this.btnMorphOrMountId.TabIndex = 1;
            this.btnMorphOrMountId.Text = "-NONE-";
            this.btnMorphOrMountId.UseVisualStyleBackColor = true;
            this.btnMorphOrMountId.Click += new System.EventHandler(this.btnMorphOrMountId_Click);
            // 
            // lblMorphOrMountTooltip
            // 
            this.lblMorphOrMountTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMorphOrMountTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblMorphOrMountTooltip.Name = "lblMorphOrMountTooltip";
            this.lblMorphOrMountTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblMorphOrMountTooltip.TabIndex = 0;
            this.lblMorphOrMountTooltip.Text = "Changes the Creature source\'s current display id.";
            // 
            // frmCommandSetRun
            // 
            this.frmCommandSetRun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetRun.Controls.Add(this.cmbSetRunMode);
            this.frmCommandSetRun.Controls.Add(this.lblSetRunMode);
            this.frmCommandSetRun.Controls.Add(this.lblSetRunTooltip);
            this.frmCommandSetRun.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetRun.Name = "frmCommandSetRun";
            this.frmCommandSetRun.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetRun.TabIndex = 30;
            this.frmCommandSetRun.Visible = false;
            // 
            // cmbSetRunMode
            // 
            this.cmbSetRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetRunMode.FormattingEnabled = true;
            this.cmbSetRunMode.Items.AddRange(new object[] {
            "Walking",
            "Running"});
            this.cmbSetRunMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetRunMode.Name = "cmbSetRunMode";
            this.cmbSetRunMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetRunMode.TabIndex = 2;
            this.cmbSetRunMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetRunMode_SelectedIndexChanged);
            // 
            // lblSetRunMode
            // 
            this.lblSetRunMode.AutoSize = true;
            this.lblSetRunMode.Location = new System.Drawing.Point(31, 61);
            this.lblSetRunMode.Name = "lblSetRunMode";
            this.lblSetRunMode.Size = new System.Drawing.Size(65, 13);
            this.lblSetRunMode.TabIndex = 1;
            this.lblSetRunMode.Text = "Walk Mode:";
            // 
            // lblSetRunTooltip
            // 
            this.lblSetRunTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetRunTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetRunTooltip.Name = "lblSetRunTooltip";
            this.lblSetRunTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetRunTooltip.TabIndex = 0;
            this.lblSetRunTooltip.Text = "Changes the source Creature\'s walk mode.";
            // 
            // frmCommandModifyFlags
            // 
            this.frmCommandModifyFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags536870912);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags268435456);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags134217728);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags67108864);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags33554432);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags16777216);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags8388608);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags4194304);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags2097152);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags1048576);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags524288);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags262144);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags131072);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags65536);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags32768);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags16384);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags8192);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags4096);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags2048);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags1024);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags512);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags256);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags128);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags64);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags32);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags16);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags8);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags4);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags2);
            this.frmCommandModifyFlags.Controls.Add(this.chkModifyFlags1);
            this.frmCommandModifyFlags.Controls.Add(this.cmbModifyFlagsMode);
            this.frmCommandModifyFlags.Controls.Add(this.lblModifyFlagsMode);
            this.frmCommandModifyFlags.Controls.Add(this.cmbModifyFlagsFieldId);
            this.frmCommandModifyFlags.Controls.Add(this.lblModifyFlagsField);
            this.frmCommandModifyFlags.Controls.Add(this.lblModifyFlagsTooltip);
            this.frmCommandModifyFlags.Location = new System.Drawing.Point(410, 250);
            this.frmCommandModifyFlags.Name = "frmCommandModifyFlags";
            this.frmCommandModifyFlags.Size = new System.Drawing.Size(495, 332);
            this.frmCommandModifyFlags.TabIndex = 31;
            this.frmCommandModifyFlags.Visible = false;
            // 
            // chkModifyFlags536870912
            // 
            this.chkModifyFlags536870912.AutoSize = true;
            this.chkModifyFlags536870912.Location = new System.Drawing.Point(327, 303);
            this.chkModifyFlags536870912.Name = "chkModifyFlags536870912";
            this.chkModifyFlags536870912.Size = new System.Drawing.Size(141, 17);
            this.chkModifyFlags536870912.TabIndex = 34;
            this.chkModifyFlags536870912.Text = "CHK_FLAG_536870912";
            this.chkModifyFlags536870912.UseVisualStyleBackColor = true;
            this.chkModifyFlags536870912.CheckedChanged += new System.EventHandler(this.chkModifyFlags536870912_CheckedChanged);
            // 
            // chkModifyFlags268435456
            // 
            this.chkModifyFlags268435456.AutoSize = true;
            this.chkModifyFlags268435456.Location = new System.Drawing.Point(327, 279);
            this.chkModifyFlags268435456.Name = "chkModifyFlags268435456";
            this.chkModifyFlags268435456.Size = new System.Drawing.Size(141, 17);
            this.chkModifyFlags268435456.TabIndex = 33;
            this.chkModifyFlags268435456.Text = "CHK_FLAG_268435456";
            this.chkModifyFlags268435456.UseVisualStyleBackColor = true;
            this.chkModifyFlags268435456.CheckedChanged += new System.EventHandler(this.chkModifyFlags268435456_CheckedChanged);
            // 
            // chkModifyFlags134217728
            // 
            this.chkModifyFlags134217728.AutoSize = true;
            this.chkModifyFlags134217728.Location = new System.Drawing.Point(327, 255);
            this.chkModifyFlags134217728.Name = "chkModifyFlags134217728";
            this.chkModifyFlags134217728.Size = new System.Drawing.Size(141, 17);
            this.chkModifyFlags134217728.TabIndex = 32;
            this.chkModifyFlags134217728.Text = "CHK_FLAG_134217728";
            this.chkModifyFlags134217728.UseVisualStyleBackColor = true;
            this.chkModifyFlags134217728.CheckedChanged += new System.EventHandler(this.chkModifyFlags134217728_CheckedChanged);
            // 
            // chkModifyFlags67108864
            // 
            this.chkModifyFlags67108864.AutoSize = true;
            this.chkModifyFlags67108864.Location = new System.Drawing.Point(327, 231);
            this.chkModifyFlags67108864.Name = "chkModifyFlags67108864";
            this.chkModifyFlags67108864.Size = new System.Drawing.Size(135, 17);
            this.chkModifyFlags67108864.TabIndex = 31;
            this.chkModifyFlags67108864.Text = "CHK_FLAG_67108864";
            this.chkModifyFlags67108864.UseVisualStyleBackColor = true;
            this.chkModifyFlags67108864.CheckedChanged += new System.EventHandler(this.chkModifyFlags67108864_CheckedChanged);
            // 
            // chkModifyFlags33554432
            // 
            this.chkModifyFlags33554432.AutoSize = true;
            this.chkModifyFlags33554432.Location = new System.Drawing.Point(327, 207);
            this.chkModifyFlags33554432.Name = "chkModifyFlags33554432";
            this.chkModifyFlags33554432.Size = new System.Drawing.Size(135, 17);
            this.chkModifyFlags33554432.TabIndex = 30;
            this.chkModifyFlags33554432.Text = "CHK_FLAG_33554432";
            this.chkModifyFlags33554432.UseVisualStyleBackColor = true;
            this.chkModifyFlags33554432.CheckedChanged += new System.EventHandler(this.chkModifyFlags33554432_CheckedChanged);
            // 
            // chkModifyFlags16777216
            // 
            this.chkModifyFlags16777216.AutoSize = true;
            this.chkModifyFlags16777216.Location = new System.Drawing.Point(327, 183);
            this.chkModifyFlags16777216.Name = "chkModifyFlags16777216";
            this.chkModifyFlags16777216.Size = new System.Drawing.Size(135, 17);
            this.chkModifyFlags16777216.TabIndex = 29;
            this.chkModifyFlags16777216.Text = "CHK_FLAG_16777216";
            this.chkModifyFlags16777216.UseVisualStyleBackColor = true;
            this.chkModifyFlags16777216.CheckedChanged += new System.EventHandler(this.chkModifyFlags16777216_CheckedChanged);
            // 
            // chkModifyFlags8388608
            // 
            this.chkModifyFlags8388608.AutoSize = true;
            this.chkModifyFlags8388608.Location = new System.Drawing.Point(327, 159);
            this.chkModifyFlags8388608.Name = "chkModifyFlags8388608";
            this.chkModifyFlags8388608.Size = new System.Drawing.Size(129, 17);
            this.chkModifyFlags8388608.TabIndex = 28;
            this.chkModifyFlags8388608.Text = "CHK_FLAG_8388608";
            this.chkModifyFlags8388608.UseVisualStyleBackColor = true;
            this.chkModifyFlags8388608.CheckedChanged += new System.EventHandler(this.chkModifyFlags8388608_CheckedChanged);
            // 
            // chkModifyFlags4194304
            // 
            this.chkModifyFlags4194304.AutoSize = true;
            this.chkModifyFlags4194304.Location = new System.Drawing.Point(327, 135);
            this.chkModifyFlags4194304.Name = "chkModifyFlags4194304";
            this.chkModifyFlags4194304.Size = new System.Drawing.Size(129, 17);
            this.chkModifyFlags4194304.TabIndex = 27;
            this.chkModifyFlags4194304.Text = "CHK_FLAG_4194304";
            this.chkModifyFlags4194304.UseVisualStyleBackColor = true;
            this.chkModifyFlags4194304.CheckedChanged += new System.EventHandler(this.chkModifyFlags4194304_CheckedChanged);
            // 
            // chkModifyFlags2097152
            // 
            this.chkModifyFlags2097152.AutoSize = true;
            this.chkModifyFlags2097152.Location = new System.Drawing.Point(327, 111);
            this.chkModifyFlags2097152.Name = "chkModifyFlags2097152";
            this.chkModifyFlags2097152.Size = new System.Drawing.Size(129, 17);
            this.chkModifyFlags2097152.TabIndex = 26;
            this.chkModifyFlags2097152.Text = "CHK_FLAG_2097152";
            this.chkModifyFlags2097152.UseVisualStyleBackColor = true;
            this.chkModifyFlags2097152.CheckedChanged += new System.EventHandler(this.chkModifyFlags2097152_CheckedChanged);
            // 
            // chkModifyFlags1048576
            // 
            this.chkModifyFlags1048576.AutoSize = true;
            this.chkModifyFlags1048576.Location = new System.Drawing.Point(327, 87);
            this.chkModifyFlags1048576.Name = "chkModifyFlags1048576";
            this.chkModifyFlags1048576.Size = new System.Drawing.Size(129, 17);
            this.chkModifyFlags1048576.TabIndex = 25;
            this.chkModifyFlags1048576.Text = "CHK_FLAG_1048576";
            this.chkModifyFlags1048576.UseVisualStyleBackColor = true;
            this.chkModifyFlags1048576.CheckedChanged += new System.EventHandler(this.chkModifyFlags1048576_CheckedChanged);
            // 
            // chkModifyFlags524288
            // 
            this.chkModifyFlags524288.AutoSize = true;
            this.chkModifyFlags524288.Location = new System.Drawing.Point(177, 303);
            this.chkModifyFlags524288.Name = "chkModifyFlags524288";
            this.chkModifyFlags524288.Size = new System.Drawing.Size(123, 17);
            this.chkModifyFlags524288.TabIndex = 24;
            this.chkModifyFlags524288.Text = "CHK_FLAG_524288";
            this.chkModifyFlags524288.UseVisualStyleBackColor = true;
            this.chkModifyFlags524288.CheckedChanged += new System.EventHandler(this.chkModifyFlags524288_CheckedChanged);
            // 
            // chkModifyFlags262144
            // 
            this.chkModifyFlags262144.AutoSize = true;
            this.chkModifyFlags262144.Location = new System.Drawing.Point(177, 279);
            this.chkModifyFlags262144.Name = "chkModifyFlags262144";
            this.chkModifyFlags262144.Size = new System.Drawing.Size(123, 17);
            this.chkModifyFlags262144.TabIndex = 23;
            this.chkModifyFlags262144.Text = "CHK_FLAG_262144";
            this.chkModifyFlags262144.UseVisualStyleBackColor = true;
            this.chkModifyFlags262144.CheckedChanged += new System.EventHandler(this.chkModifyFlags262144_CheckedChanged);
            // 
            // chkModifyFlags131072
            // 
            this.chkModifyFlags131072.AutoSize = true;
            this.chkModifyFlags131072.Location = new System.Drawing.Point(177, 255);
            this.chkModifyFlags131072.Name = "chkModifyFlags131072";
            this.chkModifyFlags131072.Size = new System.Drawing.Size(123, 17);
            this.chkModifyFlags131072.TabIndex = 22;
            this.chkModifyFlags131072.Text = "CHK_FLAG_131072";
            this.chkModifyFlags131072.UseVisualStyleBackColor = true;
            this.chkModifyFlags131072.CheckedChanged += new System.EventHandler(this.chkModifyFlags131072_CheckedChanged);
            // 
            // chkModifyFlags65536
            // 
            this.chkModifyFlags65536.AutoSize = true;
            this.chkModifyFlags65536.Location = new System.Drawing.Point(177, 231);
            this.chkModifyFlags65536.Name = "chkModifyFlags65536";
            this.chkModifyFlags65536.Size = new System.Drawing.Size(117, 17);
            this.chkModifyFlags65536.TabIndex = 21;
            this.chkModifyFlags65536.Text = "CHK_FLAG_65536";
            this.chkModifyFlags65536.UseVisualStyleBackColor = true;
            this.chkModifyFlags65536.CheckedChanged += new System.EventHandler(this.chkModifyFlags65536_CheckedChanged);
            // 
            // chkModifyFlags32768
            // 
            this.chkModifyFlags32768.AutoSize = true;
            this.chkModifyFlags32768.Location = new System.Drawing.Point(177, 207);
            this.chkModifyFlags32768.Name = "chkModifyFlags32768";
            this.chkModifyFlags32768.Size = new System.Drawing.Size(117, 17);
            this.chkModifyFlags32768.TabIndex = 20;
            this.chkModifyFlags32768.Text = "CHK_FLAG_32768";
            this.chkModifyFlags32768.UseVisualStyleBackColor = true;
            this.chkModifyFlags32768.CheckedChanged += new System.EventHandler(this.chkModifyFlags32768_CheckedChanged);
            // 
            // chkModifyFlags16384
            // 
            this.chkModifyFlags16384.AutoSize = true;
            this.chkModifyFlags16384.Location = new System.Drawing.Point(177, 183);
            this.chkModifyFlags16384.Name = "chkModifyFlags16384";
            this.chkModifyFlags16384.Size = new System.Drawing.Size(117, 17);
            this.chkModifyFlags16384.TabIndex = 19;
            this.chkModifyFlags16384.Text = "CHK_FLAG_16384";
            this.chkModifyFlags16384.UseVisualStyleBackColor = true;
            this.chkModifyFlags16384.CheckedChanged += new System.EventHandler(this.chkModifyFlags16384_CheckedChanged);
            // 
            // chkModifyFlags8192
            // 
            this.chkModifyFlags8192.AutoSize = true;
            this.chkModifyFlags8192.Location = new System.Drawing.Point(177, 159);
            this.chkModifyFlags8192.Name = "chkModifyFlags8192";
            this.chkModifyFlags8192.Size = new System.Drawing.Size(111, 17);
            this.chkModifyFlags8192.TabIndex = 18;
            this.chkModifyFlags8192.Text = "CHK_FLAG_8192";
            this.chkModifyFlags8192.UseVisualStyleBackColor = true;
            this.chkModifyFlags8192.CheckedChanged += new System.EventHandler(this.chkModifyFlags8192_CheckedChanged);
            // 
            // chkModifyFlags4096
            // 
            this.chkModifyFlags4096.AutoSize = true;
            this.chkModifyFlags4096.Location = new System.Drawing.Point(177, 135);
            this.chkModifyFlags4096.Name = "chkModifyFlags4096";
            this.chkModifyFlags4096.Size = new System.Drawing.Size(111, 17);
            this.chkModifyFlags4096.TabIndex = 17;
            this.chkModifyFlags4096.Text = "CHK_FLAG_4096";
            this.chkModifyFlags4096.UseVisualStyleBackColor = true;
            this.chkModifyFlags4096.CheckedChanged += new System.EventHandler(this.chkModifyFlags4096_CheckedChanged);
            // 
            // chkModifyFlags2048
            // 
            this.chkModifyFlags2048.AutoSize = true;
            this.chkModifyFlags2048.Location = new System.Drawing.Point(177, 111);
            this.chkModifyFlags2048.Name = "chkModifyFlags2048";
            this.chkModifyFlags2048.Size = new System.Drawing.Size(111, 17);
            this.chkModifyFlags2048.TabIndex = 16;
            this.chkModifyFlags2048.Text = "CHK_FLAG_2048";
            this.chkModifyFlags2048.UseVisualStyleBackColor = true;
            this.chkModifyFlags2048.CheckedChanged += new System.EventHandler(this.chkModifyFlags2048_CheckedChanged);
            // 
            // chkModifyFlags1024
            // 
            this.chkModifyFlags1024.AutoSize = true;
            this.chkModifyFlags1024.Location = new System.Drawing.Point(177, 87);
            this.chkModifyFlags1024.Name = "chkModifyFlags1024";
            this.chkModifyFlags1024.Size = new System.Drawing.Size(111, 17);
            this.chkModifyFlags1024.TabIndex = 15;
            this.chkModifyFlags1024.Text = "CHK_FLAG_1024";
            this.chkModifyFlags1024.UseVisualStyleBackColor = true;
            this.chkModifyFlags1024.CheckedChanged += new System.EventHandler(this.chkModifyFlags1024_CheckedChanged);
            // 
            // chkModifyFlags512
            // 
            this.chkModifyFlags512.AutoSize = true;
            this.chkModifyFlags512.Location = new System.Drawing.Point(26, 303);
            this.chkModifyFlags512.Name = "chkModifyFlags512";
            this.chkModifyFlags512.Size = new System.Drawing.Size(105, 17);
            this.chkModifyFlags512.TabIndex = 14;
            this.chkModifyFlags512.Text = "CHK_FLAG_512";
            this.chkModifyFlags512.UseVisualStyleBackColor = true;
            this.chkModifyFlags512.CheckedChanged += new System.EventHandler(this.chkModifyFlags512_CheckedChanged);
            // 
            // chkModifyFlags256
            // 
            this.chkModifyFlags256.AutoSize = true;
            this.chkModifyFlags256.Location = new System.Drawing.Point(27, 279);
            this.chkModifyFlags256.Name = "chkModifyFlags256";
            this.chkModifyFlags256.Size = new System.Drawing.Size(105, 17);
            this.chkModifyFlags256.TabIndex = 13;
            this.chkModifyFlags256.Text = "CHK_FLAG_256";
            this.chkModifyFlags256.UseVisualStyleBackColor = true;
            this.chkModifyFlags256.CheckedChanged += new System.EventHandler(this.chkModifyFlags256_CheckedChanged);
            // 
            // chkModifyFlags128
            // 
            this.chkModifyFlags128.AutoSize = true;
            this.chkModifyFlags128.Location = new System.Drawing.Point(27, 255);
            this.chkModifyFlags128.Name = "chkModifyFlags128";
            this.chkModifyFlags128.Size = new System.Drawing.Size(105, 17);
            this.chkModifyFlags128.TabIndex = 12;
            this.chkModifyFlags128.Text = "CHK_FLAG_128";
            this.chkModifyFlags128.UseVisualStyleBackColor = true;
            this.chkModifyFlags128.CheckedChanged += new System.EventHandler(this.chkModifyFlags128_CheckedChanged);
            // 
            // chkModifyFlags64
            // 
            this.chkModifyFlags64.AutoSize = true;
            this.chkModifyFlags64.Location = new System.Drawing.Point(27, 231);
            this.chkModifyFlags64.Name = "chkModifyFlags64";
            this.chkModifyFlags64.Size = new System.Drawing.Size(99, 17);
            this.chkModifyFlags64.TabIndex = 11;
            this.chkModifyFlags64.Text = "CHK_FLAG_64";
            this.chkModifyFlags64.UseVisualStyleBackColor = true;
            this.chkModifyFlags64.CheckedChanged += new System.EventHandler(this.chkModifyFlags64_CheckedChanged);
            // 
            // chkModifyFlags32
            // 
            this.chkModifyFlags32.AutoSize = true;
            this.chkModifyFlags32.Location = new System.Drawing.Point(27, 207);
            this.chkModifyFlags32.Name = "chkModifyFlags32";
            this.chkModifyFlags32.Size = new System.Drawing.Size(99, 17);
            this.chkModifyFlags32.TabIndex = 10;
            this.chkModifyFlags32.Text = "CHK_FLAG_32";
            this.chkModifyFlags32.UseVisualStyleBackColor = true;
            this.chkModifyFlags32.CheckedChanged += new System.EventHandler(this.chkModifyFlags32_CheckedChanged);
            // 
            // chkModifyFlags16
            // 
            this.chkModifyFlags16.AutoSize = true;
            this.chkModifyFlags16.Location = new System.Drawing.Point(27, 183);
            this.chkModifyFlags16.Name = "chkModifyFlags16";
            this.chkModifyFlags16.Size = new System.Drawing.Size(99, 17);
            this.chkModifyFlags16.TabIndex = 9;
            this.chkModifyFlags16.Text = "CHK_FLAG_16";
            this.chkModifyFlags16.UseVisualStyleBackColor = true;
            this.chkModifyFlags16.CheckedChanged += new System.EventHandler(this.chkModifyFlags16_CheckedChanged);
            // 
            // chkModifyFlags8
            // 
            this.chkModifyFlags8.AutoSize = true;
            this.chkModifyFlags8.Location = new System.Drawing.Point(27, 159);
            this.chkModifyFlags8.Name = "chkModifyFlags8";
            this.chkModifyFlags8.Size = new System.Drawing.Size(93, 17);
            this.chkModifyFlags8.TabIndex = 8;
            this.chkModifyFlags8.Text = "CHK_FLAG_8";
            this.chkModifyFlags8.UseVisualStyleBackColor = true;
            this.chkModifyFlags8.CheckedChanged += new System.EventHandler(this.chkModifyFlags8_CheckedChanged);
            // 
            // chkModifyFlags4
            // 
            this.chkModifyFlags4.AutoSize = true;
            this.chkModifyFlags4.Location = new System.Drawing.Point(27, 135);
            this.chkModifyFlags4.Name = "chkModifyFlags4";
            this.chkModifyFlags4.Size = new System.Drawing.Size(93, 17);
            this.chkModifyFlags4.TabIndex = 7;
            this.chkModifyFlags4.Text = "CHK_FLAG_4";
            this.chkModifyFlags4.UseVisualStyleBackColor = true;
            this.chkModifyFlags4.CheckedChanged += new System.EventHandler(this.chkModifyFlags4_CheckedChanged);
            // 
            // chkModifyFlags2
            // 
            this.chkModifyFlags2.AutoSize = true;
            this.chkModifyFlags2.Location = new System.Drawing.Point(27, 111);
            this.chkModifyFlags2.Name = "chkModifyFlags2";
            this.chkModifyFlags2.Size = new System.Drawing.Size(93, 17);
            this.chkModifyFlags2.TabIndex = 6;
            this.chkModifyFlags2.Text = "CHK_FLAG_2";
            this.chkModifyFlags2.UseVisualStyleBackColor = true;
            this.chkModifyFlags2.CheckedChanged += new System.EventHandler(this.chkModifyFlags2_CheckedChanged);
            // 
            // chkModifyFlags1
            // 
            this.chkModifyFlags1.AutoSize = true;
            this.chkModifyFlags1.Location = new System.Drawing.Point(27, 87);
            this.chkModifyFlags1.Name = "chkModifyFlags1";
            this.chkModifyFlags1.Size = new System.Drawing.Size(93, 17);
            this.chkModifyFlags1.TabIndex = 5;
            this.chkModifyFlags1.Text = "CHK_FLAG_1";
            this.chkModifyFlags1.UseVisualStyleBackColor = true;
            this.chkModifyFlags1.CheckedChanged += new System.EventHandler(this.chkModifyFlags1_CheckedChanged);
            // 
            // cmbModifyFlagsMode
            // 
            this.cmbModifyFlagsMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifyFlagsMode.FormattingEnabled = true;
            this.cmbModifyFlagsMode.Items.AddRange(new object[] {
            "Toggle Flags",
            "Add Flags",
            "Remove Flags"});
            this.cmbModifyFlagsMode.Location = new System.Drawing.Point(303, 51);
            this.cmbModifyFlagsMode.Name = "cmbModifyFlagsMode";
            this.cmbModifyFlagsMode.Size = new System.Drawing.Size(169, 21);
            this.cmbModifyFlagsMode.TabIndex = 4;
            this.cmbModifyFlagsMode.SelectedIndexChanged += new System.EventHandler(this.cmbModifyFlagsMode_SelectedIndexChanged);
            // 
            // lblModifyFlagsMode
            // 
            this.lblModifyFlagsMode.AutoSize = true;
            this.lblModifyFlagsMode.Location = new System.Drawing.Point(262, 54);
            this.lblModifyFlagsMode.Name = "lblModifyFlagsMode";
            this.lblModifyFlagsMode.Size = new System.Drawing.Size(37, 13);
            this.lblModifyFlagsMode.TabIndex = 3;
            this.lblModifyFlagsMode.Text = "Mode:";
            // 
            // cmbModifyFlagsFieldId
            // 
            this.cmbModifyFlagsFieldId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifyFlagsFieldId.FormattingEnabled = true;
            this.cmbModifyFlagsFieldId.Location = new System.Drawing.Point(72, 51);
            this.cmbModifyFlagsFieldId.Name = "cmbModifyFlagsFieldId";
            this.cmbModifyFlagsFieldId.Size = new System.Drawing.Size(184, 21);
            this.cmbModifyFlagsFieldId.TabIndex = 2;
            this.cmbModifyFlagsFieldId.SelectedIndexChanged += new System.EventHandler(this.cmbModifyFlagsFieldId_SelectedIndexChanged);
            // 
            // lblModifyFlagsField
            // 
            this.lblModifyFlagsField.AutoSize = true;
            this.lblModifyFlagsField.Location = new System.Drawing.Point(26, 54);
            this.lblModifyFlagsField.Name = "lblModifyFlagsField";
            this.lblModifyFlagsField.Size = new System.Drawing.Size(44, 13);
            this.lblModifyFlagsField.TabIndex = 1;
            this.lblModifyFlagsField.Text = "Field Id:";
            // 
            // lblModifyFlagsTooltip
            // 
            this.lblModifyFlagsTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModifyFlagsTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblModifyFlagsTooltip.Name = "lblModifyFlagsTooltip";
            this.lblModifyFlagsTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblModifyFlagsTooltip.TabIndex = 0;
            this.lblModifyFlagsTooltip.Text = "Toggles on the specified flags on the chosen field. Can be used on any object, bu" +
    "t the fields are different based on the type.";
            // 
            // frmCommandInterruptCasts
            // 
            this.frmCommandInterruptCasts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandInterruptCasts.Controls.Add(this.cmbInterruptCastsWithDelayed);
            this.frmCommandInterruptCasts.Controls.Add(this.lblInterruptCastsSpellId);
            this.frmCommandInterruptCasts.Controls.Add(this.lblInterruptCastsWithDelayed);
            this.frmCommandInterruptCasts.Controls.Add(this.btnInterruptCastsSpellId);
            this.frmCommandInterruptCasts.Controls.Add(this.lblInterruptCastsTooltip);
            this.frmCommandInterruptCasts.Location = new System.Drawing.Point(410, 250);
            this.frmCommandInterruptCasts.Name = "frmCommandInterruptCasts";
            this.frmCommandInterruptCasts.Size = new System.Drawing.Size(495, 332);
            this.frmCommandInterruptCasts.TabIndex = 32;
            this.frmCommandInterruptCasts.Visible = false;
            // 
            // cmbInterruptCastsWithDelayed
            // 
            this.cmbInterruptCastsWithDelayed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterruptCastsWithDelayed.FormattingEnabled = true;
            this.cmbInterruptCastsWithDelayed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbInterruptCastsWithDelayed.Location = new System.Drawing.Point(99, 90);
            this.cmbInterruptCastsWithDelayed.Name = "cmbInterruptCastsWithDelayed";
            this.cmbInterruptCastsWithDelayed.Size = new System.Drawing.Size(374, 21);
            this.cmbInterruptCastsWithDelayed.TabIndex = 5;
            this.cmbInterruptCastsWithDelayed.SelectedIndexChanged += new System.EventHandler(this.cmbInterruptCastsWithDelayed_SelectedIndexChanged);
            // 
            // lblInterruptCastsSpellId
            // 
            this.lblInterruptCastsSpellId.AutoSize = true;
            this.lblInterruptCastsSpellId.Location = new System.Drawing.Point(51, 61);
            this.lblInterruptCastsSpellId.Name = "lblInterruptCastsSpellId";
            this.lblInterruptCastsSpellId.Size = new System.Drawing.Size(45, 13);
            this.lblInterruptCastsSpellId.TabIndex = 4;
            this.lblInterruptCastsSpellId.Text = "Spell Id:";
            // 
            // lblInterruptCastsWithDelayed
            // 
            this.lblInterruptCastsWithDelayed.AutoSize = true;
            this.lblInterruptCastsWithDelayed.Location = new System.Drawing.Point(24, 93);
            this.lblInterruptCastsWithDelayed.Name = "lblInterruptCastsWithDelayed";
            this.lblInterruptCastsWithDelayed.Size = new System.Drawing.Size(72, 13);
            this.lblInterruptCastsWithDelayed.TabIndex = 3;
            this.lblInterruptCastsWithDelayed.Text = "With delayed:";
            // 
            // btnInterruptCastsSpellId
            // 
            this.btnInterruptCastsSpellId.Location = new System.Drawing.Point(99, 58);
            this.btnInterruptCastsSpellId.Name = "btnInterruptCastsSpellId";
            this.btnInterruptCastsSpellId.Size = new System.Drawing.Size(374, 23);
            this.btnInterruptCastsSpellId.TabIndex = 1;
            this.btnInterruptCastsSpellId.Text = "-NONE-";
            this.btnInterruptCastsSpellId.UseVisualStyleBackColor = true;
            this.btnInterruptCastsSpellId.Click += new System.EventHandler(this.btnInterruptCastsSpellId_Click);
            // 
            // lblInterruptCastsTooltip
            // 
            this.lblInterruptCastsTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInterruptCastsTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblInterruptCastsTooltip.Name = "lblInterruptCastsTooltip";
            this.lblInterruptCastsTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblInterruptCastsTooltip.TabIndex = 0;
            this.lblInterruptCastsTooltip.Text = "Interrupts the current spell cast. If a spell Id is provided, only that spell wil" +
    "l be interrupted.";
            // 
            // frmCommandUpdateEntry
            // 
            this.frmCommandUpdateEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandUpdateEntry.Controls.Add(this.cmbUpdateEntryTeam);
            this.frmCommandUpdateEntry.Controls.Add(this.lblUpdateEntryCreatureId);
            this.frmCommandUpdateEntry.Controls.Add(this.lblUpdateEntryTeam);
            this.frmCommandUpdateEntry.Controls.Add(this.btnUpdateEntryCreatureId);
            this.frmCommandUpdateEntry.Controls.Add(this.lblUpdateEntryTooltip);
            this.frmCommandUpdateEntry.Location = new System.Drawing.Point(410, 250);
            this.frmCommandUpdateEntry.Name = "frmCommandUpdateEntry";
            this.frmCommandUpdateEntry.Size = new System.Drawing.Size(495, 332);
            this.frmCommandUpdateEntry.TabIndex = 33;
            this.frmCommandUpdateEntry.Visible = false;
            // 
            // cmbUpdateEntryTeam
            // 
            this.cmbUpdateEntryTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateEntryTeam.FormattingEnabled = true;
            this.cmbUpdateEntryTeam.Items.AddRange(new object[] {
            "Alliance",
            "Horde"});
            this.cmbUpdateEntryTeam.Location = new System.Drawing.Point(99, 90);
            this.cmbUpdateEntryTeam.Name = "cmbUpdateEntryTeam";
            this.cmbUpdateEntryTeam.Size = new System.Drawing.Size(374, 21);
            this.cmbUpdateEntryTeam.TabIndex = 5;
            this.cmbUpdateEntryTeam.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateEntryTeam_SelectedIndexChanged);
            // 
            // lblUpdateEntryCreatureId
            // 
            this.lblUpdateEntryCreatureId.AutoSize = true;
            this.lblUpdateEntryCreatureId.Location = new System.Drawing.Point(34, 61);
            this.lblUpdateEntryCreatureId.Name = "lblUpdateEntryCreatureId";
            this.lblUpdateEntryCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblUpdateEntryCreatureId.TabIndex = 4;
            this.lblUpdateEntryCreatureId.Text = "Creature Id:";
            // 
            // lblUpdateEntryTeam
            // 
            this.lblUpdateEntryTeam.AutoSize = true;
            this.lblUpdateEntryTeam.Location = new System.Drawing.Point(59, 93);
            this.lblUpdateEntryTeam.Name = "lblUpdateEntryTeam";
            this.lblUpdateEntryTeam.Size = new System.Drawing.Size(37, 13);
            this.lblUpdateEntryTeam.TabIndex = 3;
            this.lblUpdateEntryTeam.Text = "Team:";
            // 
            // btnUpdateEntryCreatureId
            // 
            this.btnUpdateEntryCreatureId.Location = new System.Drawing.Point(99, 58);
            this.btnUpdateEntryCreatureId.Name = "btnUpdateEntryCreatureId";
            this.btnUpdateEntryCreatureId.Size = new System.Drawing.Size(374, 23);
            this.btnUpdateEntryCreatureId.TabIndex = 1;
            this.btnUpdateEntryCreatureId.Text = "-NONE-";
            this.btnUpdateEntryCreatureId.UseVisualStyleBackColor = true;
            this.btnUpdateEntryCreatureId.Click += new System.EventHandler(this.btnUpdateEntryCreatureId_Click);
            // 
            // lblUpdateEntryTooltip
            // 
            this.lblUpdateEntryTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpdateEntryTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblUpdateEntryTooltip.Name = "lblUpdateEntryTooltip";
            this.lblUpdateEntryTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblUpdateEntryTooltip.TabIndex = 0;
            this.lblUpdateEntryTooltip.Text = "Temporarily changes the creature\'s entry, but preserves the same AI. The team set" +
    "ting determines which display Id will be used if there is a different one for ea" +
    "ch faction.";
            // 
            // frmCommandSetStandState
            // 
            this.frmCommandSetStandState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetStandState.Controls.Add(this.cmbSetStandState);
            this.frmCommandSetStandState.Controls.Add(this.lblSetStandState);
            this.frmCommandSetStandState.Controls.Add(this.lblSetStandStateTooltip);
            this.frmCommandSetStandState.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetStandState.Name = "frmCommandSetStandState";
            this.frmCommandSetStandState.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetStandState.TabIndex = 34;
            this.frmCommandSetStandState.Visible = false;
            // 
            // cmbSetStandState
            // 
            this.cmbSetStandState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetStandState.FormattingEnabled = true;
            this.cmbSetStandState.Items.AddRange(new object[] {
            "UNIT_STAND_STATE_STAND",
            "UNIT_STAND_STATE_SIT",
            "UNIT_STAND_STATE_SIT_CHAIR",
            "UNIT_STAND_STATE_SLEEP",
            "UNIT_STAND_STATE_SIT_LOW_CHAIR",
            "UNIT_STAND_STATE_SIT_MEDIUM_CHAIR",
            "UNIT_STAND_STATE_SIT_HIGH_CHAIR",
            "UNIT_STAND_STATE_DEAD",
            "UNIT_STAND_STATE_KNEEL"});
            this.cmbSetStandState.Location = new System.Drawing.Point(99, 58);
            this.cmbSetStandState.Name = "cmbSetStandState";
            this.cmbSetStandState.Size = new System.Drawing.Size(374, 21);
            this.cmbSetStandState.TabIndex = 2;
            this.cmbSetStandState.SelectedIndexChanged += new System.EventHandler(this.cmbSetStandState_SelectedIndexChanged);
            // 
            // lblSetStandState
            // 
            this.lblSetStandState.AutoSize = true;
            this.lblSetStandState.Location = new System.Drawing.Point(31, 61);
            this.lblSetStandState.Name = "lblSetStandState";
            this.lblSetStandState.Size = new System.Drawing.Size(66, 13);
            this.lblSetStandState.TabIndex = 1;
            this.lblSetStandState.Text = "Stand State:";
            // 
            // lblSetStandStateTooltip
            // 
            this.lblSetStandStateTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetStandStateTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetStandStateTooltip.Name = "lblSetStandStateTooltip";
            this.lblSetStandStateTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetStandStateTooltip.TabIndex = 0;
            this.lblSetStandStateTooltip.Text = "Changes the source Unit\'s current stand state.";
            // 
            // frmCommandModifyThreat
            // 
            this.frmCommandModifyThreat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandModifyThreat.Controls.Add(this.lblModifyThreatPercent);
            this.frmCommandModifyThreat.Controls.Add(this.txtModifyThreatPercent);
            this.frmCommandModifyThreat.Controls.Add(this.cmbModifyThreatTarget);
            this.frmCommandModifyThreat.Controls.Add(this.lblModifyThreatTarget);
            this.frmCommandModifyThreat.Controls.Add(this.lblModifyThreatTooltip);
            this.frmCommandModifyThreat.Location = new System.Drawing.Point(410, 250);
            this.frmCommandModifyThreat.Name = "frmCommandModifyThreat";
            this.frmCommandModifyThreat.Size = new System.Drawing.Size(495, 332);
            this.frmCommandModifyThreat.TabIndex = 35;
            this.frmCommandModifyThreat.Visible = false;
            // 
            // lblModifyThreatPercent
            // 
            this.lblModifyThreatPercent.AutoSize = true;
            this.lblModifyThreatPercent.Location = new System.Drawing.Point(47, 90);
            this.lblModifyThreatPercent.Name = "lblModifyThreatPercent";
            this.lblModifyThreatPercent.Size = new System.Drawing.Size(47, 13);
            this.lblModifyThreatPercent.TabIndex = 4;
            this.lblModifyThreatPercent.Text = "Percent:";
            // 
            // txtModifyThreatPercent
            // 
            this.txtModifyThreatPercent.Location = new System.Drawing.Point(99, 88);
            this.txtModifyThreatPercent.Name = "txtModifyThreatPercent";
            this.txtModifyThreatPercent.Size = new System.Drawing.Size(374, 20);
            this.txtModifyThreatPercent.TabIndex = 3;
            this.txtModifyThreatPercent.Leave += new System.EventHandler(this.txtModifyThreatPercent_Leave);
            // 
            // cmbModifyThreatTarget
            // 
            this.cmbModifyThreatTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifyThreatTarget.FormattingEnabled = true;
            this.cmbModifyThreatTarget.Items.AddRange(new object[] {
            "Provided Target",
            "Current Victim",
            "All Attackers"});
            this.cmbModifyThreatTarget.Location = new System.Drawing.Point(99, 58);
            this.cmbModifyThreatTarget.Name = "cmbModifyThreatTarget";
            this.cmbModifyThreatTarget.Size = new System.Drawing.Size(374, 21);
            this.cmbModifyThreatTarget.TabIndex = 2;
            this.cmbModifyThreatTarget.SelectedIndexChanged += new System.EventHandler(this.cmbModifyThreatTarget_SelectedIndexChanged);
            // 
            // lblModifyThreatTarget
            // 
            this.lblModifyThreatTarget.AutoSize = true;
            this.lblModifyThreatTarget.Location = new System.Drawing.Point(53, 61);
            this.lblModifyThreatTarget.Name = "lblModifyThreatTarget";
            this.lblModifyThreatTarget.Size = new System.Drawing.Size(41, 13);
            this.lblModifyThreatTarget.TabIndex = 1;
            this.lblModifyThreatTarget.Text = "Target:";
            // 
            // lblModifyThreatTooltip
            // 
            this.lblModifyThreatTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModifyThreatTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblModifyThreatTooltip.Name = "lblModifyThreatTooltip";
            this.lblModifyThreatTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblModifyThreatTooltip.TabIndex = 0;
            this.lblModifyThreatTooltip.Text = "Modifies threat for the selected targets by the specified percent.";
            // 
            // frmCommandSendTaxiPath
            // 
            this.frmCommandSendTaxiPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSendTaxiPath.Controls.Add(this.lblSendTaxiPath);
            this.frmCommandSendTaxiPath.Controls.Add(this.txtSendTaxiPath);
            this.frmCommandSendTaxiPath.Controls.Add(this.btnSendTaxiPathId);
            this.frmCommandSendTaxiPath.Controls.Add(this.lblSendTaxiPathId);
            this.frmCommandSendTaxiPath.Controls.Add(this.lblSendTaxiPathTooltip);
            this.frmCommandSendTaxiPath.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSendTaxiPath.Name = "frmCommandSendTaxiPath";
            this.frmCommandSendTaxiPath.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSendTaxiPath.TabIndex = 36;
            this.frmCommandSendTaxiPath.Visible = false;
            // 
            // lblSendTaxiPath
            // 
            this.lblSendTaxiPath.AutoSize = true;
            this.lblSendTaxiPath.Location = new System.Drawing.Point(158, 54);
            this.lblSendTaxiPath.Name = "lblSendTaxiPath";
            this.lblSendTaxiPath.Size = new System.Drawing.Size(32, 13);
            this.lblSendTaxiPath.TabIndex = 4;
            this.lblSendTaxiPath.Text = "Path:";
            // 
            // txtSendTaxiPath
            // 
            this.txtSendTaxiPath.Location = new System.Drawing.Point(153, 73);
            this.txtSendTaxiPath.Name = "txtSendTaxiPath";
            this.txtSendTaxiPath.ReadOnly = true;
            this.txtSendTaxiPath.Size = new System.Drawing.Size(320, 20);
            this.txtSendTaxiPath.TabIndex = 3;
            // 
            // btnSendTaxiPathId
            // 
            this.btnSendTaxiPathId.Location = new System.Drawing.Point(22, 71);
            this.btnSendTaxiPathId.Name = "btnSendTaxiPathId";
            this.btnSendTaxiPathId.Size = new System.Drawing.Size(122, 23);
            this.btnSendTaxiPathId.TabIndex = 2;
            this.btnSendTaxiPathId.Text = "-NONE-";
            this.btnSendTaxiPathId.UseVisualStyleBackColor = true;
            this.btnSendTaxiPathId.Click += new System.EventHandler(this.btnSendTaxiPathId_Click);
            // 
            // lblSendTaxiPathId
            // 
            this.lblSendTaxiPathId.AutoSize = true;
            this.lblSendTaxiPathId.Location = new System.Drawing.Point(28, 54);
            this.lblSendTaxiPathId.Name = "lblSendTaxiPathId";
            this.lblSendTaxiPathId.Size = new System.Drawing.Size(19, 13);
            this.lblSendTaxiPathId.TabIndex = 1;
            this.lblSendTaxiPathId.Text = "Id:";
            // 
            // lblSendTaxiPathTooltip
            // 
            this.lblSendTaxiPathTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSendTaxiPathTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSendTaxiPathTooltip.Name = "lblSendTaxiPathTooltip";
            this.lblSendTaxiPathTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSendTaxiPathTooltip.TabIndex = 0;
            this.lblSendTaxiPathTooltip.Text = "Sends the Player on the specified taxi path.";
            // 
            // frmCommandTerminateScript
            // 
            this.frmCommandTerminateScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTerminateScript.Controls.Add(this.lblTerminateScriptCondition);
            this.frmCommandTerminateScript.Controls.Add(this.cmbTerminateScriptCondition);
            this.frmCommandTerminateScript.Controls.Add(this.lblTerminateScriptCreatureId);
            this.frmCommandTerminateScript.Controls.Add(this.lblTerminateScriptSearchRadius);
            this.frmCommandTerminateScript.Controls.Add(this.txtTerminateScriptSearchRadius);
            this.frmCommandTerminateScript.Controls.Add(this.btnTerminateScriptCreatureId);
            this.frmCommandTerminateScript.Controls.Add(this.lblTerminateScriptTooltip);
            this.frmCommandTerminateScript.Location = new System.Drawing.Point(410, 250);
            this.frmCommandTerminateScript.Name = "frmCommandTerminateScript";
            this.frmCommandTerminateScript.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTerminateScript.TabIndex = 37;
            this.frmCommandTerminateScript.Visible = false;
            // 
            // lblTerminateScriptCondition
            // 
            this.lblTerminateScriptCondition.AutoSize = true;
            this.lblTerminateScriptCondition.Location = new System.Drawing.Point(60, 134);
            this.lblTerminateScriptCondition.Name = "lblTerminateScriptCondition";
            this.lblTerminateScriptCondition.Size = new System.Drawing.Size(54, 13);
            this.lblTerminateScriptCondition.TabIndex = 6;
            this.lblTerminateScriptCondition.Text = "Condition:";
            // 
            // cmbTerminateScriptCondition
            // 
            this.cmbTerminateScriptCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerminateScriptCondition.FormattingEnabled = true;
            this.cmbTerminateScriptCondition.Items.AddRange(new object[] {
            "Creature Not Found",
            "Creature Is Found"});
            this.cmbTerminateScriptCondition.Location = new System.Drawing.Point(118, 131);
            this.cmbTerminateScriptCondition.Name = "cmbTerminateScriptCondition";
            this.cmbTerminateScriptCondition.Size = new System.Drawing.Size(355, 21);
            this.cmbTerminateScriptCondition.TabIndex = 5;
            this.cmbTerminateScriptCondition.SelectedIndexChanged += new System.EventHandler(this.cmbTerminateScriptCondition_SelectedIndexChanged);
            // 
            // lblTerminateScriptCreatureId
            // 
            this.lblTerminateScriptCreatureId.AutoSize = true;
            this.lblTerminateScriptCreatureId.Location = new System.Drawing.Point(52, 71);
            this.lblTerminateScriptCreatureId.Name = "lblTerminateScriptCreatureId";
            this.lblTerminateScriptCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblTerminateScriptCreatureId.TabIndex = 4;
            this.lblTerminateScriptCreatureId.Text = "Creature Id:";
            // 
            // lblTerminateScriptSearchRadius
            // 
            this.lblTerminateScriptSearchRadius.AutoSize = true;
            this.lblTerminateScriptSearchRadius.Location = new System.Drawing.Point(34, 102);
            this.lblTerminateScriptSearchRadius.Name = "lblTerminateScriptSearchRadius";
            this.lblTerminateScriptSearchRadius.Size = new System.Drawing.Size(80, 13);
            this.lblTerminateScriptSearchRadius.TabIndex = 3;
            this.lblTerminateScriptSearchRadius.Text = "Search Radius:";
            // 
            // txtTerminateScriptSearchRadius
            // 
            this.txtTerminateScriptSearchRadius.Location = new System.Drawing.Point(118, 100);
            this.txtTerminateScriptSearchRadius.Name = "txtTerminateScriptSearchRadius";
            this.txtTerminateScriptSearchRadius.Size = new System.Drawing.Size(355, 20);
            this.txtTerminateScriptSearchRadius.TabIndex = 2;
            this.txtTerminateScriptSearchRadius.Leave += new System.EventHandler(this.txtTerminateScriptSearchRadius_Leave);
            // 
            // btnTerminateScriptCreatureId
            // 
            this.btnTerminateScriptCreatureId.Location = new System.Drawing.Point(118, 66);
            this.btnTerminateScriptCreatureId.Name = "btnTerminateScriptCreatureId";
            this.btnTerminateScriptCreatureId.Size = new System.Drawing.Size(355, 23);
            this.btnTerminateScriptCreatureId.TabIndex = 1;
            this.btnTerminateScriptCreatureId.Text = "-NONE-";
            this.btnTerminateScriptCreatureId.UseVisualStyleBackColor = true;
            this.btnTerminateScriptCreatureId.Click += new System.EventHandler(this.btnTerminateScriptCreatureId_Click);
            // 
            // lblTerminateScriptTooltip
            // 
            this.lblTerminateScriptTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTerminateScriptTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblTerminateScriptTooltip.Name = "lblTerminateScriptTooltip";
            this.lblTerminateScriptTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblTerminateScriptTooltip.TabIndex = 0;
            this.lblTerminateScriptTooltip.Text = "Terminates further execution of the same script if a Creature with the provided I" +
    "d is not found within the specified range.";
            // 
            // frmCommandTerminateCondition
            // 
            this.frmCommandTerminateCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTerminateCondition.Controls.Add(this.btnTerminateConditionQuest);
            this.frmCommandTerminateCondition.Controls.Add(this.lblTerminateConditionRule);
            this.frmCommandTerminateCondition.Controls.Add(this.cmbTerminateConditionRule);
            this.frmCommandTerminateCondition.Controls.Add(this.lblTerminateConditionId);
            this.frmCommandTerminateCondition.Controls.Add(this.lblTerminateConditionQuestId);
            this.frmCommandTerminateCondition.Controls.Add(this.btnTerminateConditionId);
            this.frmCommandTerminateCondition.Controls.Add(this.lblTerminateConditionTooltip);
            this.frmCommandTerminateCondition.Location = new System.Drawing.Point(410, 250);
            this.frmCommandTerminateCondition.Name = "frmCommandTerminateCondition";
            this.frmCommandTerminateCondition.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTerminateCondition.TabIndex = 38;
            this.frmCommandTerminateCondition.Visible = false;
            // 
            // btnTerminateConditionQuest
            // 
            this.btnTerminateConditionQuest.Location = new System.Drawing.Point(118, 100);
            this.btnTerminateConditionQuest.Name = "btnTerminateConditionQuest";
            this.btnTerminateConditionQuest.Size = new System.Drawing.Size(355, 23);
            this.btnTerminateConditionQuest.TabIndex = 7;
            this.btnTerminateConditionQuest.Text = "-NONE-";
            this.btnTerminateConditionQuest.UseVisualStyleBackColor = true;
            this.btnTerminateConditionQuest.Click += new System.EventHandler(this.btnTerminateConditionQuest_Click);
            // 
            // lblTerminateConditionRule
            // 
            this.lblTerminateConditionRule.AutoSize = true;
            this.lblTerminateConditionRule.Location = new System.Drawing.Point(82, 134);
            this.lblTerminateConditionRule.Name = "lblTerminateConditionRule";
            this.lblTerminateConditionRule.Size = new System.Drawing.Size(32, 13);
            this.lblTerminateConditionRule.TabIndex = 6;
            this.lblTerminateConditionRule.Text = "Rule:";
            // 
            // cmbTerminateConditionRule
            // 
            this.cmbTerminateConditionRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerminateConditionRule.FormattingEnabled = true;
            this.cmbTerminateConditionRule.Items.AddRange(new object[] {
            "Terminate when True",
            "Terminate when False"});
            this.cmbTerminateConditionRule.Location = new System.Drawing.Point(118, 131);
            this.cmbTerminateConditionRule.Name = "cmbTerminateConditionRule";
            this.cmbTerminateConditionRule.Size = new System.Drawing.Size(355, 21);
            this.cmbTerminateConditionRule.TabIndex = 5;
            this.cmbTerminateConditionRule.SelectedIndexChanged += new System.EventHandler(this.cmbTerminateConditionRule_SelectedIndexChanged);
            // 
            // lblTerminateConditionId
            // 
            this.lblTerminateConditionId.AutoSize = true;
            this.lblTerminateConditionId.Location = new System.Drawing.Point(48, 71);
            this.lblTerminateConditionId.Name = "lblTerminateConditionId";
            this.lblTerminateConditionId.Size = new System.Drawing.Size(66, 13);
            this.lblTerminateConditionId.TabIndex = 4;
            this.lblTerminateConditionId.Text = "Condition Id:";
            // 
            // lblTerminateConditionQuestId
            // 
            this.lblTerminateConditionQuestId.AutoSize = true;
            this.lblTerminateConditionQuestId.Location = new System.Drawing.Point(64, 102);
            this.lblTerminateConditionQuestId.Name = "lblTerminateConditionQuestId";
            this.lblTerminateConditionQuestId.Size = new System.Drawing.Size(50, 13);
            this.lblTerminateConditionQuestId.TabIndex = 3;
            this.lblTerminateConditionQuestId.Text = "Quest Id:";
            // 
            // btnTerminateConditionId
            // 
            this.btnTerminateConditionId.Location = new System.Drawing.Point(118, 66);
            this.btnTerminateConditionId.Name = "btnTerminateConditionId";
            this.btnTerminateConditionId.Size = new System.Drawing.Size(355, 23);
            this.btnTerminateConditionId.TabIndex = 1;
            this.btnTerminateConditionId.Text = "-NONE-";
            this.btnTerminateConditionId.UseVisualStyleBackColor = true;
            this.btnTerminateConditionId.Click += new System.EventHandler(this.btnTerminateConditionId_Click);
            // 
            // lblTerminateConditionTooltip
            // 
            this.lblTerminateConditionTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTerminateConditionTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblTerminateConditionTooltip.Name = "lblTerminateConditionTooltip";
            this.lblTerminateConditionTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblTerminateConditionTooltip.TabIndex = 0;
            this.lblTerminateConditionTooltip.Text = "Terminates further execution of the same script if the specified condition is sat" +
    "isfied. If a quest Id is provided, the quest gets marked as failed for the invol" +
    "ved players.";
            // 
            // frmCommandSetHomePosition
            // 
            this.frmCommandSetHomePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionO);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionZ);
            this.frmCommandSetHomePosition.Controls.Add(this.txtSetHomePositionO);
            this.frmCommandSetHomePosition.Controls.Add(this.txtSetHomePositionZ);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionY);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionX);
            this.frmCommandSetHomePosition.Controls.Add(this.txtSetHomePositionY);
            this.frmCommandSetHomePosition.Controls.Add(this.txtSetHomePositionX);
            this.frmCommandSetHomePosition.Controls.Add(this.cmbSetHomePositionMode);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionMode);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionTooltip);
            this.frmCommandSetHomePosition.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetHomePosition.Name = "frmCommandSetHomePosition";
            this.frmCommandSetHomePosition.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetHomePosition.TabIndex = 39;
            this.frmCommandSetHomePosition.Visible = false;
            // 
            // lblSetHomePositionO
            // 
            this.lblSetHomePositionO.AutoSize = true;
            this.lblSetHomePositionO.Location = new System.Drawing.Point(264, 124);
            this.lblSetHomePositionO.Name = "lblSetHomePositionO";
            this.lblSetHomePositionO.Size = new System.Drawing.Size(61, 13);
            this.lblSetHomePositionO.TabIndex = 10;
            this.lblSetHomePositionO.Text = "Orientation:";
            // 
            // lblSetHomePositionZ
            // 
            this.lblSetHomePositionZ.AutoSize = true;
            this.lblSetHomePositionZ.Location = new System.Drawing.Point(26, 124);
            this.lblSetHomePositionZ.Name = "lblSetHomePositionZ";
            this.lblSetHomePositionZ.Size = new System.Drawing.Size(70, 13);
            this.lblSetHomePositionZ.TabIndex = 9;
            this.lblSetHomePositionZ.Text = "Z coordinate:";
            // 
            // txtSetHomePositionO
            // 
            this.txtSetHomePositionO.Location = new System.Drawing.Point(328, 121);
            this.txtSetHomePositionO.Name = "txtSetHomePositionO";
            this.txtSetHomePositionO.Size = new System.Drawing.Size(145, 20);
            this.txtSetHomePositionO.TabIndex = 8;
            this.txtSetHomePositionO.Leave += new System.EventHandler(this.txtSetHomePositionO_Leave);
            // 
            // txtSetHomePositionZ
            // 
            this.txtSetHomePositionZ.Location = new System.Drawing.Point(99, 121);
            this.txtSetHomePositionZ.Name = "txtSetHomePositionZ";
            this.txtSetHomePositionZ.Size = new System.Drawing.Size(145, 20);
            this.txtSetHomePositionZ.TabIndex = 7;
            this.txtSetHomePositionZ.Leave += new System.EventHandler(this.txtSetHomePositionZ_Leave);
            // 
            // lblSetHomePositionY
            // 
            this.lblSetHomePositionY.AutoSize = true;
            this.lblSetHomePositionY.Location = new System.Drawing.Point(255, 93);
            this.lblSetHomePositionY.Name = "lblSetHomePositionY";
            this.lblSetHomePositionY.Size = new System.Drawing.Size(70, 13);
            this.lblSetHomePositionY.TabIndex = 6;
            this.lblSetHomePositionY.Text = "Y coordinate:";
            // 
            // lblSetHomePositionX
            // 
            this.lblSetHomePositionX.AutoSize = true;
            this.lblSetHomePositionX.Location = new System.Drawing.Point(26, 93);
            this.lblSetHomePositionX.Name = "lblSetHomePositionX";
            this.lblSetHomePositionX.Size = new System.Drawing.Size(70, 13);
            this.lblSetHomePositionX.TabIndex = 5;
            this.lblSetHomePositionX.Text = "X coordinate:";
            // 
            // txtSetHomePositionY
            // 
            this.txtSetHomePositionY.Location = new System.Drawing.Point(328, 90);
            this.txtSetHomePositionY.Name = "txtSetHomePositionY";
            this.txtSetHomePositionY.Size = new System.Drawing.Size(145, 20);
            this.txtSetHomePositionY.TabIndex = 4;
            this.txtSetHomePositionY.Leave += new System.EventHandler(this.txtSetHomePositionY_Leave);
            // 
            // txtSetHomePositionX
            // 
            this.txtSetHomePositionX.Location = new System.Drawing.Point(99, 90);
            this.txtSetHomePositionX.Name = "txtSetHomePositionX";
            this.txtSetHomePositionX.Size = new System.Drawing.Size(145, 20);
            this.txtSetHomePositionX.TabIndex = 3;
            this.txtSetHomePositionX.Leave += new System.EventHandler(this.txtSetHomePositionX_Leave);
            // 
            // cmbSetHomePositionMode
            // 
            this.cmbSetHomePositionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetHomePositionMode.FormattingEnabled = true;
            this.cmbSetHomePositionMode.Items.AddRange(new object[] {
            "Provided coordinates",
            "Current position"});
            this.cmbSetHomePositionMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetHomePositionMode.Name = "cmbSetHomePositionMode";
            this.cmbSetHomePositionMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetHomePositionMode.TabIndex = 2;
            this.cmbSetHomePositionMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetHomePositionMode_SelectedIndexChanged);
            // 
            // lblSetHomePositionMode
            // 
            this.lblSetHomePositionMode.AutoSize = true;
            this.lblSetHomePositionMode.Location = new System.Drawing.Point(59, 61);
            this.lblSetHomePositionMode.Name = "lblSetHomePositionMode";
            this.lblSetHomePositionMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetHomePositionMode.TabIndex = 1;
            this.lblSetHomePositionMode.Text = "Mode:";
            // 
            // lblSetHomePositionTooltip
            // 
            this.lblSetHomePositionTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetHomePositionTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetHomePositionTooltip.Name = "lblSetHomePositionTooltip";
            this.lblSetHomePositionTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetHomePositionTooltip.TabIndex = 0;
            this.lblSetHomePositionTooltip.Text = "Sets the source Creature\'s home position to the specified coordinates.";
            // 
            // frmCommandSetFacing
            // 
            this.frmCommandSetFacing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetFacing.Controls.Add(this.lblSetFacingOrientation);
            this.frmCommandSetFacing.Controls.Add(this.txtSetFacingOrientation);
            this.frmCommandSetFacing.Controls.Add(this.cmbSetFacingMode);
            this.frmCommandSetFacing.Controls.Add(this.lblSetFacingMode);
            this.frmCommandSetFacing.Controls.Add(this.lblSetFacingTooltip);
            this.frmCommandSetFacing.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetFacing.Name = "frmCommandSetFacing";
            this.frmCommandSetFacing.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetFacing.TabIndex = 40;
            this.frmCommandSetFacing.Visible = false;
            // 
            // lblSetFacingOrientation
            // 
            this.lblSetFacingOrientation.AutoSize = true;
            this.lblSetFacingOrientation.Location = new System.Drawing.Point(35, 93);
            this.lblSetFacingOrientation.Name = "lblSetFacingOrientation";
            this.lblSetFacingOrientation.Size = new System.Drawing.Size(61, 13);
            this.lblSetFacingOrientation.TabIndex = 5;
            this.lblSetFacingOrientation.Text = "Orientation:";
            // 
            // txtSetFacingOrientation
            // 
            this.txtSetFacingOrientation.Location = new System.Drawing.Point(99, 90);
            this.txtSetFacingOrientation.Name = "txtSetFacingOrientation";
            this.txtSetFacingOrientation.Size = new System.Drawing.Size(374, 20);
            this.txtSetFacingOrientation.TabIndex = 3;
            this.txtSetFacingOrientation.Leave += new System.EventHandler(this.txtSetFacingOrientation_Leave);
            // 
            // cmbSetFacingMode
            // 
            this.cmbSetFacingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetFacingMode.FormattingEnabled = true;
            this.cmbSetFacingMode.Items.AddRange(new object[] {
            "Face provided target",
            "Use orientation value"});
            this.cmbSetFacingMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetFacingMode.Name = "cmbSetFacingMode";
            this.cmbSetFacingMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetFacingMode.TabIndex = 2;
            this.cmbSetFacingMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetFacingMode_SelectedIndexChanged);
            // 
            // lblSetFacingMode
            // 
            this.lblSetFacingMode.AutoSize = true;
            this.lblSetFacingMode.Location = new System.Drawing.Point(59, 61);
            this.lblSetFacingMode.Name = "lblSetFacingMode";
            this.lblSetFacingMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetFacingMode.TabIndex = 1;
            this.lblSetFacingMode.Text = "Mode:";
            // 
            // lblSetFacingTooltip
            // 
            this.lblSetFacingTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetFacingTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetFacingTooltip.Name = "lblSetFacingTooltip";
            this.lblSetFacingTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetFacingTooltip.TabIndex = 0;
            this.lblSetFacingTooltip.Text = "Changes the source Unit\'s orientation to either the specified value, or to face t" +
    "he target WorldObject.";
            // 
            // frmCommandMeetingStone
            // 
            this.frmCommandMeetingStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandMeetingStone.Controls.Add(this.btnMeetingStoneAreaId);
            this.frmCommandMeetingStone.Controls.Add(this.lblMeetingStoneAreaId);
            this.frmCommandMeetingStone.Controls.Add(this.lblMeetingStoneTooltip);
            this.frmCommandMeetingStone.Location = new System.Drawing.Point(410, 250);
            this.frmCommandMeetingStone.Name = "frmCommandMeetingStone";
            this.frmCommandMeetingStone.Size = new System.Drawing.Size(495, 332);
            this.frmCommandMeetingStone.TabIndex = 41;
            this.frmCommandMeetingStone.Visible = false;
            // 
            // btnMeetingStoneAreaId
            // 
            this.btnMeetingStoneAreaId.Location = new System.Drawing.Point(69, 57);
            this.btnMeetingStoneAreaId.Name = "btnMeetingStoneAreaId";
            this.btnMeetingStoneAreaId.Size = new System.Drawing.Size(404, 23);
            this.btnMeetingStoneAreaId.TabIndex = 2;
            this.btnMeetingStoneAreaId.Text = "-NONE-";
            this.btnMeetingStoneAreaId.UseVisualStyleBackColor = true;
            this.btnMeetingStoneAreaId.Click += new System.EventHandler(this.btnMeetingStoneAreaId_Click);
            // 
            // lblMeetingStoneAreaId
            // 
            this.lblMeetingStoneAreaId.AutoSize = true;
            this.lblMeetingStoneAreaId.Location = new System.Drawing.Point(23, 61);
            this.lblMeetingStoneAreaId.Name = "lblMeetingStoneAreaId";
            this.lblMeetingStoneAreaId.Size = new System.Drawing.Size(44, 13);
            this.lblMeetingStoneAreaId.TabIndex = 1;
            this.lblMeetingStoneAreaId.Text = "Area Id:";
            // 
            // lblMeetingStoneTooltip
            // 
            this.lblMeetingStoneTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMeetingStoneTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblMeetingStoneTooltip.Name = "lblMeetingStoneTooltip";
            this.lblMeetingStoneTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblMeetingStoneTooltip.TabIndex = 0;
            this.lblMeetingStoneTooltip.Text = "The source Player gets put into a queue for the chosen dungeon.";
            // 
            // frmCommandSetData
            // 
            this.frmCommandSetData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetData.Controls.Add(this.lblSetDataValue);
            this.frmCommandSetData.Controls.Add(this.txtSetDataValue);
            this.frmCommandSetData.Controls.Add(this.lblSetDataField);
            this.frmCommandSetData.Controls.Add(this.txtSetDataField);
            this.frmCommandSetData.Controls.Add(this.cmbSetDataMode);
            this.frmCommandSetData.Controls.Add(this.lblSetDataMode);
            this.frmCommandSetData.Controls.Add(this.lblSetDataTooltip);
            this.frmCommandSetData.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetData.Name = "frmCommandSetData";
            this.frmCommandSetData.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetData.TabIndex = 42;
            this.frmCommandSetData.Visible = false;
            // 
            // lblSetDataValue
            // 
            this.lblSetDataValue.AutoSize = true;
            this.lblSetDataValue.Location = new System.Drawing.Point(63, 124);
            this.lblSetDataValue.Name = "lblSetDataValue";
            this.lblSetDataValue.Size = new System.Drawing.Size(33, 13);
            this.lblSetDataValue.TabIndex = 7;
            this.lblSetDataValue.Text = "Data:";
            // 
            // txtSetDataValue
            // 
            this.txtSetDataValue.Location = new System.Drawing.Point(99, 121);
            this.txtSetDataValue.Name = "txtSetDataValue";
            this.txtSetDataValue.Size = new System.Drawing.Size(374, 20);
            this.txtSetDataValue.TabIndex = 6;
            this.txtSetDataValue.Leave += new System.EventHandler(this.txtSetDataValue_Leave);
            // 
            // lblSetDataField
            // 
            this.lblSetDataField.AutoSize = true;
            this.lblSetDataField.Location = new System.Drawing.Point(64, 93);
            this.lblSetDataField.Name = "lblSetDataField";
            this.lblSetDataField.Size = new System.Drawing.Size(32, 13);
            this.lblSetDataField.TabIndex = 5;
            this.lblSetDataField.Text = "Field:";
            // 
            // txtSetDataField
            // 
            this.txtSetDataField.Location = new System.Drawing.Point(99, 90);
            this.txtSetDataField.Name = "txtSetDataField";
            this.txtSetDataField.Size = new System.Drawing.Size(374, 20);
            this.txtSetDataField.TabIndex = 3;
            this.txtSetDataField.Leave += new System.EventHandler(this.txtSetDataField_Leave);
            // 
            // cmbSetDataMode
            // 
            this.cmbSetDataMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetDataMode.FormattingEnabled = true;
            this.cmbSetDataMode.Items.AddRange(new object[] {
            "Raw Value",
            "Increment Current Value",
            "Decrement Current Value"});
            this.cmbSetDataMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetDataMode.Name = "cmbSetDataMode";
            this.cmbSetDataMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetDataMode.TabIndex = 2;
            this.cmbSetDataMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetDataMode_SelectedIndexChanged);
            // 
            // lblSetDataMode
            // 
            this.lblSetDataMode.AutoSize = true;
            this.lblSetDataMode.Location = new System.Drawing.Point(59, 61);
            this.lblSetDataMode.Name = "lblSetDataMode";
            this.lblSetDataMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetDataMode.TabIndex = 1;
            this.lblSetDataMode.Text = "Mode:";
            // 
            // lblSetDataTooltip
            // 
            this.lblSetDataTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetDataTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetDataTooltip.Name = "lblSetDataTooltip";
            this.lblSetDataTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetDataTooltip.TabIndex = 0;
            this.lblSetDataTooltip.Text = "Saves data to the instance script of the map.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(830, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCommandStartScript
            // 
            this.frmCommandStartScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandStartScript.Controls.Add(this.btnStartScriptEdit4);
            this.frmCommandStartScript.Controls.Add(this.btnStartScriptEdit3);
            this.frmCommandStartScript.Controls.Add(this.btnStartScriptEdit2);
            this.frmCommandStartScript.Controls.Add(this.btnStartScriptEdit1);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptChance4);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptId4);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptChance3);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptId3);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptChance2);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptId2);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptChance1);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptId1);
            this.frmCommandStartScript.Controls.Add(this.lblStartScriptChance);
            this.frmCommandStartScript.Controls.Add(this.lblStartScriptId);
            this.frmCommandStartScript.Controls.Add(this.lblStartScriptTooltip);
            this.frmCommandStartScript.Location = new System.Drawing.Point(410, 250);
            this.frmCommandStartScript.Name = "frmCommandStartScript";
            this.frmCommandStartScript.Size = new System.Drawing.Size(495, 332);
            this.frmCommandStartScript.TabIndex = 44;
            this.frmCommandStartScript.Visible = false;
            // 
            // btnStartScriptEdit4
            // 
            this.btnStartScriptEdit4.Location = new System.Drawing.Point(428, 172);
            this.btnStartScriptEdit4.Name = "btnStartScriptEdit4";
            this.btnStartScriptEdit4.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptEdit4.TabIndex = 24;
            this.btnStartScriptEdit4.Text = "Edit";
            this.btnStartScriptEdit4.UseVisualStyleBackColor = true;
            this.btnStartScriptEdit4.Click += new System.EventHandler(this.btnStartScriptEdit4_Click);
            // 
            // btnStartScriptEdit3
            // 
            this.btnStartScriptEdit3.Location = new System.Drawing.Point(428, 143);
            this.btnStartScriptEdit3.Name = "btnStartScriptEdit3";
            this.btnStartScriptEdit3.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptEdit3.TabIndex = 23;
            this.btnStartScriptEdit3.Text = "Edit";
            this.btnStartScriptEdit3.UseVisualStyleBackColor = true;
            this.btnStartScriptEdit3.Click += new System.EventHandler(this.btnStartScriptEdit3_Click);
            // 
            // btnStartScriptEdit2
            // 
            this.btnStartScriptEdit2.Location = new System.Drawing.Point(428, 114);
            this.btnStartScriptEdit2.Name = "btnStartScriptEdit2";
            this.btnStartScriptEdit2.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptEdit2.TabIndex = 22;
            this.btnStartScriptEdit2.Text = "Edit";
            this.btnStartScriptEdit2.UseVisualStyleBackColor = true;
            this.btnStartScriptEdit2.Click += new System.EventHandler(this.btnStartScriptEdit2_Click);
            // 
            // btnStartScriptEdit1
            // 
            this.btnStartScriptEdit1.Location = new System.Drawing.Point(429, 85);
            this.btnStartScriptEdit1.Name = "btnStartScriptEdit1";
            this.btnStartScriptEdit1.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptEdit1.TabIndex = 21;
            this.btnStartScriptEdit1.Text = "Edit";
            this.btnStartScriptEdit1.UseVisualStyleBackColor = true;
            this.btnStartScriptEdit1.Click += new System.EventHandler(this.btnStartScriptEdit1_Click);
            // 
            // txtStartScriptChance4
            // 
            this.txtStartScriptChance4.Location = new System.Drawing.Point(225, 172);
            this.txtStartScriptChance4.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptChance4.Name = "txtStartScriptChance4";
            this.txtStartScriptChance4.Size = new System.Drawing.Size(190, 20);
            this.txtStartScriptChance4.TabIndex = 20;
            this.txtStartScriptChance4.Leave += new System.EventHandler(this.txtStartScriptChance4_Leave);
            // 
            // txtStartScriptId4
            // 
            this.txtStartScriptId4.Location = new System.Drawing.Point(19, 172);
            this.txtStartScriptId4.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptId4.Name = "txtStartScriptId4";
            this.txtStartScriptId4.Size = new System.Drawing.Size(191, 20);
            this.txtStartScriptId4.TabIndex = 19;
            this.txtStartScriptId4.Leave += new System.EventHandler(this.txtStartScriptId4_Leave);
            // 
            // txtStartScriptChance3
            // 
            this.txtStartScriptChance3.Location = new System.Drawing.Point(225, 143);
            this.txtStartScriptChance3.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptChance3.Name = "txtStartScriptChance3";
            this.txtStartScriptChance3.Size = new System.Drawing.Size(190, 20);
            this.txtStartScriptChance3.TabIndex = 18;
            this.txtStartScriptChance3.Leave += new System.EventHandler(this.txtStartScriptChance3_Leave);
            // 
            // txtStartScriptId3
            // 
            this.txtStartScriptId3.Location = new System.Drawing.Point(19, 143);
            this.txtStartScriptId3.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptId3.Name = "txtStartScriptId3";
            this.txtStartScriptId3.Size = new System.Drawing.Size(191, 20);
            this.txtStartScriptId3.TabIndex = 17;
            this.txtStartScriptId3.Leave += new System.EventHandler(this.txtStartScriptId3_Leave);
            // 
            // txtStartScriptChance2
            // 
            this.txtStartScriptChance2.Location = new System.Drawing.Point(225, 114);
            this.txtStartScriptChance2.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptChance2.Name = "txtStartScriptChance2";
            this.txtStartScriptChance2.Size = new System.Drawing.Size(190, 20);
            this.txtStartScriptChance2.TabIndex = 16;
            this.txtStartScriptChance2.Leave += new System.EventHandler(this.txtStartScriptChance2_Leave);
            // 
            // txtStartScriptId2
            // 
            this.txtStartScriptId2.Location = new System.Drawing.Point(19, 114);
            this.txtStartScriptId2.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptId2.Name = "txtStartScriptId2";
            this.txtStartScriptId2.Size = new System.Drawing.Size(191, 20);
            this.txtStartScriptId2.TabIndex = 15;
            this.txtStartScriptId2.Leave += new System.EventHandler(this.txtStartScriptId2_Leave);
            // 
            // txtStartScriptChance1
            // 
            this.txtStartScriptChance1.Location = new System.Drawing.Point(225, 85);
            this.txtStartScriptChance1.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptChance1.Name = "txtStartScriptChance1";
            this.txtStartScriptChance1.Size = new System.Drawing.Size(190, 20);
            this.txtStartScriptChance1.TabIndex = 14;
            this.txtStartScriptChance1.Leave += new System.EventHandler(this.txtStartScriptChance1_Leave);
            // 
            // txtStartScriptId1
            // 
            this.txtStartScriptId1.Location = new System.Drawing.Point(19, 85);
            this.txtStartScriptId1.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptId1.Name = "txtStartScriptId1";
            this.txtStartScriptId1.Size = new System.Drawing.Size(191, 20);
            this.txtStartScriptId1.TabIndex = 13;
            this.txtStartScriptId1.Leave += new System.EventHandler(this.txtStartScriptId1_Leave);
            // 
            // lblStartScriptChance
            // 
            this.lblStartScriptChance.AutoSize = true;
            this.lblStartScriptChance.Location = new System.Drawing.Point(228, 63);
            this.lblStartScriptChance.Name = "lblStartScriptChance";
            this.lblStartScriptChance.Size = new System.Drawing.Size(86, 13);
            this.lblStartScriptChance.TabIndex = 12;
            this.lblStartScriptChance.Text = "Percent chance:";
            // 
            // lblStartScriptId
            // 
            this.lblStartScriptId.AutoSize = true;
            this.lblStartScriptId.Location = new System.Drawing.Point(22, 63);
            this.lblStartScriptId.Name = "lblStartScriptId";
            this.lblStartScriptId.Size = new System.Drawing.Size(82, 13);
            this.lblStartScriptId.TabIndex = 11;
            this.lblStartScriptId.Text = "Event Script ID:";
            // 
            // lblStartScriptTooltip
            // 
            this.lblStartScriptTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartScriptTooltip.Location = new System.Drawing.Point(19, 10);
            this.lblStartScriptTooltip.Name = "lblStartScriptTooltip";
            this.lblStartScriptTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblStartScriptTooltip.TabIndex = 10;
            this.lblStartScriptTooltip.Text = "Starts one of the specified event script Ids. Chosen script is determined by a ra" +
    "ndom chance roll. Total chance must not exceed 100%.";
            // 
            // lblNoAction
            // 
            this.lblNoAction.AutoSize = true;
            this.lblNoAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAction.Location = new System.Drawing.Point(575, 406);
            this.lblNoAction.Name = "lblNoAction";
            this.lblNoAction.Size = new System.Drawing.Size(163, 20);
            this.lblNoAction.TabIndex = 46;
            this.lblNoAction.Text = "No Action Selected";
            // 
            // btnActionCopy
            // 
            this.btnActionCopy.Location = new System.Drawing.Point(219, 588);
            this.btnActionCopy.Name = "btnActionCopy";
            this.btnActionCopy.Size = new System.Drawing.Size(75, 23);
            this.btnActionCopy.TabIndex = 47;
            this.btnActionCopy.Text = "Copy";
            this.btnActionCopy.UseVisualStyleBackColor = true;
            this.btnActionCopy.Click += new System.EventHandler(this.btnActionCopy_Click);
            // 
            // btnViewRaw
            // 
            this.btnViewRaw.Location = new System.Drawing.Point(751, 588);
            this.btnViewRaw.Name = "btnViewRaw";
            this.btnViewRaw.Size = new System.Drawing.Size(75, 23);
            this.btnViewRaw.TabIndex = 48;
            this.btnViewRaw.Text = "View Raw";
            this.btnViewRaw.UseVisualStyleBackColor = true;
            this.btnViewRaw.Click += new System.EventHandler(this.btnViewRaw_Click);
            // 
            // frmCommandSetPhase
            // 
            this.frmCommandSetPhase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetPhase.Controls.Add(this.lblSetPhasePhase);
            this.frmCommandSetPhase.Controls.Add(this.lblSetPhaseMode);
            this.frmCommandSetPhase.Controls.Add(this.txtSetPhasePhase);
            this.frmCommandSetPhase.Controls.Add(this.cmbSetPhaseMode);
            this.frmCommandSetPhase.Controls.Add(this.lblSetPhaseTooltip);
            this.frmCommandSetPhase.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetPhase.Name = "frmCommandSetPhase";
            this.frmCommandSetPhase.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetPhase.TabIndex = 49;
            this.frmCommandSetPhase.Visible = false;
            // 
            // lblSetPhasePhase
            // 
            this.lblSetPhasePhase.AutoSize = true;
            this.lblSetPhasePhase.Location = new System.Drawing.Point(56, 93);
            this.lblSetPhasePhase.Name = "lblSetPhasePhase";
            this.lblSetPhasePhase.Size = new System.Drawing.Size(40, 13);
            this.lblSetPhasePhase.TabIndex = 4;
            this.lblSetPhasePhase.Text = "Phase:";
            // 
            // lblSetPhaseMode
            // 
            this.lblSetPhaseMode.AutoSize = true;
            this.lblSetPhaseMode.Location = new System.Drawing.Point(58, 61);
            this.lblSetPhaseMode.Name = "lblSetPhaseMode";
            this.lblSetPhaseMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetPhaseMode.TabIndex = 3;
            this.lblSetPhaseMode.Text = "Mode:";
            // 
            // txtSetPhasePhase
            // 
            this.txtSetPhasePhase.Location = new System.Drawing.Point(99, 90);
            this.txtSetPhasePhase.Name = "txtSetPhasePhase";
            this.txtSetPhasePhase.Size = new System.Drawing.Size(374, 20);
            this.txtSetPhasePhase.TabIndex = 2;
            this.txtSetPhasePhase.Leave += new System.EventHandler(this.txtSetPhasePhase_Leave);
            // 
            // cmbSetPhaseMode
            // 
            this.cmbSetPhaseMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetPhaseMode.FormattingEnabled = true;
            this.cmbSetPhaseMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetPhaseMode.Name = "cmbSetPhaseMode";
            this.cmbSetPhaseMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetPhaseMode.TabIndex = 1;
            this.cmbSetPhaseMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetPhaseMode_SelectedIndexChanged);
            // 
            // lblSetPhaseTooltip
            // 
            this.lblSetPhaseTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetPhaseTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetPhaseTooltip.Name = "lblSetPhaseTooltip";
            this.lblSetPhaseTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetPhaseTooltip.TabIndex = 0;
            this.lblSetPhaseTooltip.Text = "Changes the current AI phase of the source Creature. Can only be used on creature" +
    "s with EventAI.";
            // 
            // frmCommandSetRandomPhase
            // 
            this.frmCommandSetRandomPhase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhase4);
            this.frmCommandSetRandomPhase.Controls.Add(this.txtSetRandomPhase4);
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhase3);
            this.frmCommandSetRandomPhase.Controls.Add(this.txtSetRandomPhase3);
            this.frmCommandSetRandomPhase.Controls.Add(this.txtSetRandomPhase1);
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhase2);
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhase1);
            this.frmCommandSetRandomPhase.Controls.Add(this.txtSetRandomPhase2);
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhaseTooltip);
            this.frmCommandSetRandomPhase.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetRandomPhase.Name = "frmCommandSetRandomPhase";
            this.frmCommandSetRandomPhase.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetRandomPhase.TabIndex = 50;
            this.frmCommandSetRandomPhase.Visible = false;
            // 
            // lblSetRandomPhase4
            // 
            this.lblSetRandomPhase4.AutoSize = true;
            this.lblSetRandomPhase4.Location = new System.Drawing.Point(46, 160);
            this.lblSetRandomPhase4.Name = "lblSetRandomPhase4";
            this.lblSetRandomPhase4.Size = new System.Drawing.Size(49, 13);
            this.lblSetRandomPhase4.TabIndex = 9;
            this.lblSetRandomPhase4.Text = "Phase 4:";
            // 
            // txtSetRandomPhase4
            // 
            this.txtSetRandomPhase4.Location = new System.Drawing.Point(99, 157);
            this.txtSetRandomPhase4.Name = "txtSetRandomPhase4";
            this.txtSetRandomPhase4.Size = new System.Drawing.Size(374, 20);
            this.txtSetRandomPhase4.TabIndex = 8;
            this.txtSetRandomPhase4.Leave += new System.EventHandler(this.txtSetRandomPhase4_Leave);
            // 
            // lblSetRandomPhase3
            // 
            this.lblSetRandomPhase3.AutoSize = true;
            this.lblSetRandomPhase3.Location = new System.Drawing.Point(46, 127);
            this.lblSetRandomPhase3.Name = "lblSetRandomPhase3";
            this.lblSetRandomPhase3.Size = new System.Drawing.Size(49, 13);
            this.lblSetRandomPhase3.TabIndex = 7;
            this.lblSetRandomPhase3.Text = "Phase 3:";
            // 
            // txtSetRandomPhase3
            // 
            this.txtSetRandomPhase3.Location = new System.Drawing.Point(99, 124);
            this.txtSetRandomPhase3.Name = "txtSetRandomPhase3";
            this.txtSetRandomPhase3.Size = new System.Drawing.Size(374, 20);
            this.txtSetRandomPhase3.TabIndex = 6;
            this.txtSetRandomPhase3.Leave += new System.EventHandler(this.txtSetRandomPhase3_Leave);
            // 
            // txtSetRandomPhase1
            // 
            this.txtSetRandomPhase1.Location = new System.Drawing.Point(99, 58);
            this.txtSetRandomPhase1.Name = "txtSetRandomPhase1";
            this.txtSetRandomPhase1.Size = new System.Drawing.Size(374, 20);
            this.txtSetRandomPhase1.TabIndex = 5;
            this.txtSetRandomPhase1.Leave += new System.EventHandler(this.txtSetRandomPhase1_Leave);
            // 
            // lblSetRandomPhase2
            // 
            this.lblSetRandomPhase2.AutoSize = true;
            this.lblSetRandomPhase2.Location = new System.Drawing.Point(46, 94);
            this.lblSetRandomPhase2.Name = "lblSetRandomPhase2";
            this.lblSetRandomPhase2.Size = new System.Drawing.Size(49, 13);
            this.lblSetRandomPhase2.TabIndex = 4;
            this.lblSetRandomPhase2.Text = "Phase 2:";
            // 
            // lblSetRandomPhase1
            // 
            this.lblSetRandomPhase1.AutoSize = true;
            this.lblSetRandomPhase1.Location = new System.Drawing.Point(46, 61);
            this.lblSetRandomPhase1.Name = "lblSetRandomPhase1";
            this.lblSetRandomPhase1.Size = new System.Drawing.Size(49, 13);
            this.lblSetRandomPhase1.TabIndex = 3;
            this.lblSetRandomPhase1.Text = "Phase 1:";
            // 
            // txtSetRandomPhase2
            // 
            this.txtSetRandomPhase2.Location = new System.Drawing.Point(99, 91);
            this.txtSetRandomPhase2.Name = "txtSetRandomPhase2";
            this.txtSetRandomPhase2.Size = new System.Drawing.Size(374, 20);
            this.txtSetRandomPhase2.TabIndex = 2;
            this.txtSetRandomPhase2.Leave += new System.EventHandler(this.txtSetRandomPhase2_Leave);
            // 
            // lblSetRandomPhaseTooltip
            // 
            this.lblSetRandomPhaseTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetRandomPhaseTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetRandomPhaseTooltip.Name = "lblSetRandomPhaseTooltip";
            this.lblSetRandomPhaseTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetRandomPhaseTooltip.TabIndex = 0;
            this.lblSetRandomPhaseTooltip.Text = "Randomly chooses one of the provided values and sets the Creature\'s AI phase to i" +
    "t. Can only be used on creatures with EventAI.";
            // 
            // frmCommandFlee
            // 
            this.frmCommandFlee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandFlee.Controls.Add(this.cmbFleeMode);
            this.frmCommandFlee.Controls.Add(this.lblFleeMode);
            this.frmCommandFlee.Controls.Add(this.lblFleeTooltip);
            this.frmCommandFlee.Location = new System.Drawing.Point(410, 250);
            this.frmCommandFlee.Name = "frmCommandFlee";
            this.frmCommandFlee.Size = new System.Drawing.Size(495, 332);
            this.frmCommandFlee.TabIndex = 51;
            this.frmCommandFlee.Visible = false;
            // 
            // cmbFleeMode
            // 
            this.cmbFleeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFleeMode.FormattingEnabled = true;
            this.cmbFleeMode.Location = new System.Drawing.Point(99, 58);
            this.cmbFleeMode.Name = "cmbFleeMode";
            this.cmbFleeMode.Size = new System.Drawing.Size(374, 21);
            this.cmbFleeMode.TabIndex = 2;
            this.cmbFleeMode.SelectedIndexChanged += new System.EventHandler(this.cmbFleeMode_SelectedIndexChanged);
            // 
            // lblFleeMode
            // 
            this.lblFleeMode.AutoSize = true;
            this.lblFleeMode.Location = new System.Drawing.Point(58, 61);
            this.lblFleeMode.Name = "lblFleeMode";
            this.lblFleeMode.Size = new System.Drawing.Size(37, 13);
            this.lblFleeMode.TabIndex = 1;
            this.lblFleeMode.Text = "Mode:";
            // 
            // lblFleeTooltip
            // 
            this.lblFleeTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFleeTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblFleeTooltip.Name = "lblFleeTooltip";
            this.lblFleeTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblFleeTooltip.TabIndex = 0;
            this.lblFleeTooltip.Text = "The source Creature attempts to flee from the attacker.";
            // 
            // frmCommandCallForHelp
            // 
            this.frmCommandCallForHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandCallForHelp.Controls.Add(this.lblCallForHelpRadius);
            this.frmCommandCallForHelp.Controls.Add(this.txtCallForHelpRadius);
            this.frmCommandCallForHelp.Controls.Add(this.lblCallForHelpTooltip);
            this.frmCommandCallForHelp.Location = new System.Drawing.Point(410, 250);
            this.frmCommandCallForHelp.Name = "frmCommandCallForHelp";
            this.frmCommandCallForHelp.Size = new System.Drawing.Size(495, 332);
            this.frmCommandCallForHelp.TabIndex = 52;
            this.frmCommandCallForHelp.Visible = false;
            // 
            // lblCallForHelpRadius
            // 
            this.lblCallForHelpRadius.AutoSize = true;
            this.lblCallForHelpRadius.Location = new System.Drawing.Point(52, 61);
            this.lblCallForHelpRadius.Name = "lblCallForHelpRadius";
            this.lblCallForHelpRadius.Size = new System.Drawing.Size(43, 13);
            this.lblCallForHelpRadius.TabIndex = 2;
            this.lblCallForHelpRadius.Text = "Radius:";
            // 
            // txtCallForHelpRadius
            // 
            this.txtCallForHelpRadius.Location = new System.Drawing.Point(99, 58);
            this.txtCallForHelpRadius.Name = "txtCallForHelpRadius";
            this.txtCallForHelpRadius.Size = new System.Drawing.Size(374, 20);
            this.txtCallForHelpRadius.TabIndex = 1;
            this.txtCallForHelpRadius.Leave += new System.EventHandler(this.txtCallForHelpRadius_Leave);
            // 
            // lblCallForHelpTooltip
            // 
            this.lblCallForHelpTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCallForHelpTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblCallForHelpTooltip.Name = "lblCallForHelpTooltip";
            this.lblCallForHelpTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblCallForHelpTooltip.TabIndex = 0;
            this.lblCallForHelpTooltip.Text = "Calls any friendly creatures in the specified radius to attack the source Creatur" +
    "e\'s target.";
            // 
            // frmCommandGameEvent
            // 
            this.frmCommandGameEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandGameEvent.Controls.Add(this.cmbGameEventOverwrite);
            this.frmCommandGameEvent.Controls.Add(this.lblGameEventOverwrite);
            this.frmCommandGameEvent.Controls.Add(this.cmbGameEventAction);
            this.frmCommandGameEvent.Controls.Add(this.lblGameEventId);
            this.frmCommandGameEvent.Controls.Add(this.lblGameEventAction);
            this.frmCommandGameEvent.Controls.Add(this.btnGameEventId);
            this.frmCommandGameEvent.Controls.Add(this.lblCommandGameEventTooltip);
            this.frmCommandGameEvent.Location = new System.Drawing.Point(410, 250);
            this.frmCommandGameEvent.Name = "frmCommandGameEvent";
            this.frmCommandGameEvent.Size = new System.Drawing.Size(495, 332);
            this.frmCommandGameEvent.TabIndex = 53;
            this.frmCommandGameEvent.Visible = false;
            // 
            // cmbGameEventOverwrite
            // 
            this.cmbGameEventOverwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameEventOverwrite.FormattingEnabled = true;
            this.cmbGameEventOverwrite.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbGameEventOverwrite.Location = new System.Drawing.Point(99, 120);
            this.cmbGameEventOverwrite.Name = "cmbGameEventOverwrite";
            this.cmbGameEventOverwrite.Size = new System.Drawing.Size(374, 21);
            this.cmbGameEventOverwrite.TabIndex = 7;
            this.cmbGameEventOverwrite.SelectedIndexChanged += new System.EventHandler(this.cmbGameEventOverwrite_SelectedIndexChanged);
            // 
            // lblGameEventOverwrite
            // 
            this.lblGameEventOverwrite.AutoSize = true;
            this.lblGameEventOverwrite.Location = new System.Drawing.Point(41, 123);
            this.lblGameEventOverwrite.Name = "lblGameEventOverwrite";
            this.lblGameEventOverwrite.Size = new System.Drawing.Size(55, 13);
            this.lblGameEventOverwrite.TabIndex = 6;
            this.lblGameEventOverwrite.Text = "Overwrite:";
            // 
            // cmbGameEventAction
            // 
            this.cmbGameEventAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameEventAction.FormattingEnabled = true;
            this.cmbGameEventAction.Items.AddRange(new object[] {
            "Stop",
            "Start"});
            this.cmbGameEventAction.Location = new System.Drawing.Point(99, 90);
            this.cmbGameEventAction.Name = "cmbGameEventAction";
            this.cmbGameEventAction.Size = new System.Drawing.Size(374, 21);
            this.cmbGameEventAction.TabIndex = 5;
            this.cmbGameEventAction.SelectedIndexChanged += new System.EventHandler(this.cmbGameEventAction_SelectedIndexChanged);
            // 
            // lblGameEventId
            // 
            this.lblGameEventId.AutoSize = true;
            this.lblGameEventId.Location = new System.Drawing.Point(46, 61);
            this.lblGameEventId.Name = "lblGameEventId";
            this.lblGameEventId.Size = new System.Drawing.Size(50, 13);
            this.lblGameEventId.TabIndex = 4;
            this.lblGameEventId.Text = "Event Id:";
            // 
            // lblGameEventAction
            // 
            this.lblGameEventAction.AutoSize = true;
            this.lblGameEventAction.Location = new System.Drawing.Point(56, 93);
            this.lblGameEventAction.Name = "lblGameEventAction";
            this.lblGameEventAction.Size = new System.Drawing.Size(40, 13);
            this.lblGameEventAction.TabIndex = 3;
            this.lblGameEventAction.Text = "Action:";
            // 
            // btnGameEventId
            // 
            this.btnGameEventId.Location = new System.Drawing.Point(99, 58);
            this.btnGameEventId.Name = "btnGameEventId";
            this.btnGameEventId.Size = new System.Drawing.Size(374, 23);
            this.btnGameEventId.TabIndex = 1;
            this.btnGameEventId.Text = "-NONE-";
            this.btnGameEventId.UseVisualStyleBackColor = true;
            this.btnGameEventId.Click += new System.EventHandler(this.btnGameEventId_Click);
            // 
            // lblCommandGameEventTooltip
            // 
            this.lblCommandGameEventTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommandGameEventTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblCommandGameEventTooltip.Name = "lblCommandGameEventTooltip";
            this.lblCommandGameEventTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblCommandGameEventTooltip.TabIndex = 0;
            this.lblCommandGameEventTooltip.Text = "Starts or stops the chosen game event.";
            // 
            // frmCommandSetSpellsTemplate
            // 
            this.frmCommandSetSpellsTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetSpellsTemplate.Controls.Add(this.btnSetSpellsTemplate4);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.txtSetSpellsTemplateChance4);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.btnSetSpellsTemplate3);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.txtSetSpellsTemplateChance3);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.btnSetSpellsTemplate2);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.txtSetSpellsTemplateChance2);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.btnSetSpellsTemplate1);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.txtSetSpellsTemplateChance1);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.label1);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.lblSetSpellsTempalteId);
            this.frmCommandSetSpellsTemplate.Controls.Add(this.lblSetSpellsTemplateTooltip);
            this.frmCommandSetSpellsTemplate.Location = new System.Drawing.Point(410, 250);
            this.frmCommandSetSpellsTemplate.Name = "frmCommandSetSpellsTemplate";
            this.frmCommandSetSpellsTemplate.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetSpellsTemplate.TabIndex = 54;
            this.frmCommandSetSpellsTemplate.Visible = false;
            // 
            // btnSetSpellsTemplate4
            // 
            this.btnSetSpellsTemplate4.Location = new System.Drawing.Point(19, 181);
            this.btnSetSpellsTemplate4.Name = "btnSetSpellsTemplate4";
            this.btnSetSpellsTemplate4.Size = new System.Drawing.Size(334, 23);
            this.btnSetSpellsTemplate4.TabIndex = 31;
            this.btnSetSpellsTemplate4.Text = "-NONE-";
            this.btnSetSpellsTemplate4.UseVisualStyleBackColor = true;
            this.btnSetSpellsTemplate4.Click += new System.EventHandler(this.btnSetSpellsTemplate4_Click);
            // 
            // txtSetSpellsTemplateChance4
            // 
            this.txtSetSpellsTemplateChance4.Location = new System.Drawing.Point(359, 182);
            this.txtSetSpellsTemplateChance4.Name = "txtSetSpellsTemplateChance4";
            this.txtSetSpellsTemplateChance4.Size = new System.Drawing.Size(114, 20);
            this.txtSetSpellsTemplateChance4.TabIndex = 30;
            this.txtSetSpellsTemplateChance4.Leave += new System.EventHandler(this.txtSetSpellsTemplateChance4_Leave);
            // 
            // btnSetSpellsTemplate3
            // 
            this.btnSetSpellsTemplate3.Location = new System.Drawing.Point(19, 149);
            this.btnSetSpellsTemplate3.Name = "btnSetSpellsTemplate3";
            this.btnSetSpellsTemplate3.Size = new System.Drawing.Size(334, 23);
            this.btnSetSpellsTemplate3.TabIndex = 29;
            this.btnSetSpellsTemplate3.Text = "-NONE-";
            this.btnSetSpellsTemplate3.UseVisualStyleBackColor = true;
            this.btnSetSpellsTemplate3.Click += new System.EventHandler(this.btnSetSpellsTemplate3_Click);
            // 
            // txtSetSpellsTemplateChance3
            // 
            this.txtSetSpellsTemplateChance3.Location = new System.Drawing.Point(359, 150);
            this.txtSetSpellsTemplateChance3.Name = "txtSetSpellsTemplateChance3";
            this.txtSetSpellsTemplateChance3.Size = new System.Drawing.Size(114, 20);
            this.txtSetSpellsTemplateChance3.TabIndex = 28;
            this.txtSetSpellsTemplateChance3.Leave += new System.EventHandler(this.txtSetSpellsTemplateChance3_Leave);
            // 
            // btnSetSpellsTemplate2
            // 
            this.btnSetSpellsTemplate2.Location = new System.Drawing.Point(19, 117);
            this.btnSetSpellsTemplate2.Name = "btnSetSpellsTemplate2";
            this.btnSetSpellsTemplate2.Size = new System.Drawing.Size(334, 23);
            this.btnSetSpellsTemplate2.TabIndex = 27;
            this.btnSetSpellsTemplate2.Text = "-NONE-";
            this.btnSetSpellsTemplate2.UseVisualStyleBackColor = true;
            this.btnSetSpellsTemplate2.Click += new System.EventHandler(this.btnSetSpellsTemplate2_Click);
            // 
            // txtSetSpellsTemplateChance2
            // 
            this.txtSetSpellsTemplateChance2.Location = new System.Drawing.Point(359, 118);
            this.txtSetSpellsTemplateChance2.Name = "txtSetSpellsTemplateChance2";
            this.txtSetSpellsTemplateChance2.Size = new System.Drawing.Size(114, 20);
            this.txtSetSpellsTemplateChance2.TabIndex = 26;
            this.txtSetSpellsTemplateChance2.Leave += new System.EventHandler(this.txtSetSpellsTemplateChance2_Leave);
            // 
            // btnSetSpellsTemplate1
            // 
            this.btnSetSpellsTemplate1.Location = new System.Drawing.Point(19, 85);
            this.btnSetSpellsTemplate1.Name = "btnSetSpellsTemplate1";
            this.btnSetSpellsTemplate1.Size = new System.Drawing.Size(334, 23);
            this.btnSetSpellsTemplate1.TabIndex = 25;
            this.btnSetSpellsTemplate1.Text = "-NONE-";
            this.btnSetSpellsTemplate1.UseVisualStyleBackColor = true;
            this.btnSetSpellsTemplate1.Click += new System.EventHandler(this.btnSetSpellsTemplate1_Click);
            // 
            // txtSetSpellsTemplateChance1
            // 
            this.txtSetSpellsTemplateChance1.Location = new System.Drawing.Point(359, 86);
            this.txtSetSpellsTemplateChance1.Name = "txtSetSpellsTemplateChance1";
            this.txtSetSpellsTemplateChance1.Size = new System.Drawing.Size(114, 20);
            this.txtSetSpellsTemplateChance1.TabIndex = 14;
            this.txtSetSpellsTemplateChance1.Leave += new System.EventHandler(this.txtSetSpellsTemplateChance1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Percent chance:";
            // 
            // lblSetSpellsTempalteId
            // 
            this.lblSetSpellsTempalteId.AutoSize = true;
            this.lblSetSpellsTempalteId.Location = new System.Drawing.Point(22, 63);
            this.lblSetSpellsTempalteId.Name = "lblSetSpellsTempalteId";
            this.lblSetSpellsTempalteId.Size = new System.Drawing.Size(99, 13);
            this.lblSetSpellsTempalteId.TabIndex = 11;
            this.lblSetSpellsTempalteId.Text = "Spells Template ID:";
            // 
            // lblSetSpellsTemplateTooltip
            // 
            this.lblSetSpellsTemplateTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetSpellsTemplateTooltip.Location = new System.Drawing.Point(19, 10);
            this.lblSetSpellsTemplateTooltip.Name = "lblSetSpellsTemplateTooltip";
            this.lblSetSpellsTemplateTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetSpellsTemplateTooltip.TabIndex = 10;
            this.lblSetSpellsTemplateTooltip.Text = "Sets the source Creature\'s current spells template.";
            // 
            // FormScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 620);
            this.Controls.Add(this.frmCommandSetSpellsTemplate);
            this.Controls.Add(this.frmCommandGameEvent);
            this.Controls.Add(this.frmCommandCallForHelp);
            this.Controls.Add(this.frmCommandFlee);
            this.Controls.Add(this.frmCommandSetRandomPhase);
            this.Controls.Add(this.frmCommandSetPhase);
            this.Controls.Add(this.btnViewRaw);
            this.Controls.Add(this.btnActionCopy);
            this.Controls.Add(this.frmCommandStartScript);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.frmCommandSetData);
            this.Controls.Add(this.frmCommandMeetingStone);
            this.Controls.Add(this.frmCommandSetFacing);
            this.Controls.Add(this.frmCommandSetHomePosition);
            this.Controls.Add(this.frmCommandTerminateCondition);
            this.Controls.Add(this.frmCommandTerminateScript);
            this.Controls.Add(this.frmCommandSendTaxiPath);
            this.Controls.Add(this.frmCommandModifyThreat);
            this.Controls.Add(this.frmCommandSetStandState);
            this.Controls.Add(this.frmCommandUpdateEntry);
            this.Controls.Add(this.frmCommandInterruptCasts);
            this.Controls.Add(this.frmCommandModifyFlags);
            this.Controls.Add(this.frmCommandSetRun);
            this.Controls.Add(this.frmCommandMorphOrMount);
            this.Controls.Add(this.frmCommandSetFaction);
            this.Controls.Add(this.frmCommandActiveObject);
            this.Controls.Add(this.frmCommandSetMovement);
            this.Controls.Add(this.frmCommandSetEquipment);
            this.Controls.Add(this.frmCommandDespawnCreature);
            this.Controls.Add(this.frmCommandCreateItem);
            this.Controls.Add(this.frmCommandPlaySound);
            this.Controls.Add(this.frmCommandCastSpell);
            this.Controls.Add(this.frmCommandRemoveAura);
            this.Controls.Add(this.frmCommandDoor);
            this.Controls.Add(this.frmCommandSummonCreature);
            this.Controls.Add(this.frmCommandRespawnGameobject);
            this.Controls.Add(this.frmCommandKillCredit);
            this.Controls.Add(this.frmCommandQuestComplete);
            this.Controls.Add(this.frmCommandTeleport);
            this.Controls.Add(this.frmCommandMoveTo);
            this.Controls.Add(this.frmCommandFieldSet);
            this.Controls.Add(this.frmCommandEmote);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblScriptId);
            this.Controls.Add(this.btnActionAdd);
            this.Controls.Add(this.btnActionDelete);
            this.Controls.Add(this.frmCommandTalk);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.txtScriptId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstActions);
            this.Controls.Add(this.lblNoAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormScriptEditor";
            this.Text = "Script Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScriptEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormScriptEditor_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpDataFlags.ResumeLayout(false);
            this.grpDataFlags.PerformLayout();
            this.grpBuddy.ResumeLayout(false);
            this.grpBuddy.PerformLayout();
            this.frmCommandTalk.ResumeLayout(false);
            this.frmCommandTalk.PerformLayout();
            this.frmCommandEmote.ResumeLayout(false);
            this.frmCommandEmote.PerformLayout();
            this.frmCommandFieldSet.ResumeLayout(false);
            this.frmCommandFieldSet.PerformLayout();
            this.frmCommandMoveTo.ResumeLayout(false);
            this.frmCommandMoveTo.PerformLayout();
            this.grpMoveToOptions.ResumeLayout(false);
            this.grpMoveToOptions.PerformLayout();
            this.frmCommandTeleport.ResumeLayout(false);
            this.frmCommandTeleport.PerformLayout();
            this.grpTeleportOptions.ResumeLayout(false);
            this.grpTeleportOptions.PerformLayout();
            this.frmCommandQuestComplete.ResumeLayout(false);
            this.frmCommandQuestComplete.PerformLayout();
            this.frmCommandKillCredit.ResumeLayout(false);
            this.frmCommandKillCredit.PerformLayout();
            this.frmCommandRespawnGameobject.ResumeLayout(false);
            this.frmCommandRespawnGameobject.PerformLayout();
            this.frmCommandSummonCreature.ResumeLayout(false);
            this.frmCommandSummonCreature.PerformLayout();
            this.grpSummonCreatureFlags.ResumeLayout(false);
            this.grpSummonCreatureFlags.PerformLayout();
            this.frmCommandDoor.ResumeLayout(false);
            this.frmCommandDoor.PerformLayout();
            this.frmCommandRemoveAura.ResumeLayout(false);
            this.frmCommandRemoveAura.PerformLayout();
            this.frmCommandCastSpell.ResumeLayout(false);
            this.frmCommandCastSpell.PerformLayout();
            this.grpCastSpellFlags.ResumeLayout(false);
            this.grpCastSpellFlags.PerformLayout();
            this.frmCommandPlaySound.ResumeLayout(false);
            this.frmCommandPlaySound.PerformLayout();
            this.grpPlaySoundFlags.ResumeLayout(false);
            this.grpPlaySoundFlags.PerformLayout();
            this.frmCommandCreateItem.ResumeLayout(false);
            this.frmCommandCreateItem.PerformLayout();
            this.frmCommandDespawnCreature.ResumeLayout(false);
            this.frmCommandDespawnCreature.PerformLayout();
            this.frmCommandSetEquipment.ResumeLayout(false);
            this.frmCommandSetEquipment.PerformLayout();
            this.frmCommandSetMovement.ResumeLayout(false);
            this.frmCommandSetMovement.PerformLayout();
            this.frmCommandActiveObject.ResumeLayout(false);
            this.frmCommandActiveObject.PerformLayout();
            this.frmCommandSetFaction.ResumeLayout(false);
            this.frmCommandSetFaction.PerformLayout();
            this.grpSetFactionFlags.ResumeLayout(false);
            this.grpSetFactionFlags.PerformLayout();
            this.frmCommandMorphOrMount.ResumeLayout(false);
            this.frmCommandMorphOrMount.PerformLayout();
            this.frmCommandSetRun.ResumeLayout(false);
            this.frmCommandSetRun.PerformLayout();
            this.frmCommandModifyFlags.ResumeLayout(false);
            this.frmCommandModifyFlags.PerformLayout();
            this.frmCommandInterruptCasts.ResumeLayout(false);
            this.frmCommandInterruptCasts.PerformLayout();
            this.frmCommandUpdateEntry.ResumeLayout(false);
            this.frmCommandUpdateEntry.PerformLayout();
            this.frmCommandSetStandState.ResumeLayout(false);
            this.frmCommandSetStandState.PerformLayout();
            this.frmCommandModifyThreat.ResumeLayout(false);
            this.frmCommandModifyThreat.PerformLayout();
            this.frmCommandSendTaxiPath.ResumeLayout(false);
            this.frmCommandSendTaxiPath.PerformLayout();
            this.frmCommandTerminateScript.ResumeLayout(false);
            this.frmCommandTerminateScript.PerformLayout();
            this.frmCommandTerminateCondition.ResumeLayout(false);
            this.frmCommandTerminateCondition.PerformLayout();
            this.frmCommandSetHomePosition.ResumeLayout(false);
            this.frmCommandSetHomePosition.PerformLayout();
            this.frmCommandSetFacing.ResumeLayout(false);
            this.frmCommandSetFacing.PerformLayout();
            this.frmCommandMeetingStone.ResumeLayout(false);
            this.frmCommandMeetingStone.PerformLayout();
            this.frmCommandSetData.ResumeLayout(false);
            this.frmCommandSetData.PerformLayout();
            this.frmCommandStartScript.ResumeLayout(false);
            this.frmCommandStartScript.PerformLayout();
            this.frmCommandSetPhase.ResumeLayout(false);
            this.frmCommandSetPhase.PerformLayout();
            this.frmCommandSetRandomPhase.ResumeLayout(false);
            this.frmCommandSetRandomPhase.PerformLayout();
            this.frmCommandFlee.ResumeLayout(false);
            this.frmCommandFlee.PerformLayout();
            this.frmCommandCallForHelp.ResumeLayout(false);
            this.frmCommandCallForHelp.PerformLayout();
            this.frmCommandGameEvent.ResumeLayout(false);
            this.frmCommandGameEvent.PerformLayout();
            this.frmCommandSetSpellsTemplate.ResumeLayout(false);
            this.frmCommandSetSpellsTemplate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstActions;
        private System.Windows.Forms.ColumnHeader columnDelay;
        private System.Windows.Forms.ColumnHeader columnCommand;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtScriptId;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.ComboBox cmbCommandId;
        private System.Windows.Forms.TextBox txtCommandDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.GroupBox grpBuddy;
        private System.Windows.Forms.TextBox txtTargetParam1;
        private System.Windows.Forms.Label lblTargetParam2;
        private System.Windows.Forms.Label lblTargetParam1;
        private System.Windows.Forms.ComboBox cmbTargetType;
        private System.Windows.Forms.TextBox txtTargetParam2;
        private System.Windows.Forms.GroupBox grpDataFlags;
        private System.Windows.Forms.CheckBox chkAbortScript;
        private System.Windows.Forms.CheckBox chkTargetSelf;
        private System.Windows.Forms.CheckBox chkSwapFinal;
        private System.Windows.Forms.CheckBox chkSwapInitial;
        private System.Windows.Forms.Label lblTargetType;
        private System.Windows.Forms.Panel frmCommandTalk;
        private System.Windows.Forms.ComboBox cmbTalkChatType;
        private System.Windows.Forms.Label lblTalkChatType;
        private System.Windows.Forms.TextBox txtTalkText4;
        private System.Windows.Forms.TextBox txtTalkText3;
        private System.Windows.Forms.TextBox txtTalkText2;
        private System.Windows.Forms.TextBox txtTalkText1;
        private System.Windows.Forms.Button btnTalkText4;
        private System.Windows.Forms.Button btnTalkText3;
        private System.Windows.Forms.Button btnTalkText2;
        private System.Windows.Forms.Button btnTalkText1;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtCommandComment;
        private System.Windows.Forms.Button btnActionDelete;
        private System.Windows.Forms.Button btnActionAdd;
        private System.Windows.Forms.Label lblScriptId;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTalkTextPreview;
        private System.Windows.Forms.Label lblTalkBroadcastId;
        private System.Windows.Forms.Label lblTalkTooltip;
        private System.Windows.Forms.Panel frmCommandEmote;
        private System.Windows.Forms.ComboBox cmbEmoteId;
        private System.Windows.Forms.Label lblEmoteId;
        private System.Windows.Forms.Label lblEmoteTooltip;
        private System.Windows.Forms.Panel frmCommandFieldSet;
        private System.Windows.Forms.ComboBox cmbFieldSetFields;
        private System.Windows.Forms.Label lblFieldSetTooltip;
        private System.Windows.Forms.Label lvlFieldSetValue;
        private System.Windows.Forms.Label lblFieldSetField;
        private System.Windows.Forms.TextBox txtFieldSetValue;
        private System.Windows.Forms.Panel frmCommandMoveTo;
        private System.Windows.Forms.CheckBox chkMoveToFlagsForce;
        private System.Windows.Forms.Label lblMoveToO;
        private System.Windows.Forms.Label lblMoveToZ;
        private System.Windows.Forms.Label lblMoveToY;
        private System.Windows.Forms.Label lblMoveToX;
        private System.Windows.Forms.TextBox txtMoveToO;
        private System.Windows.Forms.TextBox txtMoveToZ;
        private System.Windows.Forms.TextBox txtMoveToY;
        private System.Windows.Forms.TextBox txtMoveToX;
        private System.Windows.Forms.GroupBox grpMoveToOptions;
        private System.Windows.Forms.CheckBox chkMoveOptions256;
        private System.Windows.Forms.CheckBox chkMoveOptions128;
        private System.Windows.Forms.CheckBox chkMoveOptions64;
        private System.Windows.Forms.CheckBox chkMoveOptions32;
        private System.Windows.Forms.CheckBox chkMoveOptions16;
        private System.Windows.Forms.CheckBox chkMoveOptions8;
        private System.Windows.Forms.CheckBox chkMoveOptions4;
        private System.Windows.Forms.CheckBox chkMoveOptions2;
        private System.Windows.Forms.CheckBox chkMoveOptions1;
        private System.Windows.Forms.Label lblMoveToTime;
        private System.Windows.Forms.TextBox txtMoveToTime;
        private System.Windows.Forms.Label lblMoveToType;
        private System.Windows.Forms.ComboBox cmbMoveToType;
        private System.Windows.Forms.Label lblMoveToTooltip;
        private System.Windows.Forms.Panel frmCommandTeleport;
        private System.Windows.Forms.ComboBox cmbTeleportMap;
        private System.Windows.Forms.TextBox txtTeleportZ;
        private System.Windows.Forms.TextBox txtTeleportY;
        private System.Windows.Forms.TextBox txtTeleportX;
        private System.Windows.Forms.Label lblTeleportTooltip;
        private System.Windows.Forms.TextBox txtTeleportO;
        private System.Windows.Forms.Label lblTeleportO;
        private System.Windows.Forms.Label lblTeleportZ;
        private System.Windows.Forms.Label lblTeleportY;
        private System.Windows.Forms.Label lblTeleportX;
        private System.Windows.Forms.Label lblTeleportMapId;
        private System.Windows.Forms.GroupBox grpTeleportOptions;
        private System.Windows.Forms.CheckBox chkTeleportOptions32;
        private System.Windows.Forms.CheckBox chkTeleportOptions16;
        private System.Windows.Forms.CheckBox chkTeleportOptions8;
        private System.Windows.Forms.CheckBox chkTeleportOptions4;
        private System.Windows.Forms.CheckBox chkTeleportOptions2;
        private System.Windows.Forms.CheckBox chkTeleportOptions1;
        private System.Windows.Forms.Panel frmCommandQuestComplete;
        private System.Windows.Forms.Label lblQuestCompleteId;
        private System.Windows.Forms.Label lblQuestCompleteDistance;
        private System.Windows.Forms.TextBox txtQuestCompleteDistance;
        private System.Windows.Forms.Button btnQuestCompleteId;
        private System.Windows.Forms.Label lblQuestCompleteTooltip;
        private System.Windows.Forms.Panel frmCommandKillCredit;
        private System.Windows.Forms.ComboBox cmbKillCreditType;
        private System.Windows.Forms.Label lblKillCreditCreatureId;
        private System.Windows.Forms.Label lblKillCreditType;
        private System.Windows.Forms.Button btnKillCreditCreatureId;
        private System.Windows.Forms.Label lblKillCreditTooltip;
        private System.Windows.Forms.Panel frmCommandRespawnGameobject;
        private System.Windows.Forms.Label lblRespawnGameobjectDelay;
        private System.Windows.Forms.Label lblRespawnGameobjectGuid;
        private System.Windows.Forms.TextBox txtRespawnGameobjectDelay;
        private System.Windows.Forms.TextBox txtRespawnGameobjectGuid;
        private System.Windows.Forms.Label lblRespawnGameobjectTooltip;
        private System.Windows.Forms.Panel frmCommandSummonCreature;
        private System.Windows.Forms.Label lblSummonCreatureId;
        private System.Windows.Forms.GroupBox grpSummonCreatureFlags;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags8;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags4;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags2;
        private System.Windows.Forms.Button btnSummonCreatureId;
        private System.Windows.Forms.Label lblSummonCreatureTooltip;
        private System.Windows.Forms.Label lblSummonCreatureDelay;
        private System.Windows.Forms.TextBox txtSummonCreatureDelay;
        private System.Windows.Forms.TextBox txtSummonCreatureY;
        private System.Windows.Forms.TextBox txtSummonCreatureX;
        private System.Windows.Forms.Label lblSummonCreatureUniqueRange;
        private System.Windows.Forms.Label lblSummonCreatureUniqueLimit;
        private System.Windows.Forms.TextBox txtSummonCreatureUniqueRange;
        private System.Windows.Forms.TextBox txtSummonCreatureUniqueLimit;
        private System.Windows.Forms.Label lblSummonCreatureAttackTarget;
        private System.Windows.Forms.ComboBox cmbSummonCreatureAttackTarget;
        private System.Windows.Forms.Label lblSummonCreatureFacingOptions;
        private System.Windows.Forms.ComboBox cmbSummonCreatureFacingOptions;
        private System.Windows.Forms.Label lblSummonCreatureO;
        private System.Windows.Forms.Label lblSummonCreatureZ;
        private System.Windows.Forms.Label lblSummonCreatureY;
        private System.Windows.Forms.Label lblSummonCreatureX;
        private System.Windows.Forms.TextBox txtSummonCreatureO;
        private System.Windows.Forms.TextBox txtSummonCreatureZ;
        private System.Windows.Forms.Panel frmCommandDoor;
        private System.Windows.Forms.Label lblDoorResetDelay;
        private System.Windows.Forms.Label lblDoorGuid;
        private System.Windows.Forms.TextBox txtDoorResetDelay;
        private System.Windows.Forms.TextBox txtDoorGuid;
        private System.Windows.Forms.Label lblDoorTooltip;
        private System.Windows.Forms.Panel frmCommandRemoveAura;
        private System.Windows.Forms.Button btnRemoveAuraSpellId;
        private System.Windows.Forms.Label lblRemoveAuraSpellId;
        private System.Windows.Forms.Label lblRemoveAuraTooltip;
        private System.Windows.Forms.Panel frmCommandCastSpell;
        private System.Windows.Forms.GroupBox grpCastSpellFlags;
        private System.Windows.Forms.CheckBox chkCastSpellFlags1;
        private System.Windows.Forms.CheckBox chkCastSpellFlags2;
        private System.Windows.Forms.Button btnCastSpellId;
        private System.Windows.Forms.Label lblCastSpellId;
        private System.Windows.Forms.Label lblCastSpellTooltip;
        private System.Windows.Forms.Panel frmCommandPlaySound;
        private System.Windows.Forms.GroupBox grpPlaySoundFlags;
        private System.Windows.Forms.CheckBox chkPlaySoundFlags2;
        private System.Windows.Forms.CheckBox chkPlaySoundFlags1;
        private System.Windows.Forms.Label lblPlaySoundId;
        private System.Windows.Forms.Label lblPlaySoundTooltip;
        private System.Windows.Forms.Panel frmCommandCreateItem;
        private System.Windows.Forms.Label lblCreateItemAmount;
        private System.Windows.Forms.TextBox txtCreateItemAmount;
        private System.Windows.Forms.Button btnCreateItemId;
        private System.Windows.Forms.Label lblCreateItemId;
        private System.Windows.Forms.Label lblCreateItemTooltip;
        private System.Windows.Forms.Panel frmCommandDespawnCreature;
        private System.Windows.Forms.Label lblDespawnCreatureDelay;
        private System.Windows.Forms.TextBox txtDespawnCreatureDelay;
        private System.Windows.Forms.Label lblDespawnCreatureTooltip;
        private System.Windows.Forms.Panel frmCommandSetEquipment;
        private System.Windows.Forms.Label lblSetEquipmentTooltip;
        private System.Windows.Forms.Label lblSetEquipmentRanged;
        private System.Windows.Forms.Label lblSetEquipmentOffHand;
        private System.Windows.Forms.Label lblSetEquipmentMainHand;
        private System.Windows.Forms.Button btnSetEquipmentRanged;
        private System.Windows.Forms.Button btnSetEquipmentOffHand;
        private System.Windows.Forms.Button btnSetEquipmentMainHand;
        private System.Windows.Forms.ComboBox cmbSetEquipmentUseDefault;
        private System.Windows.Forms.Label lblSetEquipmentUseDefault;
        private System.Windows.Forms.Panel frmCommandSetMovement;
        private System.Windows.Forms.Label lblSetMovementAngle;
        private System.Windows.Forms.TextBox txtSetMovementAngle;
        private System.Windows.Forms.TextBox txtSetMovementDistance;
        private System.Windows.Forms.TextBox txtSetMovementIntParam;
        private System.Windows.Forms.ComboBox cmbSetMovementBoolParam;
        private System.Windows.Forms.Label lblSetMovementDistance;
        private System.Windows.Forms.Label lblSetMovementIntParam;
        private System.Windows.Forms.Label lblSetMovementBoolParam;
        private System.Windows.Forms.ComboBox cmbSetMovementType;
        private System.Windows.Forms.Label lblSetMovementType;
        private System.Windows.Forms.Label lblSetMovementTooltip;
        private System.Windows.Forms.Panel frmCommandActiveObject;
        private System.Windows.Forms.ComboBox cmbActiveObjectSetActive;
        private System.Windows.Forms.Label lblActiveObjectSetActive;
        private System.Windows.Forms.Label lblActiveObjectTooltip;
        private System.Windows.Forms.Panel frmCommandSetFaction;
        private System.Windows.Forms.GroupBox grpSetFactionFlags;
        private System.Windows.Forms.CheckBox chkSetFactionFlag4;
        private System.Windows.Forms.CheckBox chkSetFactionFlag2;
        private System.Windows.Forms.CheckBox chkSetFactionFlag1;
        private System.Windows.Forms.Label lblSetFactionId;
        private System.Windows.Forms.Label lblSetFactionTooltip;
        private System.Windows.Forms.Panel frmCommandMorphOrMount;
        private System.Windows.Forms.ComboBox cmbMorphOrMountType;
        private System.Windows.Forms.Label lblMorphOrMountId;
        private System.Windows.Forms.Label lblMorphOrMountType;
        private System.Windows.Forms.Button btnMorphOrMountId;
        private System.Windows.Forms.Label lblMorphOrMountTooltip;
        private System.Windows.Forms.Panel frmCommandSetRun;
        private System.Windows.Forms.ComboBox cmbSetRunMode;
        private System.Windows.Forms.Label lblSetRunMode;
        private System.Windows.Forms.Label lblSetRunTooltip;
        private System.Windows.Forms.Panel frmCommandModifyFlags;
        private System.Windows.Forms.Label lblModifyFlagsTooltip;
        private System.Windows.Forms.Label lblModifyFlagsField;
        private System.Windows.Forms.CheckBox chkModifyFlags536870912;
        private System.Windows.Forms.CheckBox chkModifyFlags268435456;
        private System.Windows.Forms.CheckBox chkModifyFlags134217728;
        private System.Windows.Forms.CheckBox chkModifyFlags67108864;
        private System.Windows.Forms.CheckBox chkModifyFlags33554432;
        private System.Windows.Forms.CheckBox chkModifyFlags16777216;
        private System.Windows.Forms.CheckBox chkModifyFlags8388608;
        private System.Windows.Forms.CheckBox chkModifyFlags4194304;
        private System.Windows.Forms.CheckBox chkModifyFlags2097152;
        private System.Windows.Forms.CheckBox chkModifyFlags1048576;
        private System.Windows.Forms.CheckBox chkModifyFlags524288;
        private System.Windows.Forms.CheckBox chkModifyFlags262144;
        private System.Windows.Forms.CheckBox chkModifyFlags131072;
        private System.Windows.Forms.CheckBox chkModifyFlags65536;
        private System.Windows.Forms.CheckBox chkModifyFlags32768;
        private System.Windows.Forms.CheckBox chkModifyFlags16384;
        private System.Windows.Forms.CheckBox chkModifyFlags8192;
        private System.Windows.Forms.CheckBox chkModifyFlags4096;
        private System.Windows.Forms.CheckBox chkModifyFlags2048;
        private System.Windows.Forms.CheckBox chkModifyFlags1024;
        private System.Windows.Forms.CheckBox chkModifyFlags512;
        private System.Windows.Forms.CheckBox chkModifyFlags256;
        private System.Windows.Forms.CheckBox chkModifyFlags128;
        private System.Windows.Forms.CheckBox chkModifyFlags64;
        private System.Windows.Forms.CheckBox chkModifyFlags32;
        private System.Windows.Forms.CheckBox chkModifyFlags16;
        private System.Windows.Forms.CheckBox chkModifyFlags8;
        private System.Windows.Forms.CheckBox chkModifyFlags4;
        private System.Windows.Forms.CheckBox chkModifyFlags2;
        private System.Windows.Forms.CheckBox chkModifyFlags1;
        private System.Windows.Forms.ComboBox cmbModifyFlagsMode;
        private System.Windows.Forms.Label lblModifyFlagsMode;
        private System.Windows.Forms.ComboBox cmbModifyFlagsFieldId;
        private System.Windows.Forms.Panel frmCommandInterruptCasts;
        private System.Windows.Forms.ComboBox cmbInterruptCastsWithDelayed;
        private System.Windows.Forms.Label lblInterruptCastsSpellId;
        private System.Windows.Forms.Label lblInterruptCastsWithDelayed;
        private System.Windows.Forms.Button btnInterruptCastsSpellId;
        private System.Windows.Forms.Label lblInterruptCastsTooltip;
        private System.Windows.Forms.Panel frmCommandUpdateEntry;
        private System.Windows.Forms.ComboBox cmbUpdateEntryTeam;
        private System.Windows.Forms.Label lblUpdateEntryCreatureId;
        private System.Windows.Forms.Label lblUpdateEntryTeam;
        private System.Windows.Forms.Button btnUpdateEntryCreatureId;
        private System.Windows.Forms.Label lblUpdateEntryTooltip;
        private System.Windows.Forms.Panel frmCommandSetStandState;
        private System.Windows.Forms.ComboBox cmbSetStandState;
        private System.Windows.Forms.Label lblSetStandState;
        private System.Windows.Forms.Label lblSetStandStateTooltip;
        private System.Windows.Forms.Panel frmCommandModifyThreat;
        private System.Windows.Forms.Label lblModifyThreatPercent;
        private System.Windows.Forms.TextBox txtModifyThreatPercent;
        private System.Windows.Forms.ComboBox cmbModifyThreatTarget;
        private System.Windows.Forms.Label lblModifyThreatTarget;
        private System.Windows.Forms.Label lblModifyThreatTooltip;
        private System.Windows.Forms.Panel frmCommandSendTaxiPath;
        private System.Windows.Forms.Label lblSendTaxiPathId;
        private System.Windows.Forms.Label lblSendTaxiPathTooltip;
        private System.Windows.Forms.Label lblSendTaxiPath;
        private System.Windows.Forms.TextBox txtSendTaxiPath;
        private System.Windows.Forms.Button btnSendTaxiPathId;
        private System.Windows.Forms.Panel frmCommandTerminateScript;
        private System.Windows.Forms.Label lblTerminateScriptCondition;
        private System.Windows.Forms.ComboBox cmbTerminateScriptCondition;
        private System.Windows.Forms.Label lblTerminateScriptCreatureId;
        private System.Windows.Forms.Label lblTerminateScriptSearchRadius;
        private System.Windows.Forms.TextBox txtTerminateScriptSearchRadius;
        private System.Windows.Forms.Button btnTerminateScriptCreatureId;
        private System.Windows.Forms.Label lblTerminateScriptTooltip;
        private System.Windows.Forms.Panel frmCommandTerminateCondition;
        private System.Windows.Forms.Button btnTerminateConditionQuest;
        private System.Windows.Forms.Label lblTerminateConditionRule;
        private System.Windows.Forms.ComboBox cmbTerminateConditionRule;
        private System.Windows.Forms.Label lblTerminateConditionId;
        private System.Windows.Forms.Label lblTerminateConditionQuestId;
        private System.Windows.Forms.Button btnTerminateConditionId;
        private System.Windows.Forms.Label lblTerminateConditionTooltip;
        private System.Windows.Forms.Panel frmCommandSetHomePosition;
        private System.Windows.Forms.TextBox txtSetHomePositionY;
        private System.Windows.Forms.TextBox txtSetHomePositionX;
        private System.Windows.Forms.ComboBox cmbSetHomePositionMode;
        private System.Windows.Forms.Label lblSetHomePositionMode;
        private System.Windows.Forms.Label lblSetHomePositionTooltip;
        private System.Windows.Forms.Label lblSetHomePositionO;
        private System.Windows.Forms.Label lblSetHomePositionZ;
        private System.Windows.Forms.TextBox txtSetHomePositionO;
        private System.Windows.Forms.TextBox txtSetHomePositionZ;
        private System.Windows.Forms.Label lblSetHomePositionY;
        private System.Windows.Forms.Label lblSetHomePositionX;
        private System.Windows.Forms.Panel frmCommandSetFacing;
        private System.Windows.Forms.Label lblSetFacingOrientation;
        private System.Windows.Forms.TextBox txtSetFacingOrientation;
        private System.Windows.Forms.ComboBox cmbSetFacingMode;
        private System.Windows.Forms.Label lblSetFacingMode;
        private System.Windows.Forms.Label lblSetFacingTooltip;
        private System.Windows.Forms.Panel frmCommandMeetingStone;
        private System.Windows.Forms.Button btnMeetingStoneAreaId;
        private System.Windows.Forms.Label lblMeetingStoneAreaId;
        private System.Windows.Forms.Label lblMeetingStoneTooltip;
        private System.Windows.Forms.Panel frmCommandSetData;
        private System.Windows.Forms.Label lblSetDataField;
        private System.Windows.Forms.TextBox txtSetDataField;
        private System.Windows.Forms.ComboBox cmbSetDataMode;
        private System.Windows.Forms.Label lblSetDataMode;
        private System.Windows.Forms.Label lblSetDataTooltip;
        private System.Windows.Forms.Label lblSetDataValue;
        private System.Windows.Forms.TextBox txtSetDataValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCommandCondition;
        private System.Windows.Forms.Label lblCommandCondition;
        private System.Windows.Forms.Button btnPlaySoundId;
        private System.Windows.Forms.Button btnSetFactionId;
        private System.Windows.Forms.Panel frmCommandStartScript;
        private System.Windows.Forms.TextBox txtStartScriptChance4;
        private System.Windows.Forms.TextBox txtStartScriptId4;
        private System.Windows.Forms.TextBox txtStartScriptChance3;
        private System.Windows.Forms.TextBox txtStartScriptId3;
        private System.Windows.Forms.TextBox txtStartScriptChance2;
        private System.Windows.Forms.TextBox txtStartScriptId2;
        private System.Windows.Forms.TextBox txtStartScriptChance1;
        private System.Windows.Forms.TextBox txtStartScriptId1;
        private System.Windows.Forms.Label lblStartScriptChance;
        private System.Windows.Forms.Label lblStartScriptId;
        private System.Windows.Forms.Label lblStartScriptTooltip;
        private System.Windows.Forms.Button btnStartScriptEdit4;
        private System.Windows.Forms.Button btnStartScriptEdit3;
        private System.Windows.Forms.Button btnStartScriptEdit2;
        private System.Windows.Forms.Button btnStartScriptEdit1;
        private System.Windows.Forms.Label lblNoAction;
        private System.Windows.Forms.CheckBox chkMoveToFlagsPointMovement;
        private System.Windows.Forms.Button btnActionCopy;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags1;
        private System.Windows.Forms.Label lblSummonCreatureDespawnType;
        private System.Windows.Forms.ComboBox cmbSummonCreatureDespawnType;
        private System.Windows.Forms.Button btnViewRaw;
        private System.Windows.Forms.Panel frmCommandSetPhase;
        private System.Windows.Forms.Label lblSetPhasePhase;
        private System.Windows.Forms.Label lblSetPhaseMode;
        private System.Windows.Forms.TextBox txtSetPhasePhase;
        private System.Windows.Forms.ComboBox cmbSetPhaseMode;
        private System.Windows.Forms.Label lblSetPhaseTooltip;
        private System.Windows.Forms.Panel frmCommandSetRandomPhase;
        private System.Windows.Forms.Label lblSetRandomPhase4;
        private System.Windows.Forms.TextBox txtSetRandomPhase4;
        private System.Windows.Forms.Label lblSetRandomPhase3;
        private System.Windows.Forms.TextBox txtSetRandomPhase3;
        private System.Windows.Forms.TextBox txtSetRandomPhase1;
        private System.Windows.Forms.Label lblSetRandomPhase2;
        private System.Windows.Forms.Label lblSetRandomPhase1;
        private System.Windows.Forms.TextBox txtSetRandomPhase2;
        private System.Windows.Forms.Label lblSetRandomPhaseTooltip;
        private System.Windows.Forms.Panel frmCommandFlee;
        private System.Windows.Forms.ComboBox cmbFleeMode;
        private System.Windows.Forms.Label lblFleeMode;
        private System.Windows.Forms.Label lblFleeTooltip;
        private System.Windows.Forms.Panel frmCommandCallForHelp;
        private System.Windows.Forms.Label lblCallForHelpRadius;
        private System.Windows.Forms.TextBox txtCallForHelpRadius;
        private System.Windows.Forms.Label lblCallForHelpTooltip;
        private System.Windows.Forms.Panel frmCommandGameEvent;
        private System.Windows.Forms.ComboBox cmbGameEventAction;
        private System.Windows.Forms.Label lblGameEventId;
        private System.Windows.Forms.Label lblGameEventAction;
        private System.Windows.Forms.Button btnGameEventId;
        private System.Windows.Forms.Label lblCommandGameEventTooltip;
        private System.Windows.Forms.ComboBox cmbGameEventOverwrite;
        private System.Windows.Forms.Label lblGameEventOverwrite;
        private System.Windows.Forms.CheckBox chkCastSpellFlags4;
        private System.Windows.Forms.CheckBox chkCastSpellFlags32;
        private System.Windows.Forms.CheckBox chkCastSpellFlags16;
        private System.Windows.Forms.Panel frmCommandSetSpellsTemplate;
        private System.Windows.Forms.Button btnSetSpellsTemplate4;
        private System.Windows.Forms.TextBox txtSetSpellsTemplateChance4;
        private System.Windows.Forms.Button btnSetSpellsTemplate3;
        private System.Windows.Forms.TextBox txtSetSpellsTemplateChance3;
        private System.Windows.Forms.Button btnSetSpellsTemplate2;
        private System.Windows.Forms.TextBox txtSetSpellsTemplateChance2;
        private System.Windows.Forms.Button btnSetSpellsTemplate1;
        private System.Windows.Forms.TextBox txtSetSpellsTemplateChance1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSetSpellsTempalteId;
        private System.Windows.Forms.Label lblSetSpellsTemplateTooltip;
        private System.Windows.Forms.CheckBox chkCastSpellFlags128;
        private System.Windows.Forms.CheckBox chkCastSpellFlags64;
    }
}

