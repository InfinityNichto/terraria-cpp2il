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
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[global::Cpp2ILInjected.Token(Token = "0x20000DC")]
	[StructLayout(0)]
	public sealed class ProcessStartInfo
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000509")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECAA5C", Offset = "0x1ECAA5C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ProcessStartInfo(string fileName)
		{
			throw null;
		}

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

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000520")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECBA64", Offset = "0x1ECBA64", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ProcessStartInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string fileName;

		[global::Cpp2ILInjected.Token(Token = "0x4000400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string arguments;

		[global::Cpp2ILInjected.Token(Token = "0x4000401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string directory;

		[global::Cpp2ILInjected.Token(Token = "0x4000402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string verb;

		[global::Cpp2ILInjected.Token(Token = "0x4000403")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ProcessWindowStyle windowStyle;

		[global::Cpp2ILInjected.Token(Token = "0x4000404")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool errorDialog;

		[global::Cpp2ILInjected.Token(Token = "0x4000405")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private IntPtr errorDialogParentHandle;

		[global::Cpp2ILInjected.Token(Token = "0x4000406")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool useShellExecute;

		[global::Cpp2ILInjected.Token(Token = "0x4000407")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string userName;

		[global::Cpp2ILInjected.Token(Token = "0x4000408")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string domain;

		[global::Cpp2ILInjected.Token(Token = "0x4000409")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private SecureString password;

		[global::Cpp2ILInjected.Token(Token = "0x400040A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string passwordInClearText;

		[global::Cpp2ILInjected.Token(Token = "0x400040B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool loadUserProfile;

		[global::Cpp2ILInjected.Token(Token = "0x400040C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool redirectStandardInput;

		[global::Cpp2ILInjected.Token(Token = "0x400040D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6A")]
		private bool redirectStandardOutput;

		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6B")]
		private bool redirectStandardError;

		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Encoding standardOutputEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000410")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Encoding standardErrorEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool createNoWindow;

		[global::Cpp2ILInjected.Token(Token = "0x4000412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private WeakReference weakParentProcess;

		[global::Cpp2ILInjected.Token(Token = "0x4000413")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal StringDictionary environmentVariables;

		[global::Cpp2ILInjected.Token(Token = "0x4000414")]
		private static readonly string[] empty;

		[global::Cpp2ILInjected.Token(Token = "0x4000415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Collection<string> _argumentList;

		[global::Cpp2ILInjected.Token(Token = "0x4000416")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private IDictionary<string, string> environment;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000417")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private Encoding <StandardInputEncoding>k__BackingField;
	}
}
