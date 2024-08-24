using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;

// Token: 0x020001D2 RID: 466
[global::Cpp2ILInjected.Token(Token = "0x200026D")]
public class GUIMultiplayerMenu
{
	// Token: 0x06000CDF RID: 3295 RVA: 0x000241E2 File Offset: 0x000223E2
	[global::Cpp2ILInjected.Token(Token = "0x6000DFE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EFA68", Offset = "0x9EFA68", Length = "0x348")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x000241E5 File Offset: 0x000223E5
	[global::Cpp2ILInjected.Token(Token = "0x6000DFF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EFDB0", Offset = "0x9EFDB0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIMultiplayerMenu()
	{
		throw null;
	}

	// Token: 0x040014A1 RID: 5281
	[global::Cpp2ILInjected.Token(Token = "0x40019AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float scale0;

	// Token: 0x040014A2 RID: 5282
	[global::Cpp2ILInjected.Token(Token = "0x40019AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float scale1;

	// Token: 0x040014A3 RID: 5283
	[global::Cpp2ILInjected.Token(Token = "0x40019AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float scale2;
}
