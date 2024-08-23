using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Localization;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002E2 RID: 738
	[global::Cpp2ILInjected.Token(Token = "0x20003B6")]
	public struct HalfVector2 : IPackedVector<uint>, IPackedVector, IEquatable<HalfVector2>
	{
		// Token: 0x0600181B RID: 6171 RVA: 0x000262BB File Offset: 0x000244BB
		[global::Cpp2ILInjected.Token(Token = "0x600199B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9758", Offset = "0xAC9758", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "WritePackedVector2", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		public HalfVector2(float x, float y)
		{
			throw null;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x000262BE File Offset: 0x000244BE
		[global::Cpp2ILInjected.Token(Token = "0x600199C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC97CC", Offset = "0xAC97CC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		public HalfVector2(Vector2 vector)
		{
			throw null;
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000262C1 File Offset: 0x000244C1
		[global::Cpp2ILInjected.Token(Token = "0x600199D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC980C", Offset = "0xAC980C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		private void Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000262C4 File Offset: 0x000244C4
		[global::Cpp2ILInjected.Token(Token = "0x600199E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9798", Offset = "0xAC9798", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		private static uint PackHelper(float vectorX, float vectorY)
		{
			throw null;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000262C7 File Offset: 0x000244C7
		[global::Cpp2ILInjected.Token(Token = "0x600199F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC984C", Offset = "0xAC984C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "ReadPackedVector2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(float))]
		public Vector2 ToVector2()
		{
			throw null;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000262CA File Offset: 0x000244CA
		[global::Cpp2ILInjected.Token(Token = "0x60019A0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9880", Offset = "0xAC9880", Length = "0x5C")]
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x000262CD File Offset: 0x000244CD
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x000262D0 File Offset: 0x000244D0
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x17000364")]
		public uint PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019A1")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC98DC", Offset = "0xAC98DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60019A2")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC98E4", Offset = "0xAC98E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000262D3 File Offset: 0x000244D3
		[global::Cpp2ILInjected.Token(Token = "0x60019A3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC98EC", Offset = "0xAC98EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000262D6 File Offset: 0x000244D6
		[global::Cpp2ILInjected.Token(Token = "0x60019A4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9928", Offset = "0xAC9928", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x000262D9 File Offset: 0x000244D9
		[global::Cpp2ILInjected.Token(Token = "0x60019A5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9930", Offset = "0xAC9930", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Equals", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000262DC File Offset: 0x000244DC
		[global::Cpp2ILInjected.Token(Token = "0x60019A6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC99AC", Offset = "0xAC99AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Equals", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(bool))]
		public bool Equals(HalfVector2 other)
		{
			throw null;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000262DF File Offset: 0x000244DF
		[global::Cpp2ILInjected.Token(Token = "0x60019A7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC99B4", Offset = "0xAC99B4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Equals", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(bool))]
		public static bool operator ==(HalfVector2 a, HalfVector2 b)
		{
			throw null;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000262E2 File Offset: 0x000244E2
		[global::Cpp2ILInjected.Token(Token = "0x60019A8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC99D4", Offset = "0xAC99D4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Equals", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(bool))]
		public static bool operator !=(HalfVector2 a, HalfVector2 b)
		{
			throw null;
		}

		// Token: 0x0400213F RID: 8511
		[global::Cpp2ILInjected.Token(Token = "0x40027A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint packedValue;
	}
}
