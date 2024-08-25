using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[DataContract]
	[global::Cpp2ILInjected.Token(Token = "0x200035F")]
	public class DisplayMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x600167D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3C04", Offset = "0xAA3C04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "set_VirtualScreenSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void UpdateSize(int newWidth, int newHeight)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000292")]
		public float AspectRatio
		{
			[global::Cpp2ILInjected.Token(Token = "0x600167E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C0C", Offset = "0xAA3C0C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "get_IsWideScreen", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000293")]
		public SurfaceFormat Format
		{
			[global::Cpp2ILInjected.Token(Token = "0x600167F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3C20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000294")]
		public int Height
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001680")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C28", Offset = "0xAA3C28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000295")]
		public int Width
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001681")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C30", Offset = "0xAA3C30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000296")]
		public Rectangle TitleSafeArea
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001682")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C38", Offset = "0xAA3C38", Length = "0x68")]
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

		[global::Cpp2ILInjected.Token(Token = "0x6001683")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3CA0", Offset = "0xAA3CA0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "PlatformInitializeAdapters", MemberParameters = new object[] { typeof(ref ReadOnlyCollection<GraphicsAdapter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal DisplayMode(int width, int height, SurfaceFormat format)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001684")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3CDC", Offset = "0xAA3CDC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(DisplayMode left, DisplayMode right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001685")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3D38", Offset = "0xAA3D38", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(DisplayMode left, DisplayMode right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001686")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3D94", Offset = "0xAA3D94", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001687")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3E54", Offset = "0xAA3E54", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001688")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3EA0", Offset = "0xAA3EA0", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40024CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SurfaceFormat format;

		[global::Cpp2ILInjected.Token(Token = "0x40024D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int height;

		[global::Cpp2ILInjected.Token(Token = "0x40024D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int width;
	}
}
