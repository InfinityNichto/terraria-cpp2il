using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200010E")]
	public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000120")]
		public VertexAttribute attribute
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600056A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A470", Offset = "0x1F8A470", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600056B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A478", Offset = "0x1F8A478", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000121")]
		public VertexAttributeFormat format
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600056C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A480", Offset = "0x1F8A480", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600056D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A488", Offset = "0x1F8A488", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000122")]
		public int dimension
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600056E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A490", Offset = "0x1F8A490", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600056F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A498", Offset = "0x1F8A498", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000123")]
		public int stream
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000570")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A4A0", Offset = "0x1F8A4A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000571")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A4A8", Offset = "0x1F8A4A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A4B0", Offset = "0x1F8A4B0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.SpriteBatcher", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000573")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A4BC", Offset = "0x1F8A4BC", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000574")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A658", Offset = "0x1F8A658", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000575")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A680", Offset = "0x1F8A680", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000576")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A728", Offset = "0x1F8A728", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(VertexAttributeDescriptor other)
		{
			throw null;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000474")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private VertexAttribute <attribute>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000475")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private VertexAttributeFormat <format>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000476")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int <dimension>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000477")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private int <stream>k__BackingField;
	}
}
