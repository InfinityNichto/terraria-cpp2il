using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000369")]
	public class EffectTechniqueCollection : IEnumerable<EffectTechnique>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002A9")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016CC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA5470", Offset = "0xAA5470", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA547C", Offset = "0xAA547C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal EffectTechniqueCollection(EffectTechnique[] techniques)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016CE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA54A4", Offset = "0xAA54A4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "Clone", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(EffectPassCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal EffectTechniqueCollection Clone(Effect effect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002AA")]
		public EffectTechnique this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016CF")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA55D4", Offset = "0xAA55D4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002AB")]
		public EffectTechnique this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016D0")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA55E4", Offset = "0xAA55E4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA564C", Offset = "0xAA564C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<EffectTechnique> GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA56E4", Offset = "0xAA56E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40024EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly EffectTechnique[] _techniques;
	}
}
