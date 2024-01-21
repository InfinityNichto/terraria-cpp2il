using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class GUIControlsBanner
{
	[Cpp2IlInjected.Token(Token = "0x20007B4")]
	public enum ActionSource
	{
		[Cpp2IlInjected.Token(Token = "0x40079D7")]
		MainMenu,
		[Cpp2IlInjected.Token(Token = "0x40079D8")]
		World,
		[Cpp2IlInjected.Token(Token = "0x40079D9")]
		InterfaceLeft,
		[Cpp2IlInjected.Token(Token = "0x40079DA")]
		InterfaceRight,
		[Cpp2IlInjected.Token(Token = "0x40079DB")]
		NPCDialogue,
		[Cpp2IlInjected.Token(Token = "0x40079DC")]
		Dresser,
		[Cpp2IlInjected.Token(Token = "0x40079DD")]
		HairStylist,
		[Cpp2IlInjected.Token(Token = "0x40079DE")]
		Map,
		[Cpp2IlInjected.Token(Token = "0x40079DF")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x20007B5")]
	public class Action
	{
		[Cpp2IlInjected.Token(Token = "0x2000B4B")]
		public enum ControlPriority
		{
			[Cpp2IlInjected.Token(Token = "0x4008FC1")]
			LeftTrigger,
			[Cpp2IlInjected.Token(Token = "0x4008FC2")]
			LeftShoulder,
			[Cpp2IlInjected.Token(Token = "0x4008FC3")]
			DPadDown,
			[Cpp2IlInjected.Token(Token = "0x4008FC4")]
			DPadUp,
			[Cpp2IlInjected.Token(Token = "0x4008FC5")]
			DPadLeft,
			[Cpp2IlInjected.Token(Token = "0x4008FC6")]
			DPadRight,
			[Cpp2IlInjected.Token(Token = "0x4008FC7")]
			LSDown,
			[Cpp2IlInjected.Token(Token = "0x4008FC8")]
			LSUp,
			[Cpp2IlInjected.Token(Token = "0x4008FC9")]
			LSLeft,
			[Cpp2IlInjected.Token(Token = "0x4008FCA")]
			LSRight,
			[Cpp2IlInjected.Token(Token = "0x4008FCB")]
			LSClick,
			[Cpp2IlInjected.Token(Token = "0x4008FCC")]
			ViewButton,
			[Cpp2IlInjected.Token(Token = "0x4008FCD")]
			LeftMore,
			[Cpp2IlInjected.Token(Token = "0x4008FCE")]
			RightTrigger,
			[Cpp2IlInjected.Token(Token = "0x4008FCF")]
			RightShoulder,
			[Cpp2IlInjected.Token(Token = "0x4008FD0")]
			Action2,
			[Cpp2IlInjected.Token(Token = "0x4008FD1")]
			Action4,
			[Cpp2IlInjected.Token(Token = "0x4008FD2")]
			Action3,
			[Cpp2IlInjected.Token(Token = "0x4008FD3")]
			Action1,
			[Cpp2IlInjected.Token(Token = "0x4008FD4")]
			RSDown,
			[Cpp2IlInjected.Token(Token = "0x4008FD5")]
			RSUp,
			[Cpp2IlInjected.Token(Token = "0x4008FD6")]
			RSLeft,
			[Cpp2IlInjected.Token(Token = "0x4008FD7")]
			RSRight,
			[Cpp2IlInjected.Token(Token = "0x4008FD8")]
			RSClick,
			[Cpp2IlInjected.Token(Token = "0x4008FD9")]
			Settings,
			[Cpp2IlInjected.Token(Token = "0x4008FDA")]
			RightMore
		}

		[Cpp2IlInjected.Token(Token = "0x40079E0")]
		public const ControlPriority MinRightControl = ControlPriority.RightTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40079E1")]
		public ControllerActionVector Axis;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40079E2")]
		public ControllerActionButton Button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40079E3")]
		public TransactionButton_Layout ActionStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40079E4")]
		public Texture2D ActionTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40079E5")]
		public Rectangle ActionTextureRegion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40079E6")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40079E7")]
		public int InputPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40079E8")]
		public bool Disabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40079E9")]
		public int DisplayPriorityOffset;

		[Cpp2IlInjected.Token(Token = "0x60048FC")]
		[Cpp2IlInjected.Address(RVA = "0x12BA214", Offset = "0x12BA214", VA = "0x12BA214")]
		public Action(ActionSource source, ControllerActionVector action, string name, Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout style, bool disabled, int displayPriorityOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048FD")]
		[Cpp2IlInjected.Address(RVA = "0x12BA324", Offset = "0x12BA324", VA = "0x12BA324")]
		public Action(ActionSource source, ControllerActionButton action, string name, Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled, int displayPriorityOffset)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20007B6")]
	private class ActionGroup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40079EA")]
		public Action ActionUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40079EB")]
		public Action ActionDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40079EC")]
		public Action ActionLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40079ED")]
		public Action ActionRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40079EE")]
		public float ScaleUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40079EF")]
		public float ScaleDown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40079F0")]
		public float ScaleLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40079F1")]
		public float ScaleRight;

		[Cpp2IlInjected.Token(Token = "0x60048FE")]
		[Cpp2IlInjected.Address(RVA = "0x12BA59C", Offset = "0x12BA59C", VA = "0x12BA59C")]
		public ActionGroup()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private Vector2 itemSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private List<Action> currentActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private bool[] MoreLeftStateActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private bool[] MoreRightStateActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private List<Action>[] sourceActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private List<Action> AllActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private List<Action> LeftActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private List<Action> RightActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private bool MoreLeftActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private bool MoreRightActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public bool ShowBanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public bool DisplayingSecondLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private bool secondLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private Rectangle lastDrawRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private Rectangle lastDrawRegion2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private TransactionButton_Layout ActionStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private TransactionButton_Layout ActionStyleMultiple;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private Action LTAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private Action LBAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private float ScaleLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private Action RBAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private Action RTAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private float ScaleRB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private ActionGroup LSActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private ActionGroup RSActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private ActionGroup DPadActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private ActionGroup ButtonActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private int itemsDrawing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private float leftMoreScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private float rightMoreScale;

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x121F4C4", Offset = "0x121F4C4", VA = "0x121F4C4")]
	private float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x121F4CC", Offset = "0x121F4CC", VA = "0x121F4CC")]
	private void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x121F4D0", Offset = "0x121F4D0", VA = "0x121F4D0")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x121FF00", Offset = "0x121FF00", VA = "0x121FF00")]
	public void ItemRightDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x121FDFC", Offset = "0x121FDFC", VA = "0x121FDFC")]
	public static GUIControllerInputButton.LinkedControlType FromButton(Buttons button)
	{
		return default(GUIControllerInputButton.LinkedControlType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x1220964", Offset = "0x1220964", VA = "0x1220964")]
	public string GetControlTag(ControllerActionVector action)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x1220B9C", Offset = "0x1220B9C", VA = "0x1220B9C")]
	public string GetControlTag(ControllerActionButton action)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x121FE18", Offset = "0x121FE18", VA = "0x121FE18")]
	public static GUIControllerInputButton.AxisControl FromAxis(Axis axis, float threshold)
	{
		return default(GUIControllerInputButton.AxisControl);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x1220DD4", Offset = "0x1220DD4", VA = "0x1220DD4")]
	private Vector2 ItemSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x122100C", Offset = "0x122100C", VA = "0x122100C")]
	private Rectangle ItemRightTextRegion(int index)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x12210C8", Offset = "0x12210C8", VA = "0x12210C8")]
	private void LoadControlPosition(TransactionButton_Layout layout, ControlsBanner_Layout.ControlGroupingPosition position, Vector2 offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x12211A4", Offset = "0x12211A4", VA = "0x12211A4")]
	private void DrawControl(TransactionButton_Layout layout, ControlsBanner_Layout.ControlGroupingPosition position, Vector2 offset, Action action, ref float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x122136C", Offset = "0x122136C", VA = "0x122136C")]
	private Vector2 GetControlPoint(ControlsBanner_Layout.ControlGroupingPosition layoutItem)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x1221414", Offset = "0x1221414", VA = "0x1221414")]
	private bool AddAction(Action action, int maxWidth)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x1221704", Offset = "0x1221704", VA = "0x1221704")]
	private bool AddMore(int maxWidth)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x1221B04", Offset = "0x1221B04", VA = "0x1221B04")]
	public int SortActionByDisplayPriority(Action x, Action y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x1221B98", Offset = "0x1221B98", VA = "0x1221B98")]
	public void DrawHorizontalControlsBanner()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x1221F90", Offset = "0x1221F90", VA = "0x1221F90")]
	public void DrawLeftControlsBanner()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x122253C", Offset = "0x122253C", VA = "0x122253C")]
	public void DrawRightControlsBanner()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x1222AE8", Offset = "0x1222AE8", VA = "0x1222AE8")]
	public void DrawControlsBanner(ActionSource source)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x1223488", Offset = "0x1223488", VA = "0x1223488")]
	public void DrawMoreOptionsBanner()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x12238D0", Offset = "0x12238D0", VA = "0x12238D0")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x1223B7C", Offset = "0x1223B7C", VA = "0x1223B7C")]
	public void AddAction(ActionSource source, ControllerActionVector action, string label)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x1224048", Offset = "0x1224048", VA = "0x1224048")]
	public void AddAction(ActionSource source, ControllerActionVector action, string label, Texture2D itemTexture, TransactionButton_Layout styleSource, bool disabled)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x1223BB4", Offset = "0x1223BB4", VA = "0x1223BB4")]
	public void AddAction(ActionSource source, ControllerActionVector action, string label, Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x1223450", Offset = "0x1223450", VA = "0x1223450")]
	public void AddAction(ActionSource source, ControllerActionButton action, string label)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x12245D8", Offset = "0x12245D8", VA = "0x12245D8")]
	public void AddAction(ActionSource source, ControllerActionButton action, string label, Texture2D itemTexture, TransactionButton_Layout styleSource, bool disabled)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x1224154", Offset = "0x1224154", VA = "0x1224154")]
	public void AddAction(ActionSource source, ControllerActionButton action, string label, Texture2D itemTexture, Rectangle srcRegion, TransactionButton_Layout styleSource, bool disabled)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x12246E4", Offset = "0x12246E4", VA = "0x12246E4")]
	public GUIControlsBanner()
	{
	}
}
