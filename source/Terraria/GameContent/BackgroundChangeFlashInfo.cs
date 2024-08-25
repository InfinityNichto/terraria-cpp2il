using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x2000806")]
	public class BackgroundChangeFlashInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x60041CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x783BA0", Offset = "0x783BA0", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "RandomizeBackgroundBasedOnPlayer", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BackgroundChangeFlashInfo), Member = "ValueChanged", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UpdateCache()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x783E34", Offset = "0x783E34", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void UpdateVariation(int areaId, int newVariationValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x783E54", Offset = "0x783E54", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BackgroundChangeFlashInfo), Member = "UpdateCache", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ValueChanged(int areaId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x783ECC", Offset = "0x783ECC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public void UpdateFlashValues()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x783F40", Offset = "0x783F40", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_DrawChangeOverlay", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public float GetFlashPower(int areaId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x783F50", Offset = "0x783F50", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public BackgroundChangeFlashInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int[] _variations;

		[global::Cpp2ILInjected.Token(Token = "0x4008099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private float[] _flashPower;
	}
}
