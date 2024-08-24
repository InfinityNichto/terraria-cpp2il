using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002E0 RID: 736
	[global::Cpp2ILInjected.Token(Token = "0x20003B3")]
	public struct HalfSingle : IPackedVector<ushort>, IPackedVector, IEquatable<HalfSingle>
	{
		// Token: 0x0600180B RID: 6155 RVA: 0x0002628B File Offset: 0x0002448B
		[global::Cpp2ILInjected.Token(Token = "0x600198B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9414", Offset = "0xAC9414", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		public HalfSingle(float single)
		{
			throw null;
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0002628E File Offset: 0x0002448E
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x00026291 File Offset: 0x00024491
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000363")]
		public ushort PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600198C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC9438", Offset = "0xAC9438", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600198D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC9440", Offset = "0xAC9440", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00026294 File Offset: 0x00024494
		[global::Cpp2ILInjected.Token(Token = "0x600198E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9448", Offset = "0xAC9448", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float ToSingle()
		{
			throw null;
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00026297 File Offset: 0x00024497
		[global::Cpp2ILInjected.Token(Token = "0x600198F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC94C4", Offset = "0xAC94C4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0002629A File Offset: 0x0002449A
		[global::Cpp2ILInjected.Token(Token = "0x6001990")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC94E0", Offset = "0xAC94E0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private Vector4 Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4()
		{
			throw null;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0002629D File Offset: 0x0002449D
		[global::Cpp2ILInjected.Token(Token = "0x6001991")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9520", Offset = "0xAC9520", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000262A0 File Offset: 0x000244A0
		[global::Cpp2ILInjected.Token(Token = "0x6001992")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9634", Offset = "0xAC9634", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(HalfSingle other)
		{
			throw null;
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x000262A3 File Offset: 0x000244A3
		[global::Cpp2ILInjected.Token(Token = "0x6001993")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9644", Offset = "0xAC9644", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000262A6 File Offset: 0x000244A6
		[global::Cpp2ILInjected.Token(Token = "0x6001994")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9668", Offset = "0xAC9668", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x000262A9 File Offset: 0x000244A9
		[global::Cpp2ILInjected.Token(Token = "0x6001995")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9624", Offset = "0xAC9624", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(HalfSingle lhs, HalfSingle rhs)
		{
			throw null;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000262AC File Offset: 0x000244AC
		[global::Cpp2ILInjected.Token(Token = "0x6001996")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9670", Offset = "0xAC9670", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(HalfSingle lhs, HalfSingle rhs)
		{
			throw null;
		}

		// Token: 0x0400213E RID: 8510
		[global::Cpp2ILInjected.Token(Token = "0x400279E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ushort packedValue;
	}
}
