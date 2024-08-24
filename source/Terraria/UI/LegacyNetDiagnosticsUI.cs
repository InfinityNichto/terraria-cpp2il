using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x020004CA RID: 1226
	[global::Cpp2ILInjected.Token(Token = "0x2000716")]
	public class LegacyNetDiagnosticsUI : INetDiagnosticsUI
	{
		// Token: 0x060035CB RID: 13771 RVA: 0x0002B9AC File Offset: 0x00029BAC
		[global::Cpp2ILInjected.Token(Token = "0x6003C08")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C80C", Offset = "0x148C80C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LegacyNetDiagnosticsUI()
		{
			throw null;
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x0002B9AF File Offset: 0x00029BAF
		[global::Cpp2ILInjected.Token(Token = "0x6003C09")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C814", Offset = "0x148C814", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0002B9B2 File Offset: 0x00029BB2
		[global::Cpp2ILInjected.Token(Token = "0x6003C0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C8D4", Offset = "0x148C8D4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CountReadMessage(int messageId, int messageLength)
		{
			throw null;
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0002B9B5 File Offset: 0x00029BB5
		[global::Cpp2ILInjected.Token(Token = "0x6003C0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C978", Offset = "0x148C978", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CountSentMessage(int messageId, int messageLength)
		{
			throw null;
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x0002B9B8 File Offset: 0x00029BB8
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

		// Token: 0x060035D0 RID: 13776 RVA: 0x0002B9BB File Offset: 0x00029BBB
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

		// Token: 0x060035D1 RID: 13777 RVA: 0x0002B9BE File Offset: 0x00029BBE
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

		// Token: 0x060035D2 RID: 13778 RVA: 0x0002B9C1 File Offset: 0x00029BC1
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

		// Token: 0x060035D3 RID: 13779 RVA: 0x0002B9C4 File Offset: 0x00029BC4
		[global::Cpp2ILInjected.Token(Token = "0x6003C10")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D374", Offset = "0x148D374", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountReadModuleMessage(int moduleMessageId, int messageLength)
		{
			throw null;
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x0002B9C7 File Offset: 0x00029BC7
		[global::Cpp2ILInjected.Token(Token = "0x6003C11")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D378", Offset = "0x148D378", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountSentModuleMessage(int moduleMessageId, int messageLength)
		{
			throw null;
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x0002B9CA File Offset: 0x00029BCA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003C12")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D37C", Offset = "0x148D37C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static LegacyNetDiagnosticsUI()
		{
			throw null;
		}

		// Token: 0x0400669D RID: 26269
		[global::Cpp2ILInjected.Token(Token = "0x4007B64")]
		public static bool netDiag;

		// Token: 0x0400669E RID: 26270
		[global::Cpp2ILInjected.Token(Token = "0x4007B65")]
		public static int txData;

		// Token: 0x0400669F RID: 26271
		[global::Cpp2ILInjected.Token(Token = "0x4007B66")]
		public static int rxData;

		// Token: 0x040066A0 RID: 26272
		[global::Cpp2ILInjected.Token(Token = "0x4007B67")]
		public static int txMsg;

		// Token: 0x040066A1 RID: 26273
		[global::Cpp2ILInjected.Token(Token = "0x4007B68")]
		public static int rxMsg;

		// Token: 0x040066A2 RID: 26274
		[global::Cpp2ILInjected.Token(Token = "0x4007B69")]
		private static readonly int maxMsg;

		// Token: 0x040066A3 RID: 26275
		[global::Cpp2ILInjected.Token(Token = "0x4007B6A")]
		public static int[] rxMsgType;

		// Token: 0x040066A4 RID: 26276
		[global::Cpp2ILInjected.Token(Token = "0x4007B6B")]
		public static int[] rxDataType;

		// Token: 0x040066A5 RID: 26277
		[global::Cpp2ILInjected.Token(Token = "0x4007B6C")]
		public static int[] txMsgType;

		// Token: 0x040066A6 RID: 26278
		[global::Cpp2ILInjected.Token(Token = "0x4007B6D")]
		public static int[] txDataType;
	}
}
