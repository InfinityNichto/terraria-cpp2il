using System;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B18")]
	public class WrappedTextBuilder
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005321")]
		[global::Cpp2ILInjected.Address(RVA = "0x940FFC", Offset = "0x940FFC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "CreateWrappedText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(CultureInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public WrappedTextBuilder(SpriteFont font, float maxWidth, CultureInfo culture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005322")]
		[global::Cpp2ILInjected.Address(RVA = "0x9410A0", Offset = "0x9410A0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(WrappedTextBuilder.NonBreakingText) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		public void CommitWorkingLine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005323")]
		[global::Cpp2ILInjected.Address(RVA = "0x9410E8", Offset = "0x9410E8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WrappedTextBuilder), Member = "CommitWorkingLine", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WrappedTextBuilder.NonBreakingText), Member = "GetAsWrappedText", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		private void Append(WrappedTextBuilder.NonBreakingText textToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005324")]
		[global::Cpp2ILInjected.Address(RVA = "0x9413B4", Offset = "0x9413B4", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont), Member = "CreateWrappedText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(CultureInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(WrappedTextBuilder.NonBreakingText) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "EnsureCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WrappedTextBuilder), Member = "CommitWorkingLine", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReaderWrapExtension), Member = "ReadUntilBreakable", MemberParameters = new object[]
		{
			typeof(StringReader),
			typeof(CultureInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WrappedTextBuilder.NonBreakingText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(WrappedTextBuilder.NonBreakingText) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Append(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005325")]
		[global::Cpp2ILInjected.Address(RVA = "0x9417F4", Offset = "0x9417F4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008AF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly SpriteFont _font;

		[global::Cpp2ILInjected.Token(Token = "0x4008AF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly CultureInfo _culture;

		[global::Cpp2ILInjected.Token(Token = "0x4008AF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly float _maxWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4008AF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly StringBuilder _completedText;

		[global::Cpp2ILInjected.Token(Token = "0x4008AF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly StringBuilder _workingLine;

		[global::Cpp2ILInjected.Token(Token = "0x4008AFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float _workingLineWidth;

		[global::Cpp2ILInjected.Token(Token = "0x2000B19")]
		private struct NonBreakingText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005326")]
			[global::Cpp2ILInjected.Address(RVA = "0x9416B8", Offset = "0x9416B8", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetCharacterMetrics", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(SpriteFont.Glyph))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public NonBreakingText(SpriteFont font, string text)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005327")]
			[global::Cpp2ILInjected.Address(RVA = "0x94121C", Offset = "0x94121C", Length = "0x198")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(WrappedTextBuilder.NonBreakingText) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetCharacterMetrics", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(SpriteFont.Glyph))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public string GetAsWrappedText(float maxWidth)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008AFB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly string Text;

			[global::Cpp2ILInjected.Token(Token = "0x4008AFC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly float Width;

			[global::Cpp2ILInjected.Token(Token = "0x4008AFD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public readonly float WidthOnNewLine;

			[global::Cpp2ILInjected.Token(Token = "0x4008AFE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly bool IsWhitespace;

			[global::Cpp2ILInjected.Token(Token = "0x4008AFF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly SpriteFont _font;
		}
	}
}
