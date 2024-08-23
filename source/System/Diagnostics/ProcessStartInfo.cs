using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000081 RID: 129
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[global::Cpp2ILInjected.Token(Token = "0x20000DC")]
	[StructLayout(0)]
	public sealed class ProcessStartInfo
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x00003ACA File Offset: 0x00001CCA
		[global::Cpp2ILInjected.Token(Token = "0x6000508")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8788", Offset = "0x1EC8788", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_StartInfo", ReturnType = typeof(ProcessStartInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ProcessStartInfo(Process parent)
		{
			throw null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00003ACD File Offset: 0x00001CCD
		[global::Cpp2ILInjected.Token(Token = "0x6000509")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAA5C", Offset = "0x1ECAA5C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ProcessStartInfo(string fileName)
		{
			throw null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00003AD0 File Offset: 0x00001CD0
		[global::Cpp2ILInjected.Token(Token = "0x600050A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECB9BC", Offset = "0x1ECB9BC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "GetClipboard", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "ClearClipboard", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.Clipboard", Member = "SetClipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ProcessStartInfo(string fileName, string arguments)
		{
			throw null;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00003AD3 File Offset: 0x00001CD3
		[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
		public Collection<string> ArgumentList
		{
			[global::Cpp2ILInjected.Token(Token = "0x600050B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB848", Offset = "0x1ECB848", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00003AD6 File Offset: 0x00001CD6
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00003AD9 File Offset: 0x00001CD9
		[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
		[NotifyParentProperty(true)]
		[SettingsBindable(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[DefaultValue(null)]
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		public string Arguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x600050C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB8C0", Offset = "0x1ECB8C0", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600050D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB9F0", Offset = "0x1ECB9F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00003ADC File Offset: 0x00001CDC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DefaultValue(null)]
		[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
		[NotifyParentProperty(true)]
		[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		public StringDictionary EnvironmentVariables
		{
			[global::Cpp2ILInjected.Token(Token = "0x600050E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB368", Offset = "0x1ECB368", Length = "0x4E0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaseSensitiveStringDictionary), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetEnvironmentVariables", ReturnType = typeof(IDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00003ADF File Offset: 0x00001CDF
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00003AE2 File Offset: 0x00001CE2
		[DefaultValue(false)]
		[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
		[NotifyParentProperty(true)]
		[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
		public bool RedirectStandardInput
		{
			[global::Cpp2ILInjected.Token(Token = "0x600050F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB9F8", Offset = "0x1ECB9F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000510")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA00", Offset = "0x1ECBA00", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00003AE5 File Offset: 0x00001CE5
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00003AE8 File Offset: 0x00001CE8
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
		[DefaultValue(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
		public bool RedirectStandardOutput
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000511")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA0C", Offset = "0x1ECBA0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000512")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA14", Offset = "0x1ECBA14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00003AEB File Offset: 0x00001CEB
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
		[DefaultValue(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
		public bool RedirectStandardError
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000513")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA20", Offset = "0x1ECBA20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00003AEE File Offset: 0x00001CEE
		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		public Encoding StandardErrorEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000514")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA28", Offset = "0x1ECBA28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00003AF1 File Offset: 0x00001CF1
		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		public Encoding StandardOutputEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000515")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA30", Offset = "0x1ECBA30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00003AF4 File Offset: 0x00001CF4
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00003AF7 File Offset: 0x00001CF7
		[DefaultValue(true)]
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether to use the operating system shell to start the process.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000F4")]
		public bool UseShellExecute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000516")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA38", Offset = "0x1ECBA38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000517")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA40", Offset = "0x1ECBA40", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00003AFA File Offset: 0x00001CFA
		[NotifyParentProperty(true)]
		[global::Cpp2ILInjected.Token(Token = "0x170000F5")]
		public string UserName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000518")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECAFDC", Offset = "0x1ECAFDC", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00003AFD File Offset: 0x00001CFD
		[global::Cpp2ILInjected.Token(Token = "0x170000F6")]
		public SecureString Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000519")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA4C", Offset = "0x1ECBA4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00003B00 File Offset: 0x00001D00
		[NotifyParentProperty(true)]
		[global::Cpp2ILInjected.Token(Token = "0x170000F7")]
		public string Domain
		{
			[global::Cpp2ILInjected.Token(Token = "0x600051A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB968", Offset = "0x1ECB968", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00003B03 File Offset: 0x00001D03
		[NotifyParentProperty(true)]
		[global::Cpp2ILInjected.Token(Token = "0x170000F8")]
		public bool LoadUserProfile
		{
			[global::Cpp2ILInjected.Token(Token = "0x600051B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA54", Offset = "0x1ECBA54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00003B06 File Offset: 0x00001D06
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The name of the application, document or URL to start.")]
		[SettingsBindable(true)]
		[NotifyParentProperty(true)]
		[DefaultValue(null)]
		[global::Cpp2ILInjected.Token(Token = "0x170000F9")]
		public string FileName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600051C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC9348", Offset = "0x1EC9348", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00003B09 File Offset: 0x00001D09
		[MonitoringDescription("The initial working directory for the process.")]
		[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[DefaultValue(null)]
		[SettingsBindable(true)]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[NotifyParentProperty(true)]
		[global::Cpp2ILInjected.Token(Token = "0x170000FA")]
		public string WorkingDirectory
		{
			[global::Cpp2ILInjected.Token(Token = "0x600051D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB914", Offset = "0x1ECB914", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00003B0C File Offset: 0x00001D0C
		[global::Cpp2ILInjected.Token(Token = "0x170000FB")]
		internal bool HaveEnvVars
		{
			[global::Cpp2ILInjected.Token(Token = "0x600051E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECB358", Offset = "0x1ECB358", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00003B0F File Offset: 0x00001D0F
		[global::Cpp2ILInjected.Token(Token = "0x170000FC")]
		public Encoding StandardInputEncoding
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600051F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECBA5C", Offset = "0x1ECBA5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00003B12 File Offset: 0x00001D12
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000520")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECBA64", Offset = "0x1ECBA64", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ProcessStartInfo()
		{
			throw null;
		}

		// Token: 0x040002AA RID: 682
		[global::Cpp2ILInjected.Token(Token = "0x40003FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string fileName;

		// Token: 0x040002AB RID: 683
		[global::Cpp2ILInjected.Token(Token = "0x4000400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string arguments;

		// Token: 0x040002AC RID: 684
		[global::Cpp2ILInjected.Token(Token = "0x4000401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string directory;

		// Token: 0x040002AD RID: 685
		[global::Cpp2ILInjected.Token(Token = "0x4000402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string verb;

		// Token: 0x040002AE RID: 686
		[global::Cpp2ILInjected.Token(Token = "0x4000403")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ProcessWindowStyle windowStyle;

		// Token: 0x040002AF RID: 687
		[global::Cpp2ILInjected.Token(Token = "0x4000404")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool errorDialog;

		// Token: 0x040002B0 RID: 688
		[global::Cpp2ILInjected.Token(Token = "0x4000405")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private IntPtr errorDialogParentHandle;

		// Token: 0x040002B1 RID: 689
		[global::Cpp2ILInjected.Token(Token = "0x4000406")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool useShellExecute;

		// Token: 0x040002B2 RID: 690
		[global::Cpp2ILInjected.Token(Token = "0x4000407")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string userName;

		// Token: 0x040002B3 RID: 691
		[global::Cpp2ILInjected.Token(Token = "0x4000408")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string domain;

		// Token: 0x040002B4 RID: 692
		[global::Cpp2ILInjected.Token(Token = "0x4000409")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private SecureString password;

		// Token: 0x040002B5 RID: 693
		[global::Cpp2ILInjected.Token(Token = "0x400040A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string passwordInClearText;

		// Token: 0x040002B6 RID: 694
		[global::Cpp2ILInjected.Token(Token = "0x400040B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool loadUserProfile;

		// Token: 0x040002B7 RID: 695
		[global::Cpp2ILInjected.Token(Token = "0x400040C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool redirectStandardInput;

		// Token: 0x040002B8 RID: 696
		[global::Cpp2ILInjected.Token(Token = "0x400040D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6A")]
		private bool redirectStandardOutput;

		// Token: 0x040002B9 RID: 697
		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6B")]
		private bool redirectStandardError;

		// Token: 0x040002BA RID: 698
		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Encoding standardOutputEncoding;

		// Token: 0x040002BB RID: 699
		[global::Cpp2ILInjected.Token(Token = "0x4000410")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Encoding standardErrorEncoding;

		// Token: 0x040002BC RID: 700
		[global::Cpp2ILInjected.Token(Token = "0x4000411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool createNoWindow;

		// Token: 0x040002BD RID: 701
		[global::Cpp2ILInjected.Token(Token = "0x4000412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private WeakReference weakParentProcess;

		// Token: 0x040002BE RID: 702
		[global::Cpp2ILInjected.Token(Token = "0x4000413")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal StringDictionary environmentVariables;

		// Token: 0x040002BF RID: 703
		[global::Cpp2ILInjected.Token(Token = "0x4000414")]
		private static readonly string[] empty;

		// Token: 0x040002C0 RID: 704
		[global::Cpp2ILInjected.Token(Token = "0x4000415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Collection<string> _argumentList;

		// Token: 0x040002C1 RID: 705
		[global::Cpp2ILInjected.Token(Token = "0x4000416")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private IDictionary<string, string> environment;

		// Token: 0x040002C2 RID: 706
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000417")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private Encoding <StandardInputEncoding>k__BackingField;
	}
}
