﻿using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel.Design
{
	[global::Cpp2ILInjected.Token(Token = "0x200040A")]
	internal class RuntimeLicenseContext : LicenseContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8B584", Offset = "0x1E8B584", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeLicenseContext), Member = "GetSavedLicenseKey", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Assembly)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Fragment", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string GetLocalPath(string fileName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8B604", Offset = "0x1E8B604", Length = "0x4D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "GetEntryAssembly", ReturnType = typeof(Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeLicenseContext), Member = "GetLocalPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeLicenseContext), Member = "CaseInsensitiveManifestResourceStreamLookup", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesigntimeLicenseContextSerializer), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(string),
			typeof(RuntimeLicenseContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8BADC", Offset = "0x1E8BADC", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeLicenseContext), Member = "GetSavedLicenseKey", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Assembly)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8BE54", Offset = "0x1E8BE54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LicenseManager), Member = "get_CurrentContext", ReturnType = typeof(LicenseContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LicenseContext), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimeLicenseContext()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001C06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8BE5C", Offset = "0x1E8BE5C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceSwitch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static RuntimeLicenseContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400138C")]
		private static TraceSwitch s_runtimeLicenseContextSwitch;

		[global::Cpp2ILInjected.Token(Token = "0x400138D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Hashtable savedLicenseKeys;
	}
}
