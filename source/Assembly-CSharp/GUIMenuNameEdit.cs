using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;

// Token: 0x020001CE RID: 462
[global::Cpp2ILInjected.Token(Token = "0x2000267")]
public class GUIMenuNameEdit
{
	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00024125 File Offset: 0x00022325
	// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00024128 File Offset: 0x00022328
	[global::Cpp2ILInjected.Token(Token = "0x17000177")]
	public bool Enabled
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000DBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x9E6060", Offset = "0x9E6060", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000DBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x9E6068", Offset = "0x9E6068", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "ShutdownUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CloseKeyboard", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x0002412B File Offset: 0x0002232B
	[global::Cpp2ILInjected.Token(Token = "0x17000178")]
	public string Name
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000DBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9E60D8", Offset = "0x9E60D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x0002412E File Offset: 0x0002232E
	[global::Cpp2ILInjected.Token(Token = "0x6000DC0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E60E0", Offset = "0x9E60E0", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "OpenNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "OpenNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "clrInput", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void Enable(string nomen)
	{
		throw null;
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00024131 File Offset: 0x00022331
	[global::Cpp2ILInjected.Token(Token = "0x6000DC1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E619C", Offset = "0x9E619C", Length = "0x1A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public string GetInputText(Rectangle region, int maxCharacters = -1)
	{
		throw null;
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00024134 File Offset: 0x00022334
	[global::Cpp2ILInjected.Token(Token = "0x6000DC2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E6344", Offset = "0x9E6344", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIMenuNameEdit()
	{
		throw null;
	}

	// Token: 0x0400146B RID: 5227
	[global::Cpp2ILInjected.Token(Token = "0x4001964")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private string _editedName;

	// Token: 0x0400146C RID: 5228
	[global::Cpp2ILInjected.Token(Token = "0x4001965")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private bool _enabled;
}
