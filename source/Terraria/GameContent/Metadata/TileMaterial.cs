using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;

namespace Terraria.GameContent.Metadata
{
	[global::Cpp2ILInjected.Token(Token = "0x2000855")]
	public class TileMaterial
	{
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x170007D0")]
		public TileGolfPhysics GolfPhysics
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004354")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A1320", Offset = "0x7A1320", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004355")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A1328", Offset = "0x7A1328", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004356")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A1330", Offset = "0x7A1330", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TileMaterial()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008165")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TileGolfPhysics <GolfPhysics>k__BackingField;
	}
}
