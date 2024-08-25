using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000716")]
	public class LegacyNetDiagnosticsUI : INetDiagnosticsUI
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003C08")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C80C", Offset = "0x148C80C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LegacyNetDiagnosticsUI()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C09")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C814", Offset = "0x148C814", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C8D4", Offset = "0x148C8D4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CountReadMessage(int messageId, int messageLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C978", Offset = "0x148C978", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CountSentMessage(int messageId, int messageLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x148CA1C", Offset = "0x148CA1C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyNetDiagnosticsUI), Member = "DrawTitles", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyNetDiagnosticsUI), Member = "DrawMesageLines", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x148CD74", Offset = "0x148CD74", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyNetDiagnosticsUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyNetDiagnosticsUI), Member = "PrintNetDiagnosticsLineForMessage", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void DrawMesageLines(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x148CA78", Offset = "0x148CA78", Length = "0x2FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyNetDiagnosticsUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static void DrawTitles(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x148CE48", Offset = "0x148CE48", Length = "0x52C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyNetDiagnosticsUI), Member = "DrawMesageLines", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void PrintNetDiagnosticsLineForMessage(SpriteBatch spriteBatch, int msgId, int x, int y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C10")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D374", Offset = "0x148D374", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountReadModuleMessage(int moduleMessageId, int messageLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C11")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D378", Offset = "0x148D378", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountSentModuleMessage(int moduleMessageId, int messageLength)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003C12")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D37C", Offset = "0x148D37C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static LegacyNetDiagnosticsUI()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007B64")]
		public static bool netDiag;

		[global::Cpp2ILInjected.Token(Token = "0x4007B65")]
		public static int txData;

		[global::Cpp2ILInjected.Token(Token = "0x4007B66")]
		public static int rxData;

		[global::Cpp2ILInjected.Token(Token = "0x4007B67")]
		public static int txMsg;

		[global::Cpp2ILInjected.Token(Token = "0x4007B68")]
		public static int rxMsg;

		[global::Cpp2ILInjected.Token(Token = "0x4007B69")]
		private static readonly int maxMsg;

		[global::Cpp2ILInjected.Token(Token = "0x4007B6A")]
		public static int[] rxMsgType;

		[global::Cpp2ILInjected.Token(Token = "0x4007B6B")]
		public static int[] rxDataType;

		[global::Cpp2ILInjected.Token(Token = "0x4007B6C")]
		public static int[] txMsgType;

		[global::Cpp2ILInjected.Token(Token = "0x4007B6D")]
		public static int[] txDataType;
	}
}
