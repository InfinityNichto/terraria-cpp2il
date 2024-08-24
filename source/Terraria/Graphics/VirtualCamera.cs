using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics
{
	// Token: 0x020004E9 RID: 1257
	[global::Cpp2ILInjected.Token(Token = "0x2000744")]
	public struct VirtualCamera
	{
		// Token: 0x060036D4 RID: 14036 RVA: 0x0002BCC1 File Offset: 0x00029EC1
		[global::Cpp2ILInjected.Token(Token = "0x6003D47")]
		[global::Cpp2ILInjected.Address(RVA = "0x149F96C", Offset = "0x149F96C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public VirtualCamera(Player player)
		{
			throw null;
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		[global::Cpp2ILInjected.Token(Token = "0x1700077C")]
		public Vector2 Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D48")]
			[global::Cpp2ILInjected.Address(RVA = "0x149F974", Offset = "0x149F974", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualCamera), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x0002BCC7 File Offset: 0x00029EC7
		[global::Cpp2ILInjected.Token(Token = "0x1700077D")]
		public Vector2 Size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D49")]
			[global::Cpp2ILInjected.Address(RVA = "0x149FA28", Offset = "0x149FA28", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x0002BCCA File Offset: 0x00029ECA
		[global::Cpp2ILInjected.Token(Token = "0x1700077E")]
		public Vector2 Center
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x149FA1C", Offset = "0x149FA1C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006740 RID: 26432
		[global::Cpp2ILInjected.Token(Token = "0x4007C28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly Player Player;
	}
}
