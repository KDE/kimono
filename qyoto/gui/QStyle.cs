//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyle")]
	public class QStyle : QObject {
 		protected QStyle(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyle")]
		interface IQStyleProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("visualRect", "(Qt::LayoutDirection, const QRect&, const QRect&)", "$##")]
			QRect VisualRect(Qt.LayoutDirection direction, QRect boundingRect, QRect logicalRect);
			[SmokeMethod("visualPos", "(Qt::LayoutDirection, const QRect&, const QPoint&)", "$##")]
			QPoint VisualPos(Qt.LayoutDirection direction, QRect boundingRect, QPoint logicalPos);
			[SmokeMethod("sliderPositionFromValue", "(int, int, int, int, bool)", "$$$$$")]
			int SliderPositionFromValue(int min, int max, int val, int space, bool upsideDown);
			[SmokeMethod("sliderPositionFromValue", "(int, int, int, int)", "$$$$")]
			int SliderPositionFromValue(int min, int max, int val, int space);
			[SmokeMethod("sliderValueFromPosition", "(int, int, int, int, bool)", "$$$$$")]
			int SliderValueFromPosition(int min, int max, int pos, int space, bool upsideDown);
			[SmokeMethod("sliderValueFromPosition", "(int, int, int, int)", "$$$$")]
			int SliderValueFromPosition(int min, int max, int pos, int space);
			[SmokeMethod("visualAlignment", "(Qt::LayoutDirection, Qt::Alignment)", "$$")]
			int VisualAlignment(Qt.LayoutDirection direction, int alignment);
			[SmokeMethod("alignedRect", "(Qt::LayoutDirection, Qt::Alignment, const QSize&, const QRect&)", "$$##")]
			QRect AlignedRect(Qt.LayoutDirection direction, int alignment, QSize size, QRect rectangle);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyle), this);
			_interceptor = (QStyle) realProxy.GetTransparentProxy();
		}
		private QStyle ProxyQStyle() {
			return (QStyle) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyle() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleProxy), null);
			_staticInterceptor = (IQStyleProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleProxy StaticQStyle() {
			return (IQStyleProxy) _staticInterceptor;
		}
		public enum StateFlag {
			State_None = 0x00000000,
			State_Enabled = 0x00000001,
			State_Raised = 0x00000002,
			State_Sunken = 0x00000004,
			State_Off = 0x00000008,
			State_NoChange = 0x00000010,
			State_On = 0x00000020,
			State_DownArrow = 0x00000040,
			State_Horizontal = 0x00000080,
			State_HasFocus = 0x00000100,
			State_Top = 0x00000200,
			State_Bottom = 0x00000400,
			State_FocusAtBorder = 0x00000800,
			State_AutoRaise = 0x00001000,
			State_MouseOver = 0x00002000,
			State_UpArrow = 0x00004000,
			State_Selected = 0x00008000,
			State_Active = 0x00010000,
			State_Open = 0x00040000,
			State_Children = 0x00080000,
			State_Item = 0x00100000,
			State_Sibling = 0x00200000,
			State_Editing = 0x00400000,
			State_KeyboardFocusChange = 0x00800000,
			State_ReadOnly = 0x02000000,
		}
		public enum PrimitiveElement {
			PE_Q3CheckListController = 0,
			PE_Q3CheckListExclusiveIndicator = 1,
			PE_Q3CheckListIndicator = 2,
			PE_Q3DockWindowSeparator = 3,
			PE_Q3Separator = 4,
			PE_Frame = 5,
			PE_FrameDefaultButton = 6,
			PE_FrameDockWidget = 7,
			PE_FrameFocusRect = 8,
			PE_FrameGroupBox = 9,
			PE_FrameLineEdit = 10,
			PE_FrameMenu = 11,
			PE_FrameStatusBar = 12,
			PE_FrameTabWidget = 13,
			PE_FrameWindow = 14,
			PE_FrameButtonBevel = 15,
			PE_FrameButtonTool = 16,
			PE_FrameTabBarBase = 17,
			PE_PanelButtonCommand = 18,
			PE_PanelButtonBevel = 19,
			PE_PanelButtonTool = 20,
			PE_PanelMenuBar = 21,
			PE_PanelToolBar = 22,
			PE_PanelLineEdit = 23,
			PE_IndicatorArrowDown = 24,
			PE_IndicatorArrowLeft = 25,
			PE_IndicatorArrowRight = 26,
			PE_IndicatorArrowUp = 27,
			PE_IndicatorBranch = 28,
			PE_IndicatorButtonDropDown = 29,
			PE_IndicatorViewItemCheck = 30,
			PE_IndicatorCheckBox = 31,
			PE_IndicatorDockWidgetResizeHandle = 32,
			PE_IndicatorHeaderArrow = 33,
			PE_IndicatorMenuCheckMark = 34,
			PE_IndicatorProgressChunk = 35,
			PE_IndicatorRadioButton = 36,
			PE_IndicatorSpinDown = 37,
			PE_IndicatorSpinMinus = 38,
			PE_IndicatorSpinPlus = 39,
			PE_IndicatorSpinUp = 40,
			PE_IndicatorToolBarHandle = 41,
			PE_IndicatorToolBarSeparator = 42,
			PE_PanelTipLabel = 43,
			PE_IndicatorTabTear = 44,
			PE_PanelScrollAreaCorner = 45,
			PE_Widget = 46,
			PE_CustomBase = 0xf000000,
		}
		public enum ControlElement : uint {
			CE_PushButton = 0,
			CE_PushButtonBevel = 1,
			CE_PushButtonLabel = 2,
			CE_CheckBox = 3,
			CE_CheckBoxLabel = 4,
			CE_RadioButton = 5,
			CE_RadioButtonLabel = 6,
			CE_TabBarTab = 7,
			CE_TabBarTabShape = 8,
			CE_TabBarTabLabel = 9,
			CE_ProgressBar = 10,
			CE_ProgressBarGroove = 11,
			CE_ProgressBarContents = 12,
			CE_ProgressBarLabel = 13,
			CE_MenuItem = 14,
			CE_MenuScroller = 15,
			CE_MenuVMargin = 16,
			CE_MenuHMargin = 17,
			CE_MenuTearoff = 18,
			CE_MenuEmptyArea = 19,
			CE_MenuBarItem = 20,
			CE_MenuBarEmptyArea = 21,
			CE_ToolButtonLabel = 22,
			CE_Header = 23,
			CE_HeaderSection = 24,
			CE_HeaderLabel = 25,
			CE_Q3DockWindowEmptyArea = 26,
			CE_ToolBoxTab = 27,
			CE_SizeGrip = 28,
			CE_Splitter = 29,
			CE_RubberBand = 30,
			CE_DockWidgetTitle = 31,
			CE_ScrollBarAddLine = 32,
			CE_ScrollBarSubLine = 33,
			CE_ScrollBarAddPage = 34,
			CE_ScrollBarSubPage = 35,
			CE_ScrollBarSlider = 36,
			CE_ScrollBarFirst = 37,
			CE_ScrollBarLast = 38,
			CE_FocusFrame = 39,
			CE_ComboBoxLabel = 40,
			CE_ToolBar = 41,
			CE_CustomBase = 0xf0000000,
		}
		public enum SubElement : uint {
			SE_PushButtonContents = 0,
			SE_PushButtonFocusRect = 1,
			SE_CheckBoxIndicator = 2,
			SE_CheckBoxContents = 3,
			SE_CheckBoxFocusRect = 4,
			SE_CheckBoxClickRect = 5,
			SE_RadioButtonIndicator = 6,
			SE_RadioButtonContents = 7,
			SE_RadioButtonFocusRect = 8,
			SE_RadioButtonClickRect = 9,
			SE_ComboBoxFocusRect = 10,
			SE_SliderFocusRect = 11,
			SE_Q3DockWindowHandleRect = 12,
			SE_ProgressBarGroove = 13,
			SE_ProgressBarContents = 14,
			SE_ProgressBarLabel = 15,
			SE_DialogButtonAccept = 16,
			SE_DialogButtonReject = 17,
			SE_DialogButtonApply = 18,
			SE_DialogButtonHelp = 19,
			SE_DialogButtonAll = 20,
			SE_DialogButtonAbort = 21,
			SE_DialogButtonIgnore = 22,
			SE_DialogButtonRetry = 23,
			SE_DialogButtonCustom = 24,
			SE_ToolBoxTabContents = 25,
			SE_HeaderLabel = 26,
			SE_HeaderArrow = 27,
			SE_TabWidgetTabBar = 28,
			SE_TabWidgetTabPane = 29,
			SE_TabWidgetTabContents = 30,
			SE_TabWidgetLeftCorner = 31,
			SE_TabWidgetRightCorner = 32,
			SE_ViewItemCheckIndicator = 33,
			SE_TabBarTearIndicator = 34,
			SE_TreeViewDisclosureItem = 35,
			SE_LineEditContents = 36,
			SE_FrameContents = 37,
			SE_CustomBase = 0xf0000000,
		}
		public enum ComplexControl : uint {
			CC_SpinBox = 0,
			CC_ComboBox = 1,
			CC_ScrollBar = 2,
			CC_Slider = 3,
			CC_ToolButton = 4,
			CC_TitleBar = 5,
			CC_Q3ListView = 6,
			CC_Dial = 7,
			CC_GroupBox = 8,
			CC_CustomBase = 0xf0000000,
		}
		public enum SubControl : uint {
			SC_None = 0x00000000,
			SC_ScrollBarAddLine = 0x00000001,
			SC_ScrollBarSubLine = 0x00000002,
			SC_ScrollBarAddPage = 0x00000004,
			SC_ScrollBarSubPage = 0x00000008,
			SC_ScrollBarFirst = 0x00000010,
			SC_ScrollBarLast = 0x00000020,
			SC_ScrollBarSlider = 0x00000040,
			SC_ScrollBarGroove = 0x00000080,
			SC_SpinBoxUp = 0x00000001,
			SC_SpinBoxDown = 0x00000002,
			SC_SpinBoxFrame = 0x00000004,
			SC_SpinBoxEditField = 0x00000008,
			SC_ComboBoxFrame = 0x00000001,
			SC_ComboBoxEditField = 0x00000002,
			SC_ComboBoxArrow = 0x00000004,
			SC_ComboBoxListBoxPopup = 0x00000008,
			SC_SliderGroove = 0x00000001,
			SC_SliderHandle = 0x00000002,
			SC_SliderTickmarks = 0x00000004,
			SC_ToolButton = 0x00000001,
			SC_ToolButtonMenu = 0x00000002,
			SC_TitleBarSysMenu = 0x00000001,
			SC_TitleBarMinButton = 0x00000002,
			SC_TitleBarMaxButton = 0x00000004,
			SC_TitleBarCloseButton = 0x00000008,
			SC_TitleBarNormalButton = 0x00000010,
			SC_TitleBarShadeButton = 0x00000020,
			SC_TitleBarUnshadeButton = 0x00000040,
			SC_TitleBarContextHelpButton = 0x00000080,
			SC_TitleBarLabel = 0x00000100,
			SC_Q3ListView = 0x00000001,
			SC_Q3ListViewBranch = 0x00000002,
			SC_Q3ListViewExpand = 0x00000004,
			SC_DialGroove = 0x00000001,
			SC_DialHandle = 0x00000002,
			SC_DialTickmarks = 0x00000004,
			SC_GroupBoxCheckBox = 0x00000001,
			SC_GroupBoxLabel = 0x00000002,
			SC_GroupBoxContents = 0x00000004,
			SC_GroupBoxFrame = 0x00000008,
			SC_All = 0xffffffff,
		}
		public enum PixelMetric : uint {
			PM_ButtonMargin = 0,
			PM_ButtonDefaultIndicator = 1,
			PM_MenuButtonIndicator = 2,
			PM_ButtonShiftHorizontal = 3,
			PM_ButtonShiftVertical = 4,
			PM_DefaultFrameWidth = 5,
			PM_SpinBoxFrameWidth = 6,
			PM_ComboBoxFrameWidth = 7,
			PM_MaximumDragDistance = 8,
			PM_ScrollBarExtent = 9,
			PM_ScrollBarSliderMin = 10,
			PM_SliderThickness = 11,
			PM_SliderControlThickness = 12,
			PM_SliderLength = 13,
			PM_SliderTickmarkOffset = 14,
			PM_SliderSpaceAvailable = 15,
			PM_DockWidgetSeparatorExtent = 16,
			PM_DockWidgetHandleExtent = 17,
			PM_DockWidgetFrameWidth = 18,
			PM_TabBarTabOverlap = 19,
			PM_TabBarTabHSpace = 20,
			PM_TabBarTabVSpace = 21,
			PM_TabBarBaseHeight = 22,
			PM_TabBarBaseOverlap = 23,
			PM_ProgressBarChunkWidth = 24,
			PM_SplitterWidth = 25,
			PM_TitleBarHeight = 26,
			PM_MenuScrollerHeight = 27,
			PM_MenuHMargin = 28,
			PM_MenuVMargin = 29,
			PM_MenuPanelWidth = 30,
			PM_MenuTearoffHeight = 31,
			PM_MenuDesktopFrameWidth = 32,
			PM_MenuBarPanelWidth = 33,
			PM_MenuBarItemSpacing = 34,
			PM_MenuBarVMargin = 35,
			PM_MenuBarHMargin = 36,
			PM_IndicatorWidth = 37,
			PM_IndicatorHeight = 38,
			PM_ExclusiveIndicatorWidth = 39,
			PM_ExclusiveIndicatorHeight = 40,
			PM_CheckListButtonSize = 41,
			PM_CheckListControllerSize = 42,
			PM_DialogButtonsSeparator = 43,
			PM_DialogButtonsButtonWidth = 44,
			PM_DialogButtonsButtonHeight = 45,
			PM_MDIFrameWidth = 46,
			PM_MDIMinimizedWidth = 47,
			PM_HeaderMargin = 48,
			PM_HeaderMarkSize = 49,
			PM_HeaderGripMargin = 50,
			PM_TabBarTabShiftHorizontal = 51,
			PM_TabBarTabShiftVertical = 52,
			PM_TabBarScrollButtonWidth = 53,
			PM_ToolBarFrameWidth = 54,
			PM_ToolBarHandleExtent = 55,
			PM_ToolBarItemSpacing = 56,
			PM_ToolBarItemMargin = 57,
			PM_ToolBarSeparatorExtent = 58,
			PM_ToolBarExtensionExtent = 59,
			PM_SpinBoxSliderHeight = 60,
			PM_DefaultTopLevelMargin = 61,
			PM_DefaultChildMargin = 62,
			PM_DefaultLayoutSpacing = 63,
			PM_ToolBarIconSize = 64,
			PM_ListViewIconSize = 65,
			PM_IconViewIconSize = 66,
			PM_SmallIconSize = 67,
			PM_LargeIconSize = 68,
			PM_FocusFrameVMargin = 69,
			PM_FocusFrameHMargin = 70,
			PM_ToolTipLabelFrameWidth = 71,
			PM_CheckBoxLabelSpacing = 72,
			PM_TabBarIconSize = 73,
			PM_SizeGripSize = 74,
			PM_DockWidgetTitleMargin = 75,
			PM_MessageBoxIconSize = 76,
			PM_ButtonIconSize = 77,
			PM_CustomBase = 0xf0000000,
		}
		public enum ContentsType : uint {
			CT_PushButton = 0,
			CT_CheckBox = 1,
			CT_RadioButton = 2,
			CT_ToolButton = 3,
			CT_ComboBox = 4,
			CT_Splitter = 5,
			CT_Q3DockWindow = 6,
			CT_ProgressBar = 7,
			CT_MenuItem = 8,
			CT_MenuBarItem = 9,
			CT_MenuBar = 10,
			CT_Menu = 11,
			CT_TabBarTab = 12,
			CT_Slider = 13,
			CT_ScrollBar = 14,
			CT_Q3Header = 15,
			CT_LineEdit = 16,
			CT_SpinBox = 17,
			CT_SizeGrip = 18,
			CT_TabWidget = 19,
			CT_DialogButtons = 20,
			CT_HeaderSection = 21,
			CT_GroupBox = 22,
			CT_CustomBase = 0xf0000000,
		}
		public enum StyleHint : uint {
			SH_EtchDisabledText = 0,
			SH_DitherDisabledText = 1,
			SH_ScrollBar_MiddleClickAbsolutePosition = 2,
			SH_ScrollBar_ScrollWhenPointerLeavesControl = 3,
			SH_TabBar_SelectMouseType = 4,
			SH_TabBar_Alignment = 5,
			SH_Header_ArrowAlignment = 6,
			SH_Slider_SnapToValue = 7,
			SH_Slider_SloppyKeyEvents = 8,
			SH_ProgressDialog_CenterCancelButton = 9,
			SH_ProgressDialog_TextLabelAlignment = 10,
			SH_PrintDialog_RightAlignButtons = 11,
			SH_MainWindow_SpaceBelowMenuBar = 12,
			SH_FontDialog_SelectAssociatedText = 13,
			SH_Menu_AllowActiveAndDisabled = 14,
			SH_Menu_SpaceActivatesItem = 15,
			SH_Menu_SubMenuPopupDelay = 16,
			SH_ScrollView_FrameOnlyAroundContents = 17,
			SH_MenuBar_AltKeyNavigation = 18,
			SH_ComboBox_ListMouseTracking = 19,
			SH_Menu_MouseTracking = 20,
			SH_MenuBar_MouseTracking = 21,
			SH_ItemView_ChangeHighlightOnFocus = 22,
			SH_Widget_ShareActivation = 23,
			SH_Workspace_FillSpaceOnMaximize = 24,
			SH_ComboBox_Popup = 25,
			SH_TitleBar_NoBorder = 26,
			SH_Slider_StopMouseOverSlider = 27,
			SH_ScrollBar_StopMouseOverSlider = QStyle.StyleHint.SH_Slider_StopMouseOverSlider,
			SH_BlinkCursorWhenTextSelected = 28,
			SH_RichText_FullWidthSelection = 29,
			SH_Menu_Scrollable = 30,
			SH_GroupBox_TextLabelVerticalAlignment = 31,
			SH_GroupBox_TextLabelColor = 32,
			SH_Menu_SloppySubMenus = 33,
			SH_Table_GridLineColor = 34,
			SH_LineEdit_PasswordCharacter = 35,
			SH_DialogButtons_DefaultButton = 36,
			SH_ToolBox_SelectedPageTitleBold = 37,
			SH_TabBar_PreferNoArrows = 38,
			SH_ScrollBar_LeftClickAbsolutePosition = 39,
			SH_Q3ListViewExpand_SelectMouseType = 40,
			SH_UnderlineShortcut = 41,
			SH_SpinBox_AnimateButton = 42,
			SH_SpinBox_KeyPressAutoRepeatRate = 43,
			SH_SpinBox_ClickAutoRepeatRate = 44,
			SH_Menu_FillScreenWithScroll = 45,
			SH_ToolTipLabel_Opacity = 46,
			SH_DrawMenuBarSeparator = 47,
			SH_TitleBar_ModifyNotification = 48,
			SH_Button_FocusPolicy = 49,
			SH_MenuBar_DismissOnSecondClick = 50,
			SH_MessageBox_UseBorderForButtonSpacing = 51,
			SH_TitleBar_AutoRaise = 52,
			SH_ToolButton_PopupDelay = 53,
			SH_FocusFrame_Mask = 54,
			SH_RubberBand_Mask = 55,
			SH_WindowFrame_Mask = 56,
			SH_SpinControls_DisableOnBounds = 57,
			SH_Dial_BackgroundRole = 58,
			SH_ComboBox_LayoutDirection = 59,
			SH_ItemView_EllipsisLocation = 60,
			SH_ItemView_ShowDecorationSelected = 61,
			SH_ItemView_ActivateItemOnSingleClick = 62,
			SH_ScrollBar_ContextMenu = 63,
			SH_ScrollBar_RollBetweenButtons = 64,
			SH_Slider_AbsoluteSetButtons = 65,
			SH_Slider_PageSetButtons = 66,
			SH_Menu_KeyboardSearch = 67,
			SH_TabBar_ElideMode = 68,
			SH_DialogButtonLayout = 69,
			SH_ComboBox_PopupFrameStyle = 70,
			SH_MessageBox_TextInteractionFlags = 71,
			SH_DialogButtonBox_ButtonsHaveIcons = 72,
			SH_SpellCheckUnderlineStyle = 73,
			SH_MessageBox_CenterButtons = 74,
			SH_Menu_SelectionWrap = 75,
			SH_ItemView_MovementWithoutUpdatingSelection = 76,
			SH_CustomBase = 0xf0000000,
		}
		public enum StandardPixmap : uint {
			SP_TitleBarMenuButton = 0,
			SP_TitleBarMinButton = 1,
			SP_TitleBarMaxButton = 2,
			SP_TitleBarCloseButton = 3,
			SP_TitleBarNormalButton = 4,
			SP_TitleBarShadeButton = 5,
			SP_TitleBarUnshadeButton = 6,
			SP_TitleBarContextHelpButton = 7,
			SP_DockWidgetCloseButton = 8,
			SP_MessageBoxInformation = 9,
			SP_MessageBoxWarning = 10,
			SP_MessageBoxCritical = 11,
			SP_MessageBoxQuestion = 12,
			SP_DesktopIcon = 13,
			SP_TrashIcon = 14,
			SP_ComputerIcon = 15,
			SP_DriveFDIcon = 16,
			SP_DriveHDIcon = 17,
			SP_DriveCDIcon = 18,
			SP_DriveDVDIcon = 19,
			SP_DriveNetIcon = 20,
			SP_DirOpenIcon = 21,
			SP_DirClosedIcon = 22,
			SP_DirLinkIcon = 23,
			SP_FileIcon = 24,
			SP_FileLinkIcon = 25,
			SP_ToolBarHorizontalExtensionButton = 26,
			SP_ToolBarVerticalExtensionButton = 27,
			SP_FileDialogStart = 28,
			SP_FileDialogEnd = 29,
			SP_FileDialogToParent = 30,
			SP_FileDialogNewFolder = 31,
			SP_FileDialogDetailedView = 32,
			SP_FileDialogInfoView = 33,
			SP_FileDialogContentsView = 34,
			SP_FileDialogListView = 35,
			SP_FileDialogBack = 36,
			SP_DirIcon = 37,
			SP_DialogOkButton = 38,
			SP_DialogCancelButton = 39,
			SP_DialogHelpButton = 40,
			SP_DialogOpenButton = 41,
			SP_DialogSaveButton = 42,
			SP_DialogCloseButton = 43,
			SP_DialogApplyButton = 44,
			SP_DialogResetButton = 45,
			SP_DialogDiscardButton = 46,
			SP_DialogYesButton = 47,
			SP_DialogNoButton = 48,
			SP_ArrowUp = 49,
			SP_ArrowDown = 50,
			SP_ArrowLeft = 51,
			SP_ArrowRight = 52,
			SP_ArrowBack = 53,
			SP_ArrowForward = 54,
			SP_CustomBase = 0xf0000000,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QStyle() : this((Type) null) {
			CreateProxy();
			NewQStyle();
		}
		[SmokeMethod("QStyle", "()", "")]
		private void NewQStyle() {
			ProxyQStyle().NewQStyle();
		}
		[SmokeMethod("polish", "(QWidget*)", "#")]
		public virtual void Polish(QWidget arg1) {
			ProxyQStyle().Polish(arg1);
		}
		[SmokeMethod("unpolish", "(QWidget*)", "#")]
		public virtual void Unpolish(QWidget arg1) {
			ProxyQStyle().Unpolish(arg1);
		}
		[SmokeMethod("polish", "(QApplication*)", "#")]
		public virtual void Polish(QApplication arg1) {
			ProxyQStyle().Polish(arg1);
		}
		[SmokeMethod("unpolish", "(QApplication*)", "#")]
		public virtual void Unpolish(QApplication arg1) {
			ProxyQStyle().Unpolish(arg1);
		}
		[SmokeMethod("polish", "(QPalette&)", "#")]
		public virtual void Polish(QPalette arg1) {
			ProxyQStyle().Polish(arg1);
		}
		[SmokeMethod("itemTextRect", "(const QFontMetrics&, const QRect&, int, bool, const QString&) const", "##$$$")]
		public virtual QRect ItemTextRect(QFontMetrics fm, QRect r, int flags, bool enabled, string text) {
			return ProxyQStyle().ItemTextRect(fm,r,flags,enabled,text);
		}
		[SmokeMethod("itemPixmapRect", "(const QRect&, int, const QPixmap&) const", "#$#")]
		public virtual QRect ItemPixmapRect(QRect r, int flags, QPixmap pixmap) {
			return ProxyQStyle().ItemPixmapRect(r,flags,pixmap);
		}
		[SmokeMethod("drawItemText", "(QPainter*, const QRect&, int, const QPalette&, bool, const QString&, QPalette::ColorRole) const", "##$#$$$")]
		public virtual void DrawItemText(QPainter painter, QRect rect, int flags, QPalette pal, bool enabled, string text, QPalette.ColorRole textRole) {
			ProxyQStyle().DrawItemText(painter,rect,flags,pal,enabled,text,textRole);
		}
		[SmokeMethod("drawItemText", "(QPainter*, const QRect&, int, const QPalette&, bool, const QString&) const", "##$#$$")]
		public virtual void DrawItemText(QPainter painter, QRect rect, int flags, QPalette pal, bool enabled, string text) {
			ProxyQStyle().DrawItemText(painter,rect,flags,pal,enabled,text);
		}
		[SmokeMethod("drawItemPixmap", "(QPainter*, const QRect&, int, const QPixmap&) const", "##$#")]
		public virtual void DrawItemPixmap(QPainter painter, QRect rect, int alignment, QPixmap pixmap) {
			ProxyQStyle().DrawItemPixmap(painter,rect,alignment,pixmap);
		}
		[SmokeMethod("standardPalette", "() const", "")]
		public virtual QPalette StandardPalette() {
			return ProxyQStyle().StandardPalette();
		}
		[SmokeMethod("drawPrimitive", "(QStyle::PrimitiveElement, const QStyleOption*, QPainter*, const QWidget*) const", "$###")]
		public virtual void DrawPrimitive(QStyle.PrimitiveElement pe, out int opt, QPainter p, QWidget w) {
			ProxyQStyle().DrawPrimitive(pe,out opt,p,w);
		}
		[SmokeMethod("drawPrimitive", "(QStyle::PrimitiveElement, const QStyleOption*, QPainter*) const", "$##")]
		public virtual void DrawPrimitive(QStyle.PrimitiveElement pe, out int opt, QPainter p) {
			ProxyQStyle().DrawPrimitive(pe,out opt,p);
		}
		[SmokeMethod("drawControl", "(QStyle::ControlElement, const QStyleOption*, QPainter*, const QWidget*) const", "$###")]
		public virtual void DrawControl(QStyle.ControlElement element, out int opt, QPainter p, QWidget w) {
			ProxyQStyle().DrawControl(element,out opt,p,w);
		}
		[SmokeMethod("drawControl", "(QStyle::ControlElement, const QStyleOption*, QPainter*) const", "$##")]
		public virtual void DrawControl(QStyle.ControlElement element, out int opt, QPainter p) {
			ProxyQStyle().DrawControl(element,out opt,p);
		}
		[SmokeMethod("subElementRect", "(QStyle::SubElement, const QStyleOption*, const QWidget*) const", "$##")]
		public virtual QRect SubElementRect(QStyle.SubElement subElement, out int option, QWidget widget) {
			return ProxyQStyle().SubElementRect(subElement,out option,widget);
		}
		[SmokeMethod("subElementRect", "(QStyle::SubElement, const QStyleOption*) const", "$#")]
		public virtual QRect SubElementRect(QStyle.SubElement subElement, out int option) {
			return ProxyQStyle().SubElementRect(subElement,out option);
		}
		[SmokeMethod("drawComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*, const QWidget*) const", "$###")]
		public virtual void DrawComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPainter p, QWidget widget) {
			ProxyQStyle().DrawComplexControl(cc,opt,p,widget);
		}
		[SmokeMethod("drawComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*) const", "$##")]
		public virtual void DrawComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPainter p) {
			ProxyQStyle().DrawComplexControl(cc,opt,p);
		}
		[SmokeMethod("hitTestComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&, const QWidget*) const", "$###")]
		public virtual QStyle.SubControl HitTestComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPoint pt, QWidget widget) {
			return ProxyQStyle().HitTestComplexControl(cc,opt,pt,widget);
		}
		[SmokeMethod("hitTestComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&) const", "$##")]
		public virtual QStyle.SubControl HitTestComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPoint pt) {
			return ProxyQStyle().HitTestComplexControl(cc,opt,pt);
		}
		[SmokeMethod("subControlRect", "(QStyle::ComplexControl, const QStyleOptionComplex*, QStyle::SubControl, const QWidget*) const", "$#$#")]
		public virtual QRect SubControlRect(QStyle.ComplexControl cc, QStyleOptionComplex opt, QStyle.SubControl sc, QWidget widget) {
			return ProxyQStyle().SubControlRect(cc,opt,sc,widget);
		}
		[SmokeMethod("subControlRect", "(QStyle::ComplexControl, const QStyleOptionComplex*, QStyle::SubControl) const", "$#$")]
		public virtual QRect SubControlRect(QStyle.ComplexControl cc, QStyleOptionComplex opt, QStyle.SubControl sc) {
			return ProxyQStyle().SubControlRect(cc,opt,sc);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric, const QStyleOption*, const QWidget*) const", "$##")]
		public virtual int pixelMetric(QStyle.PixelMetric metric, out int option, QWidget widget) {
			return ProxyQStyle().pixelMetric(metric,out option,widget);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric, const QStyleOption*) const", "$#")]
		public virtual int pixelMetric(QStyle.PixelMetric metric, out int option) {
			return ProxyQStyle().pixelMetric(metric,out option);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric) const", "$")]
		public virtual int pixelMetric(QStyle.PixelMetric metric) {
			return ProxyQStyle().pixelMetric(metric);
		}
		[SmokeMethod("sizeFromContents", "(QStyle::ContentsType, const QStyleOption*, const QSize&, const QWidget*) const", "$###")]
		public virtual QSize SizeFromContents(QStyle.ContentsType ct, out int opt, QSize contentsSize, QWidget w) {
			return ProxyQStyle().SizeFromContents(ct,out opt,contentsSize,w);
		}
		[SmokeMethod("sizeFromContents", "(QStyle::ContentsType, const QStyleOption*, const QSize&) const", "$##")]
		public virtual QSize SizeFromContents(QStyle.ContentsType ct, out int opt, QSize contentsSize) {
			return ProxyQStyle().SizeFromContents(ct,out opt,contentsSize);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*, const QWidget*, QStyleHintReturn*) const", "$###")]
		public virtual int styleHint(QStyle.StyleHint stylehint, out int opt, QWidget widget, QStyleHintReturn returnData) {
			return ProxyQStyle().styleHint(stylehint,out opt,widget,returnData);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*, const QWidget*) const", "$##")]
		public virtual int styleHint(QStyle.StyleHint stylehint, out int opt, QWidget widget) {
			return ProxyQStyle().styleHint(stylehint,out opt,widget);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*) const", "$#")]
		public virtual int styleHint(QStyle.StyleHint stylehint, out int opt) {
			return ProxyQStyle().styleHint(stylehint,out opt);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint) const", "$")]
		public virtual int styleHint(QStyle.StyleHint stylehint) {
			return ProxyQStyle().styleHint(stylehint);
		}
		[SmokeMethod("standardPixmap", "(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", "$##")]
		public virtual QPixmap standardPixmap(QStyle.StandardPixmap standardPixmap, out int opt, QWidget widget) {
			return ProxyQStyle().standardPixmap(standardPixmap,out opt,widget);
		}
		[SmokeMethod("standardPixmap", "(QStyle::StandardPixmap, const QStyleOption*) const", "$#")]
		public virtual QPixmap standardPixmap(QStyle.StandardPixmap standardPixmap, out int opt) {
			return ProxyQStyle().standardPixmap(standardPixmap,out opt);
		}
		[SmokeMethod("standardPixmap", "(QStyle::StandardPixmap) const", "$")]
		public virtual QPixmap standardPixmap(QStyle.StandardPixmap standardPixmap) {
			return ProxyQStyle().standardPixmap(standardPixmap);
		}
		[SmokeMethod("standardIcon", "(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", "$##")]
		public QIcon StandardIcon(QStyle.StandardPixmap standardIcon, out int option, QWidget widget) {
			return ProxyQStyle().StandardIcon(standardIcon,out option,widget);
		}
		[SmokeMethod("standardIcon", "(QStyle::StandardPixmap, const QStyleOption*) const", "$#")]
		public QIcon StandardIcon(QStyle.StandardPixmap standardIcon, out int option) {
			return ProxyQStyle().StandardIcon(standardIcon,out option);
		}
		[SmokeMethod("standardIcon", "(QStyle::StandardPixmap) const", "$")]
		public QIcon StandardIcon(QStyle.StandardPixmap standardIcon) {
			return ProxyQStyle().StandardIcon(standardIcon);
		}
		[SmokeMethod("generatedIconPixmap", "(QIcon::Mode, const QPixmap&, const QStyleOption*) const", "$##")]
		public virtual QPixmap GeneratedIconPixmap(QIcon.Mode iconMode, QPixmap pixmap, out int opt) {
			return ProxyQStyle().GeneratedIconPixmap(iconMode,pixmap,out opt);
		}
		public static new string Tr(string s, string c) {
			return StaticQStyle().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQStyle().Tr(s);
		}
		public static QRect VisualRect(Qt.LayoutDirection direction, QRect boundingRect, QRect logicalRect) {
			return StaticQStyle().VisualRect(direction,boundingRect,logicalRect);
		}
		public static QPoint VisualPos(Qt.LayoutDirection direction, QRect boundingRect, QPoint logicalPos) {
			return StaticQStyle().VisualPos(direction,boundingRect,logicalPos);
		}
		public static int SliderPositionFromValue(int min, int max, int val, int space, bool upsideDown) {
			return StaticQStyle().SliderPositionFromValue(min,max,val,space,upsideDown);
		}
		public static int SliderPositionFromValue(int min, int max, int val, int space) {
			return StaticQStyle().SliderPositionFromValue(min,max,val,space);
		}
		public static int SliderValueFromPosition(int min, int max, int pos, int space, bool upsideDown) {
			return StaticQStyle().SliderValueFromPosition(min,max,pos,space,upsideDown);
		}
		public static int SliderValueFromPosition(int min, int max, int pos, int space) {
			return StaticQStyle().SliderValueFromPosition(min,max,pos,space);
		}
		public static int VisualAlignment(Qt.LayoutDirection direction, int alignment) {
			return StaticQStyle().VisualAlignment(direction,alignment);
		}
		public static QRect AlignedRect(Qt.LayoutDirection direction, int alignment, QSize size, QRect rectangle) {
			return StaticQStyle().AlignedRect(direction,alignment,size,rectangle);
		}
		~QStyle() {
			DisposeQStyle();
		}
		public new void Dispose() {
			DisposeQStyle();
		}
		[SmokeMethod("~QStyle", "()", "")]
		private void DisposeQStyle() {
			ProxyQStyle().DisposeQStyle();
		}
		protected new IQStyleSignals Emit {
			get {
				return (IQStyleSignals) Q_EMIT;
			}
		}
	}

	public interface IQStyleSignals : IQObjectSignals {
	}
}
