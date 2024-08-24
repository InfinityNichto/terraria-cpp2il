using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x020004CC RID: 1228
	[global::Cpp2ILInjected.Token(Token = "0x2000718")]
	public class NetDiagnosticsUI : INetDiagnosticsUI
	{
		// Token: 0x060035DD RID: 13789 RVA: 0x0002B9E2 File Offset: 0x00029BE2
		[global::Cpp2ILInjected.Token(Token = "0x6003C1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D464", Offset = "0x148D464", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x0002B9E5 File Offset: 0x00029BE5
		[global::Cpp2ILInjected.Token(Token = "0x6003C1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D500", Offset = "0x148D500", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountReadMessage(int messageId, int messageLength)
		{
			throw null;
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0002B9E8 File Offset: 0x00029BE8
		[global::Cpp2ILInjected.Token(Token = "0x6003C1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D544", Offset = "0x148D544", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountSentMessage(int messageId, int messageLength)
		{
			throw null;
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0002B9EB File Offset: 0x00029BEB
		[global::Cpp2ILInjected.Token(Token = "0x6003C1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D588", Offset = "0x148D588", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref NetDiagnosticsUI.CounterForMessage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NetDiagnosticsUI.CounterForMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CountReadModuleMessage(int moduleMessageId, int messageLength)
		{
			throw null;
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0002B9EE File Offset: 0x00029BEE
		[global::Cpp2ILInjected.Token(Token = "0x6003C1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D654", Offset = "0x148D654", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref NetDiagnosticsUI.CounterForMessage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NetDiagnosticsUI.CounterForMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CountSentModuleMessage(int moduleMessageId, int messageLength)
		{
			throw null;
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x0002B9F1 File Offset: 0x00029BF1
		[global::Cpp2ILInjected.Token(Token = "0x6003C1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D71C", Offset = "0x148D71C", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetDiagnosticsUI), Member = "DrawCounter", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref NetDiagnosticsUI.CounterForMessage),
			typeof(string),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x0002B9F4 File Offset: 0x00029BF4
		[global::Cpp2ILInjected.Token(Token = "0x6003C20")]
		[global::Cpp2ILInjected.Address(RVA = "0x148DAB8", Offset = "0x148DAB8", Length = "0x378")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetDiagnosticsUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetDiagnosticsUI), Member = "DrawText", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void DrawCounter(SpriteBatch spriteBatch, ref NetDiagnosticsUI.CounterForMessage counter, string title, Vector2 position)
		{
			throw null;
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0002B9F7 File Offset: 0x00029BF7
		[global::Cpp2ILInjected.Token(Token = "0x6003C21")]
		[global::Cpp2ILInjected.Address(RVA = "0x148DE30", Offset = "0x148DE30", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetDiagnosticsUI), Member = "DrawCounter", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref NetDiagnosticsUI.CounterForMessage),
			typeof(string),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void DrawText(SpriteBatch spriteBatch, string text, Vector2 pos, Color color)
		{
			throw null;
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x0002B9FA File Offset: 0x00029BFA
		[global::Cpp2ILInjected.Token(Token = "0x6003C22")]
		[global::Cpp2ILInjected.Address(RVA = "0x148DF54", Offset = "0x148DF54", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_ActiveNetDiagnosticsUI", ReturnType = typeof(INetDiagnosticsUI))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NetDiagnosticsUI.CounterForMessage>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public NetDiagnosticsUI()
		{
			throw null;
		}

		// Token: 0x040066A7 RID: 26279
		[global::Cpp2ILInjected.Token(Token = "0x4007B6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NetDiagnosticsUI.CounterForMessage[] _counterByMessageId;

		// Token: 0x040066A8 RID: 26280
		[global::Cpp2ILInjected.Token(Token = "0x4007B6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<int, NetDiagnosticsUI.CounterForMessage> _counterByModuleId;

		// Token: 0x040066A9 RID: 26281
		[global::Cpp2ILInjected.Token(Token = "0x4007B70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _highestFoundReadBytes;

		// Token: 0x040066AA RID: 26282
		[global::Cpp2ILInjected.Token(Token = "0x4007B71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _highestFoundReadCount;

		// Token: 0x02000959 RID: 2393
		[global::Cpp2ILInjected.Token(Token = "0x2000719")]
		private struct CounterForMessage
		{
			// Token: 0x06004D17 RID: 19735 RVA: 0x0002FA0E File Offset: 0x0002DC0E
			[global::Cpp2ILInjected.Token(Token = "0x6003C23")]
			[global::Cpp2ILInjected.Address(RVA = "0x148D4F8", Offset = "0x148D4F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x06004D18 RID: 19736 RVA: 0x0002FA11 File Offset: 0x0002DC11
			[global::Cpp2ILInjected.Token(Token = "0x6003C24")]
			[global::Cpp2ILInjected.Address(RVA = "0x148D528", Offset = "0x148D528", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void CountReadMessage(int messageLength)
			{
				throw null;
			}

			// Token: 0x06004D19 RID: 19737 RVA: 0x0002FA14 File Offset: 0x0002DC14
			[global::Cpp2ILInjected.Token(Token = "0x6003C25")]
			[global::Cpp2ILInjected.Address(RVA = "0x148D56C", Offset = "0x148D56C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void CountSentMessage(int messageLength)
			{
				throw null;
			}

			// Token: 0x04008B7D RID: 35709
			[global::Cpp2ILInjected.Token(Token = "0x4007B72")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int timesReceived;

			// Token: 0x04008B7E RID: 35710
			[global::Cpp2ILInjected.Token(Token = "0x4007B73")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int timesSent;

			// Token: 0x04008B7F RID: 35711
			[global::Cpp2ILInjected.Token(Token = "0x4007B74")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int bytesReceived;

			// Token: 0x04008B80 RID: 35712
			[global::Cpp2ILInjected.Token(Token = "0x4007B75")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int bytesSent;

			// Token: 0x04008B81 RID: 35713
			[global::Cpp2ILInjected.Token(Token = "0x4007B76")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool exemptFromBadScoreTest;
		}
	}
}
