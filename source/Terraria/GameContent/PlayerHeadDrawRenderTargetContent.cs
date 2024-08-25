using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Renderers;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007CB")]
	public class PlayerHeadDrawRenderTargetContent : AnOutlinedDrawRenderTargetContent
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x77289C", Offset = "0x77289C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UsePlayer(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7728A4", Offset = "0x7728A4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_00_BackHelmet", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_01_FaceSkin", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_02_DrawArmorWithFullHair", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_03_HelmetHair", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_04_HatsWithFullHair", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_05_TallHats", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_06_NormalHats", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_07_JustHair", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_08_FaceAcc", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override void DrawTheContent(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7729F4", Offset = "0x7729F4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHeadRenderer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnOutlinedDrawRenderTargetContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public PlayerHeadDrawRenderTargetContent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Player _player;

		[global::Cpp2ILInjected.Token(Token = "0x4007E5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly DrawData[] _drawData;

		[global::Cpp2ILInjected.Token(Token = "0x4007E5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly List<int> _dust;

		[global::Cpp2ILInjected.Token(Token = "0x4007E5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly List<int> _gore;
	}
}
