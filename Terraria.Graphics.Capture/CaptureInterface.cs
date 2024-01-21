using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Capture;

[Cpp2IlInjected.Token(Token = "0x2000509")]
public class CaptureInterface
{
	[Cpp2IlInjected.Token(Token = "0x2000964")]
	public static class Settings
	{
		[Cpp2IlInjected.Token(Token = "0x4008BAF")]
		public static bool PackImage;

		[Cpp2IlInjected.Token(Token = "0x4008BB0")]
		public static bool IncludeEntities;

		[Cpp2IlInjected.Token(Token = "0x4008BB1")]
		public static bool TransparentBackground;

		[Cpp2IlInjected.Token(Token = "0x4008BB2")]
		public static int BiomeChoiceIndex;

		[Cpp2IlInjected.Token(Token = "0x4008BB3")]
		public static int ScreenAnchor;

		[Cpp2IlInjected.Token(Token = "0x4008BB4")]
		public static Color MarkedAreaColor;
	}

	[Cpp2IlInjected.Token(Token = "0x2000965")]
	private abstract class CaptureInterfaceMode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008BB5")]
		public bool Selected;

		[Cpp2IlInjected.Token(Token = "0x6004D8C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Update();

		[Cpp2IlInjected.Token(Token = "0x6004D8D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Draw(SpriteBatch sb);

		[Cpp2IlInjected.Token(Token = "0x6004D8E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void ToggleActive(bool tickedOn);

		[Cpp2IlInjected.Token(Token = "0x6004D8F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool UsingMap();

		[Cpp2IlInjected.Token(Token = "0x6004D90")]
		[Cpp2IlInjected.Address(RVA = "0x1318514", Offset = "0x1318514", VA = "0x1318514")]
		protected CaptureInterfaceMode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000966")]
	private class ModeEdgeSelection : CaptureInterfaceMode
	{
		[Cpp2IlInjected.Token(Token = "0x6004D91")]
		[Cpp2IlInjected.Address(RVA = "0x131C85C", Offset = "0x131C85C", VA = "0x131C85C", Slot = "4")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D92")]
		[Cpp2IlInjected.Address(RVA = "0x131CD5C", Offset = "0x131CD5C", VA = "0x131CD5C", Slot = "5")]
		public override void Draw(SpriteBatch sb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D93")]
		[Cpp2IlInjected.Address(RVA = "0x131F92C", Offset = "0x131F92C", VA = "0x131F92C", Slot = "6")]
		public override void ToggleActive(bool tickedOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D94")]
		[Cpp2IlInjected.Address(RVA = "0x131F930", Offset = "0x131F930", VA = "0x131F930", Slot = "7")]
		public override bool UsingMap()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D95")]
		[Cpp2IlInjected.Address(RVA = "0x131C960", Offset = "0x131C960", VA = "0x131C960")]
		private void EdgePlacement(Vector2 mouse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D96")]
		[Cpp2IlInjected.Address(RVA = "0x131D2E4", Offset = "0x131D2E4", VA = "0x131D2E4")]
		private void DrawMarkedArea(SpriteBatch sb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D97")]
		[Cpp2IlInjected.Address(RVA = "0x131DC8C", Offset = "0x131DC8C", VA = "0x131DC8C")]
		private void DrawCursors(SpriteBatch sb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D98")]
		[Cpp2IlInjected.Address(RVA = "0x1313EA4", Offset = "0x1313EA4", VA = "0x1313EA4")]
		public ModeEdgeSelection()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000967")]
	private class ModeDragBounds : CaptureInterfaceMode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008BB6")]
		public int currentAim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008BB7")]
		private bool dragging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008BB8")]
		private int caughtEdge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008BB9")]
		private bool inMap;

		[Cpp2IlInjected.Token(Token = "0x6004D99")]
		[Cpp2IlInjected.Address(RVA = "0x131AE60", Offset = "0x131AE60", VA = "0x131AE60", Slot = "4")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9A")]
		[Cpp2IlInjected.Address(RVA = "0x131BC84", Offset = "0x131BC84", VA = "0x131BC84", Slot = "5")]
		public override void Draw(SpriteBatch sb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9B")]
		[Cpp2IlInjected.Address(RVA = "0x131C20C", Offset = "0x131C20C", VA = "0x131C20C", Slot = "6")]
		public override void ToggleActive(bool tickedOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9C")]
		[Cpp2IlInjected.Address(RVA = "0x131C21C", Offset = "0x131C21C", VA = "0x131C21C", Slot = "7")]
		public override bool UsingMap()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9D")]
		[Cpp2IlInjected.Address(RVA = "0x131AFA8", Offset = "0x131AFA8", VA = "0x131AFA8")]
		private void DragBounds(Vector2 mouse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9E")]
		[Cpp2IlInjected.Address(RVA = "0x131C230", Offset = "0x131C230", VA = "0x131C230")]
		private Rectangle GetBound(Rectangle drawbox, int boundIndex)
		{
			return default(Rectangle);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D9F")]
		[Cpp2IlInjected.Address(RVA = "0x131A660", Offset = "0x131A660", VA = "0x131A660")]
		public void DrawMarkedArea(SpriteBatch sb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA0")]
		[Cpp2IlInjected.Address(RVA = "0x131C3D0", Offset = "0x131C3D0", VA = "0x131C3D0")]
		private void DrawBound(SpriteBatch sb, Rectangle r, int mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA1")]
		[Cpp2IlInjected.Address(RVA = "0x1313EAC", Offset = "0x1313EAC", VA = "0x1313EAC")]
		public ModeDragBounds()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000968")]
	private class ModeChangeSettings : CaptureInterfaceMode
	{
		[Cpp2IlInjected.Token(Token = "0x4008BBA")]
		private const int ButtonsCount = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008BBB")]
		private int hoveredButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008BBC")]
		private bool inUI;

		[Cpp2IlInjected.Token(Token = "0x6004DA2")]
		[Cpp2IlInjected.Address(RVA = "0x131851C", Offset = "0x131851C", VA = "0x131851C")]
		private Rectangle GetRect()
		{
			return default(Rectangle);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA3")]
		[Cpp2IlInjected.Address(RVA = "0x13185FC", Offset = "0x13185FC", VA = "0x13185FC")]
		private void ButtonDraw(int button, ref string key, ref string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA4")]
		[Cpp2IlInjected.Address(RVA = "0x1318938", Offset = "0x1318938", VA = "0x1318938")]
		private void PressButton(int button)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA5")]
		[Cpp2IlInjected.Address(RVA = "0x1318B10", Offset = "0x1318B10", VA = "0x1318B10")]
		private void DrawWaterChoices(SpriteBatch spritebatch, Point start, Point mouse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA6")]
		[Cpp2IlInjected.Address(RVA = "0x1319580", Offset = "0x1319580", VA = "0x1319580")]
		private int UnnecessaryBiomeSelectionTypeConversion(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA7")]
		[Cpp2IlInjected.Address(RVA = "0x13195A0", Offset = "0x13195A0", VA = "0x13195A0", Slot = "4")]
		public override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA8")]
		[Cpp2IlInjected.Address(RVA = "0x13197CC", Offset = "0x13197CC", VA = "0x13197CC", Slot = "5")]
		public override void Draw(SpriteBatch sb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DA9")]
		[Cpp2IlInjected.Address(RVA = "0x131AE48", Offset = "0x131AE48", VA = "0x131AE48", Slot = "6")]
		public override void ToggleActive(bool tickedOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAA")]
		[Cpp2IlInjected.Address(RVA = "0x131AE58", Offset = "0x131AE58", VA = "0x131AE58", Slot = "7")]
		public override bool UsingMap()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAB")]
		[Cpp2IlInjected.Address(RVA = "0x1313EC0", Offset = "0x1313EC0", VA = "0x1313EC0")]
		public ModeChangeSettings()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40067ED")]
	private static Dictionary<int, CaptureInterfaceMode> Modes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40067EE")]
	public bool Active;

	[Cpp2IlInjected.Token(Token = "0x40067EF")]
	public static bool JustActivated;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40067F0")]
	private bool KeyToggleActiveHeld;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40067F1")]
	public int SelectedMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40067F2")]
	public int HoveredMode;

	[Cpp2IlInjected.Token(Token = "0x40067F3")]
	public static bool EdgeAPinned;

	[Cpp2IlInjected.Token(Token = "0x40067F4")]
	public static bool EdgeBPinned;

	[Cpp2IlInjected.Token(Token = "0x40067F5")]
	public static Point EdgeA;

	[Cpp2IlInjected.Token(Token = "0x40067F6")]
	public static Point EdgeB;

	[Cpp2IlInjected.Token(Token = "0x40067F7")]
	public static bool CameraLock;

	[Cpp2IlInjected.Token(Token = "0x40067F8")]
	private static float CameraFrame;

	[Cpp2IlInjected.Token(Token = "0x40067F9")]
	private static float CameraWaiting;

	[Cpp2IlInjected.Token(Token = "0x40067FA")]
	private const float CameraMaxFrame = 5f;

	[Cpp2IlInjected.Token(Token = "0x40067FB")]
	private const float CameraMaxWait = 60f;

	[Cpp2IlInjected.Token(Token = "0x40067FC")]
	private static CaptureSettings CameraSettings;

	[Cpp2IlInjected.Token(Token = "0x60037E4")]
	[Cpp2IlInjected.Address(RVA = "0x1313D78", Offset = "0x1313D78", VA = "0x1313D78")]
	private static Dictionary<int, CaptureInterfaceMode> FillModes()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60037E5")]
	[Cpp2IlInjected.Address(RVA = "0x1313ED0", Offset = "0x1313ED0", VA = "0x1313ED0")]
	public static Rectangle GetArea()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60037E6")]
	[Cpp2IlInjected.Address(RVA = "0x1314008", Offset = "0x1314008", VA = "0x1314008")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037E7")]
	[Cpp2IlInjected.Address(RVA = "0x1315180", Offset = "0x1315180", VA = "0x1315180")]
	public void Draw(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037E8")]
	[Cpp2IlInjected.Address(RVA = "0x1314884", Offset = "0x1314884", VA = "0x1314884")]
	public void ToggleCamera(bool On = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037E9")]
	[Cpp2IlInjected.Address(RVA = "0x1314B1C", Offset = "0x1314B1C", VA = "0x1314B1C")]
	private bool UpdateButtons(Vector2 mouse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60037EA")]
	[Cpp2IlInjected.Address(RVA = "0x13174FC", Offset = "0x13174FC", VA = "0x13174FC")]
	public static void QuickScreenshot()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037EB")]
	[Cpp2IlInjected.Address(RVA = "0x1315B40", Offset = "0x1315B40", VA = "0x1315B40")]
	private void DrawButtons(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037EC")]
	[Cpp2IlInjected.Address(RVA = "0x131792C", Offset = "0x131792C", VA = "0x131792C")]
	private static bool GetMapCoords(int PinX, int PinY, int Goal, out Point result)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60037ED")]
	[Cpp2IlInjected.Address(RVA = "0x1317F98", Offset = "0x1317F98", VA = "0x1317F98")]
	private static void ConstraintPoints()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037EE")]
	[Cpp2IlInjected.Address(RVA = "0x13180EC", Offset = "0x13180EC", VA = "0x13180EC")]
	private static void PointWorldClamp(ref Point point, int fluff)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037EF")]
	[Cpp2IlInjected.Address(RVA = "0x1318234", Offset = "0x1318234", VA = "0x1318234")]
	public bool UsingMap()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60037F0")]
	[Cpp2IlInjected.Address(RVA = "0x131783C", Offset = "0x131783C", VA = "0x131783C")]
	public static void ResetFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037F1")]
	[Cpp2IlInjected.Address(RVA = "0x1318314", Offset = "0x1318314", VA = "0x1318314")]
	public void Scrolling()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037F2")]
	[Cpp2IlInjected.Address(RVA = "0x1314530", Offset = "0x1314530", VA = "0x1314530")]
	private void UpdateCamera()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037F3")]
	[Cpp2IlInjected.Address(RVA = "0x1316C4C", Offset = "0x1316C4C", VA = "0x1316C4C")]
	private void DrawCameraLock(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037F4")]
	[Cpp2IlInjected.Address(RVA = "0x1317780", Offset = "0x1317780", VA = "0x1317780")]
	public static void StartCamera(CaptureSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037F5")]
	[Cpp2IlInjected.Address(RVA = "0x1318434", Offset = "0x1318434", VA = "0x1318434")]
	public static void EndCamera()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037F6")]
	[Cpp2IlInjected.Address(RVA = "0x13184B0", Offset = "0x13184B0", VA = "0x13184B0")]
	public CaptureInterface()
	{
	}
}
