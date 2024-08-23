using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002FE RID: 766
	[global::System.CLSCompliant(false)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003A3")]
	[global::System.Serializable]
	public class ConstructionCall : MethodCall, global::System.Runtime.Remoting.Activation.IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
	{
		// Token: 0x06001BAF RID: 7087 RVA: 0x0001928C File Offset: 0x0001748C
		[global::Cpp2ILInjected.Token(Token = "0x6001DE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B354A8", Offset = "0x1B354A8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ConstructionCall(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0001928F File Offset: 0x0001748F
		[global::Cpp2ILInjected.Token(Token = "0x6001DE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47E3C", Offset = "0x1B47E3C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal ConstructionCall(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00019292 File Offset: 0x00017492
		[global::Cpp2ILInjected.Token(Token = "0x6001DE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47ECC", Offset = "0x1B47ECC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructionCallDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override void InitDictionary()
		{
			throw null;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00019295 File Offset: 0x00017495
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x00019298 File Offset: 0x00017498
		[global::Cpp2ILInjected.Token(Token = "0x170003A4")]
		internal bool IsContextOk
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B47FF4", Offset = "0x1B47FF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001DE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B47FFC", Offset = "0x1B47FFC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0001929B File Offset: 0x0001749B
		[global::Cpp2ILInjected.Token(Token = "0x170003A5")]
		public global::System.Type ActivationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B48008", Offset = "0x1B48008", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0001929E File Offset: 0x0001749E
		[global::Cpp2ILInjected.Token(Token = "0x170003A6")]
		public string ActivationTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B480D0", Offset = "0x1B480D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x000192A1 File Offset: 0x000174A1
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x000192A4 File Offset: 0x000174A4
		[global::Cpp2ILInjected.Token(Token = "0x170003A7")]
		public global::System.Runtime.Remoting.Activation.IActivator Activator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B480D8", Offset = "0x1B480D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001DE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B480E0", Offset = "0x1B480E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x000192A7 File Offset: 0x000174A7
		[global::Cpp2ILInjected.Token(Token = "0x170003A8")]
		public object[] CallSiteActivationAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B480E8", Offset = "0x1B480E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000192AA File Offset: 0x000174AA
		[global::Cpp2ILInjected.Token(Token = "0x6001DEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B480F0", Offset = "0x1B480F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetActivationAttributes(object[] attributes)
		{
			throw null;
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x000192AD File Offset: 0x000174AD
		[global::Cpp2ILInjected.Token(Token = "0x170003A9")]
		public global::System.Collections.IList ContextProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B480F8", Offset = "0x1B480F8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000192B0 File Offset: 0x000174B0
		[global::Cpp2ILInjected.Token(Token = "0x6001DED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4815C", Offset = "0x1B4815C", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal override void InitMethodProperty(string key, object value)
		{
			throw null;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000192B3 File Offset: 0x000174B3
		[global::Cpp2ILInjected.Token(Token = "0x6001DEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B48820", Offset = "0x1B48820", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodCall), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x000192B6 File Offset: 0x000174B6
		[global::Cpp2ILInjected.Token(Token = "0x170003AA")]
		public override global::System.Collections.IDictionary Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B48E34", Offset = "0x1B48E34", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x000192B9 File Offset: 0x000174B9
		// (set) Token: 0x06001BBF RID: 7103 RVA: 0x000192BC File Offset: 0x000174BC
		[global::Cpp2ILInjected.Token(Token = "0x170003AB")]
		internal global::System.Runtime.Remoting.Proxies.RemotingProxy SourceProxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B48E94", Offset = "0x1B48E94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001DF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B48E9C", Offset = "0x1B48E9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000C2D RID: 3117
		[global::Cpp2ILInjected.Token(Token = "0x4000F19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.Runtime.Remoting.Activation.IActivator _activator;

		// Token: 0x04000C2E RID: 3118
		[global::Cpp2ILInjected.Token(Token = "0x4000F1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private object[] _activationAttributes;

		// Token: 0x04000C2F RID: 3119
		[global::Cpp2ILInjected.Token(Token = "0x4000F1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private global::System.Collections.IList _contextProperties;

		// Token: 0x04000C30 RID: 3120
		[global::Cpp2ILInjected.Token(Token = "0x4000F1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private global::System.Type _activationType;

		// Token: 0x04000C31 RID: 3121
		[global::Cpp2ILInjected.Token(Token = "0x4000F1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private string _activationTypeName;

		// Token: 0x04000C32 RID: 3122
		[global::Cpp2ILInjected.Token(Token = "0x4000F1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool _isContextOk;

		// Token: 0x04000C33 RID: 3123
		[global::Cpp2ILInjected.Token(Token = "0x4000F1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		[global::System.NonSerialized]
		private global::System.Runtime.Remoting.Proxies.RemotingProxy _sourceProxy;
	}
}
