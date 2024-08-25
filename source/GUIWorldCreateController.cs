using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20000AE")]
public class GUIWorldCreateController : GUIControllerItem
{
	[global::Cpp2ILInjected.Token(Token = "0x600040E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA844B8", Offset = "0xA844B8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA844C0", Offset = "0xA844C0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000410")]
	[global::Cpp2ILInjected.Address(RVA = "0xA844C8", Offset = "0xA844C8", Length = "0x1C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000411")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84690", Offset = "0xA84690", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "EnterName", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateName()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000412")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8469C", Offset = "0xA8469C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateName()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000413")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846A4", Offset = "0xA846A4", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "EnterSeed", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateSeed()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000414")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846B0", Offset = "0xA846B0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "CloseSeedEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateSeed()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000415")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846B8", Offset = "0xA846B8", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldDifficulty", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateDifficultyOptions(int selectedOption, int wrapAround)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000416")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846CC", Offset = "0xA846CC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldDifficulty", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	public void DeactivateDifficultyOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000417")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846D4", Offset = "0xA846D4", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldSize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateWorldOptions(int selectedOption)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000418")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846E4", Offset = "0xA846E4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldSize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	public void DeactivateWorldOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000419")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846EC", Offset = "0xA846EC", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldEvilType", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateEvilTypeOptions(int selectedOption, int wrapAround)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600041A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84700", Offset = "0xA84700", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldEvilType", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	public void DeactivateEvilTypeOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600041B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84708", Offset = "0xA84708", Length = "0x3A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600041C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84AAC", Offset = "0xA84AAC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIWorldCreateController()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40003F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int selectedItem;

	[global::Cpp2ILInjected.Token(Token = "0x40003F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private bool nameActive;

	[global::Cpp2ILInjected.Token(Token = "0x40003F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
	private bool seedActive;

	[global::Cpp2ILInjected.Token(Token = "0x40003F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
	private bool worldActive;

	[global::Cpp2ILInjected.Token(Token = "0x40003F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int worldIndex;

	[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private bool difficultyActive;

	[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int difficultyIndex;

	[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int difficultyWrapAround;

	[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool evilTypeActive;

	[global::Cpp2ILInjected.Token(Token = "0x40003FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private int evilTypeIndex;

	[global::Cpp2ILInjected.Token(Token = "0x40003FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int evilTypeWrapAround;
}
