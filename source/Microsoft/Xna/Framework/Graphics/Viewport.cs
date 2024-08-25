using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[DataContract]
	[global::Cpp2ILInjected.Token(Token = "0x20003AD")]
	public struct Viewport
	{
		[DataMember]
		[global::Cpp2ILInjected.Token(Token = "0x17000355")]
		public int Height
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001932")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74A0", Offset = "0xAC74A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001933")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74A8", Offset = "0xAC74A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[DataMember]
		[global::Cpp2ILInjected.Token(Token = "0x17000356")]
		public float MaxDepth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001934")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74B0", Offset = "0xAC74B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001935")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74B8", Offset = "0xAC74B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[DataMember]
		[global::Cpp2ILInjected.Token(Token = "0x17000357")]
		public float MinDepth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001936")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74C0", Offset = "0xAC74C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001937")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74C8", Offset = "0xAC74C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[DataMember]
		[global::Cpp2ILInjected.Token(Token = "0x17000358")]
		public int Width
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001938")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74D0", Offset = "0xAC74D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001939")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74D8", Offset = "0xAC74D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[DataMember]
		[global::Cpp2ILInjected.Token(Token = "0x17000359")]
		public int Y
		{
			[global::Cpp2ILInjected.Token(Token = "0x600193A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74E0", Offset = "0xAC74E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600193B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74E8", Offset = "0xAC74E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[DataMember]
		[global::Cpp2ILInjected.Token(Token = "0x1700035A")]
		public int X
		{
			[global::Cpp2ILInjected.Token(Token = "0x600193C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74F0", Offset = "0xAC74F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600193D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC74F8", Offset = "0xAC74F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035B")]
		public float AspectRatio
		{
			[global::Cpp2ILInjected.Token(Token = "0x600193E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC7500", Offset = "0xAC7500", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035C")]
		public Rectangle Bounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x600193F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC7524", Offset = "0xAC7524", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001940")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC7554", Offset = "0xAC7554", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035D")]
		public Rectangle TitleSafeArea
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001941")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC7568", Offset = "0xAC7568", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "GetTitleSafeArea", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001942")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC75DC", Offset = "0xAC75DC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "Setup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Viewport(int x, int y, int width, int height)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001943")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC75F4", Offset = "0xAC75F4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Viewport(int x, int y, int width, int height, float minDepth, float maxDepth)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001944")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7604", Offset = "0xAC7604", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Viewport(Rectangle bounds)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001945")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7624", Offset = "0xAC7624", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Vector3 Project(Vector3 source, Matrix projection, Matrix view, Matrix world)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001946")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7950", Offset = "0xAC7950", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Matrix)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Vector3 Unproject(Vector3 source, Matrix projection, Matrix view, Matrix world)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001947")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7924", Offset = "0xAC7924", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool WithinEpsilon(float a, float b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001948")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC7C80", Offset = "0xAC7C80", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002793")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int x;

		[global::Cpp2ILInjected.Token(Token = "0x4002794")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int y;

		[global::Cpp2ILInjected.Token(Token = "0x4002795")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int width;

		[global::Cpp2ILInjected.Token(Token = "0x4002796")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private int height;

		[global::Cpp2ILInjected.Token(Token = "0x4002797")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float minDepth;

		[global::Cpp2ILInjected.Token(Token = "0x4002798")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float maxDepth;
	}
}
