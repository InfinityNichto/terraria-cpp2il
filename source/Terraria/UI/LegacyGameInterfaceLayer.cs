﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000714")]
	public class LegacyGameInterfaceLayer : GameInterfaceLayer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003C00")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C7CC", Offset = "0x148C7CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetupDrawInterfaceLayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameInterfaceLayer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(InterfaceScaleType)
		}, ReturnType = typeof(void))]
		public LegacyGameInterfaceLayer(string name, GameInterfaceDrawMethod drawMethod, InterfaceScaleType scaleType = InterfaceScaleType.Game)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C01")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C7F8", Offset = "0x148C7F8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override bool DrawSelf()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007B63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private GameInterfaceDrawMethod _drawMethod;
	}
}
