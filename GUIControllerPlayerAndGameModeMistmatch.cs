using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GUIControllerPlayerAndGameModeMistmatch : GUIControllerItem
{
	[Cpp2IlInjected.Token(Token = "0x200078A")]
	public enum Controls
	{
		[Cpp2IlInjected.Token(Token = "0x4007908")]
		Cancel
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public Controls selectedControl;

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1217FF0", Offset = "0x1217FF0", VA = "0x1217FF0", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x1217FFC", Offset = "0x1217FFC", VA = "0x1217FFC", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1218000", Offset = "0x1218000", VA = "0x1218000", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1218110", Offset = "0x1218110", VA = "0x1218110", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1218118", Offset = "0x1218118", VA = "0x1218118")]
	public GUIControllerPlayerAndGameModeMistmatch()
	{
	}
}
