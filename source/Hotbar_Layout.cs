using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20001D8")]
public class Hotbar_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x17000152")]
	public static Hotbar_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C12")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B6B44", Offset = "0x9B6B44", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHotbarRadial), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(GUIItemGrid.GetItemScaleHandler),
			typeof(GUIItemGrid.CursorOver),
			typeof(GUIItemGrid.DrawItemHandler),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "ItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C13")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6BC0", Offset = "0x9B6BC0", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C14")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6C44", Offset = "0x9B6C44", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Hotbar_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40010F5")]
	public static Hotbar_Layout InstanceNormal;

	[global::Cpp2ILInjected.Token(Token = "0x40010F6")]
	public static Hotbar_Layout Instance4Page;

	[global::Cpp2ILInjected.Token(Token = "0x40010F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float SelectedScale;

	[global::Cpp2ILInjected.Token(Token = "0x40010F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float NormalScale;

	[global::Cpp2ILInjected.Token(Token = "0x40010F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ScaleSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x40010FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40010FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout HorizontalTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40010FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout HotbarGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40010FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout HorizontalHotbarGrid;
}
