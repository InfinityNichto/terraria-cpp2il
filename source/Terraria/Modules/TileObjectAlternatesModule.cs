using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	[global::Cpp2ILInjected.Token(Token = "0x200054A")]
	public class TileObjectAlternatesModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60032ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x132EDB4", Offset = "0x132EDB4", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_LinkedAlternates", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Alternates", MemberParameters = new object[] { typeof(List<TileObjectData>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectData), Member = ".ctor", MemberParameters = new object[] { typeof(TileObjectData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public TileObjectAlternatesModule(TileObjectAlternatesModule copyFrom = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<TileObjectData> data;
	}
}
