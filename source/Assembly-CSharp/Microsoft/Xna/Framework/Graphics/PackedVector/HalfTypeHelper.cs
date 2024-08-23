﻿using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020002E1 RID: 737
	[global::Cpp2ILInjected.Token(Token = "0x20003B4")]
	internal class HalfTypeHelper
	{
		// Token: 0x06001817 RID: 6167 RVA: 0x000262AF File Offset: 0x000244AF
		[global::Cpp2ILInjected.Token(Token = "0x6001997")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9430", Offset = "0xAC9430", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		internal static ushort Convert(float f)
		{
			throw null;
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x000262B2 File Offset: 0x000244B2
		[global::Cpp2ILInjected.Token(Token = "0x6001998")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9680", Offset = "0xAC9680", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfSingle), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfSingle), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfTypeHelper), Member = "Convert", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector2), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector2), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.PackFromVector4", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector2), Member = "PackHelper", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector4), Member = "PackHelper", MemberParameters = new object[] { typeof(ref Vector4) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		internal static ushort Convert(int i)
		{
			throw null;
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x000262B5 File Offset: 0x000244B5
		[global::Cpp2ILInjected.Token(Token = "0x6001999")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9450", Offset = "0xAC9450", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfSingle), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfSingle), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector2), Member = "ToVector2", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector2), Member = "Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector.ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector2), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HalfVector4), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		internal static float Convert(ushort value)
		{
			throw null;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000262B8 File Offset: 0x000244B8
		[global::Cpp2ILInjected.Token(Token = "0x600199A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC9750", Offset = "0xAC9750", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HalfTypeHelper()
		{
			throw null;
		}

		// Token: 0x02000832 RID: 2098
		[global::Cpp2ILInjected.Token(Token = "0x20003B5")]
		[StructLayout(2)]
		private struct uif
		{
			// Token: 0x04007E1E RID: 32286
			[global::Cpp2ILInjected.Token(Token = "0x400279F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public float f;

			// Token: 0x04007E1F RID: 32287
			[global::Cpp2ILInjected.Token(Token = "0x40027A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public int i;

			// Token: 0x04007E20 RID: 32288
			[global::Cpp2ILInjected.Token(Token = "0x40027A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public uint u;
		}
	}
}