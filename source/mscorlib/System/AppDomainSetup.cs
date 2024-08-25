using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000169")]
	[global::System.Serializable]
	[StructLayout(0)]
	public sealed class AppDomainSetup
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79D3C", Offset = "0x1C79D3C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public AppDomainSetup()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000630")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string application_base;

		[global::Cpp2ILInjected.Token(Token = "0x4000631")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string application_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000632")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string cache_path;

		[global::Cpp2ILInjected.Token(Token = "0x4000633")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string configuration_file;

		[global::Cpp2ILInjected.Token(Token = "0x4000634")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string dynamic_base;

		[global::Cpp2ILInjected.Token(Token = "0x4000635")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string license_file;

		[global::Cpp2ILInjected.Token(Token = "0x4000636")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string private_bin_path;

		[global::Cpp2ILInjected.Token(Token = "0x4000637")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string private_bin_path_probe;

		[global::Cpp2ILInjected.Token(Token = "0x4000638")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string shadow_copy_directories;

		[global::Cpp2ILInjected.Token(Token = "0x4000639")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string shadow_copy_files;

		[global::Cpp2ILInjected.Token(Token = "0x400063A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool publisher_policy;

		[global::Cpp2ILInjected.Token(Token = "0x400063B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool path_changed;

		[global::Cpp2ILInjected.Token(Token = "0x400063C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int loader_optimization;

		[global::Cpp2ILInjected.Token(Token = "0x400063D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool disallow_binding_redirects;

		[global::Cpp2ILInjected.Token(Token = "0x400063E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool disallow_code_downloads;

		[global::Cpp2ILInjected.Token(Token = "0x400063F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private object _activationArguments;

		[global::Cpp2ILInjected.Token(Token = "0x4000640")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private object domain_initializer;

		[global::Cpp2ILInjected.Token(Token = "0x4000641")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private object application_trust;

		[global::Cpp2ILInjected.Token(Token = "0x4000642")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private string[] domain_initializer_args;

		[global::Cpp2ILInjected.Token(Token = "0x4000643")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool disallow_appbase_probe;

		[global::Cpp2ILInjected.Token(Token = "0x4000644")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private byte[] configuration_bytes;

		[global::Cpp2ILInjected.Token(Token = "0x4000645")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private byte[] serialized_non_primitives;

		[global::Cpp2ILInjected.Token(Token = "0x4000646")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string manager_assembly;

		[global::Cpp2ILInjected.Token(Token = "0x4000647")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string manager_type;

		[global::Cpp2ILInjected.Token(Token = "0x4000648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private string[] partial_visible_assemblies;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private string <TargetFrameworkName>k__BackingField;
	}
}
