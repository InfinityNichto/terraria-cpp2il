using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x2000807")]
	public class VanillaContentValidator : IContentValidator
	{
		[global::Cpp2ILInjected.Token(Token = "0x60041D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x784008", Offset = "0x784008", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, VanillaContentValidator.TextureMetaData>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ReadEmbeddedResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Split", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, VanillaContentValidator.TextureMetaData>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(VanillaContentValidator.TextureMetaData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public VanillaContentValidator(string infoFilePath)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4338", Offset = "0x15A4338", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, VanillaContentValidator.TextureMetaData>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref VanillaContentValidator.TextureMetaData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VanillaContentValidator.TextureMetaData), Member = "Matches", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref IRejectionReason)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool AssetIsValid<T>(T content, string contentPath, out IRejectionReason rejectReason) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60041D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x784200", Offset = "0x784200", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, VanillaContentValidator.TextureMetaData>, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(KeyValuePair<object, VanillaContentValidator.TextureMetaData>),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<object, VanillaContentValidator.TextureMetaData>>),
			typeof(Func<KeyValuePair<object, VanillaContentValidator.TextureMetaData>, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public HashSet<string> GetValidImageFilePaths()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400809A")]
		public static VanillaContentValidator Instance;

		[global::Cpp2ILInjected.Token(Token = "0x400809B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<string, VanillaContentValidator.TextureMetaData> _info;

		[global::Cpp2ILInjected.Token(Token = "0x2000808")]
		private struct TextureMetaData
		{
			[global::Cpp2ILInjected.Token(Token = "0x60041D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x784354", Offset = "0x784354", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VanillaContentValidator), Member = "AssetIsValid", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T",
				typeof(string),
				typeof(ref IRejectionReason)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool Matches(Texture2D texture, out IRejectionReason rejectReason)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400809C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Width;

			[global::Cpp2ILInjected.Token(Token = "0x400809D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int Height;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000809")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60041D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x784444", Offset = "0x784444", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x7844A0", Offset = "0x7844A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x7844A8", Offset = "0x7844A8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <GetValidImageFilePaths>b__4_0(KeyValuePair<string, VanillaContentValidator.TextureMetaData> x)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400809E")]
			public static readonly VanillaContentValidator.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x400809F")]
			public static Func<KeyValuePair<string, VanillaContentValidator.TextureMetaData>, string> <>9__4_0;
		}
	}
}
