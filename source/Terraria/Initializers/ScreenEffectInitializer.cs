using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Shaders;
using Terraria.GameContent.Skies;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;

namespace Terraria.Initializers
{
	// Token: 0x020003D9 RID: 985
	[global::Cpp2ILInjected.Token(Token = "0x200058F")]
	public static class ScreenEffectInitializer
	{
		// Token: 0x0600302F RID: 12335 RVA: 0x0002A9D7 File Offset: 0x00028BD7
		[global::Cpp2ILInjected.Token(Token = "0x60034C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x137F20C", Offset = "0x137F20C", Length = "0x13D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PostContentLoadInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseOpacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ScreenShaderData),
			typeof(EffectPriority)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordScreenShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BloodMoonScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SepiaScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseImage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(SamplerState)
		}, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseIntensity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SandstormShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseSecondaryColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleOverlay), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ScreenShaderData),
			typeof(EffectPriority),
			typeof(RenderLayers)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlizzardShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseImageScale", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 123)]
		public static void Load()
		{
			throw null;
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x0002A9DA File Offset: 0x00028BDA
		[global::Cpp2ILInjected.Token(Token = "0x60034C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13805E4", Offset = "0x13805E4", Length = "0x6C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PartySky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MartianSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NebulaSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StardustSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VortexSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SolarSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlimeSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordSky), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SandstormSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlizzardSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AmbientSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		private static void LoadSkies()
		{
			throw null;
		}
	}
}
