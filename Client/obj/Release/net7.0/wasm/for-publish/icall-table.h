#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
218,
226,
227,
228,
229,
230,
231,
232,
233,
234,
237,
238,
410,
411,
413,
441,
442,
443,
463,
464,
465,
466,
564,
565,
566,
569,
606,
607,
608,
611,
613,
615,
617,
622,
630,
631,
632,
633,
634,
635,
636,
637,
638,
639,
640,
641,
642,
643,
644,
645,
646,
648,
649,
650,
651,
652,
653,
654,
746,
747,
748,
749,
750,
751,
752,
753,
754,
755,
756,
757,
758,
759,
760,
761,
762,
764,
765,
766,
767,
768,
769,
770,
896,
905,
908,
910,
915,
916,
918,
919,
923,
924,
926,
927,
930,
931,
932,
935,
937,
940,
942,
944,
1015,
1017,
1019,
1028,
1029,
1030,
1031,
1033,
1040,
1041,
1042,
1043,
1044,
1052,
1053,
1054,
1058,
1059,
1061,
1065,
1066,
1067,
1338,
1533,
1534,
8791,
8792,
8794,
8795,
8796,
8797,
8798,
8800,
8802,
8804,
8805,
8806,
8815,
8817,
8823,
8824,
8826,
8828,
8830,
8841,
8850,
8851,
8853,
8854,
8855,
8856,
8857,
8859,
8861,
9927,
9931,
9933,
9934,
9935,
9936,
10079,
10080,
10081,
10082,
10102,
10103,
10104,
10106,
10149,
10203,
10205,
10216,
10217,
10218,
10219,
10644,
10645,
10646,
10651,
10652,
10685,
10708,
10714,
10721,
10731,
10734,
10822,
10824,
10836,
10838,
10839,
10840,
10847,
10860,
10880,
10881,
10889,
10891,
10898,
10899,
10902,
10904,
10909,
10915,
10916,
10923,
10925,
10937,
10940,
10941,
10942,
10953,
10962,
10968,
10969,
10970,
10972,
10973,
10991,
10993,
11007,
11030,
11031,
11049,
11054,
11084,
11085,
11538,
11539,
11614,
11693,
11943,
11944,
11950,
11951,
11952,
11958,
12028,
12465,
12466,
12982,
12983,
13917,
13938,
13945,
13947,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementType_raw (int,int);
int ves_icall_System_Array_IsValueOfElementType_raw (int,int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy_raw (int,int,int,int,int,int);
int ves_icall_System_Array_GetLength_raw (int,int,int);
int ves_icall_System_Array_GetLowerBound_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
int ves_icall_System_Array_GetValueImpl_raw (int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
int ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw (int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int mono_object_hash_icall_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_Debugger_IsLogging ();
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 218,
ves_icall_System_Array_InternalCreate,
// token 226,
ves_icall_System_Array_GetCorElementTypeOfElementType_raw,
// token 227,
ves_icall_System_Array_IsValueOfElementType_raw,
// token 228,
ves_icall_System_Array_CanChangePrimitive,
// token 229,
ves_icall_System_Array_FastCopy_raw,
// token 230,
ves_icall_System_Array_GetLength_raw,
// token 231,
ves_icall_System_Array_GetLowerBound_raw,
// token 232,
ves_icall_System_Array_GetGenericValue_icall,
// token 233,
ves_icall_System_Array_GetValueImpl_raw,
// token 234,
ves_icall_System_Array_SetGenericValue_icall,
// token 237,
ves_icall_System_Array_SetValueImpl_raw,
// token 238,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 410,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 411,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 413,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 441,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 442,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 443,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 463,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 464,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 465,
ves_icall_System_Enum_InternalGetCorElementType,
// token 466,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 564,
ves_icall_System_Environment_get_ProcessorCount,
// token 565,
ves_icall_System_Environment_get_TickCount,
// token 566,
ves_icall_System_Environment_get_TickCount64,
// token 569,
ves_icall_System_Environment_FailFast_raw,
// token 606,
ves_icall_System_GC_GetCollectionCount,
// token 607,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 608,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 611,
ves_icall_System_GC_SuppressFinalize_raw,
// token 613,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 615,
ves_icall_System_GC_GetGCMemoryInfo,
// token 617,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 622,
ves_icall_System_Object_MemberwiseClone_raw,
// token 630,
ves_icall_System_Math_Acos,
// token 631,
ves_icall_System_Math_Acosh,
// token 632,
ves_icall_System_Math_Asin,
// token 633,
ves_icall_System_Math_Asinh,
// token 634,
ves_icall_System_Math_Atan,
// token 635,
ves_icall_System_Math_Atan2,
// token 636,
ves_icall_System_Math_Atanh,
// token 637,
ves_icall_System_Math_Cbrt,
// token 638,
ves_icall_System_Math_Ceiling,
// token 639,
ves_icall_System_Math_Cos,
// token 640,
ves_icall_System_Math_Cosh,
// token 641,
ves_icall_System_Math_Exp,
// token 642,
ves_icall_System_Math_Floor,
// token 643,
ves_icall_System_Math_Log,
// token 644,
ves_icall_System_Math_Log10,
// token 645,
ves_icall_System_Math_Pow,
// token 646,
ves_icall_System_Math_Sin,
// token 648,
ves_icall_System_Math_Sinh,
// token 649,
ves_icall_System_Math_Sqrt,
// token 650,
ves_icall_System_Math_Tan,
// token 651,
ves_icall_System_Math_Tanh,
// token 652,
ves_icall_System_Math_FusedMultiplyAdd,
// token 653,
ves_icall_System_Math_Log2,
// token 654,
ves_icall_System_Math_ModF,
// token 746,
ves_icall_System_MathF_Acos,
// token 747,
ves_icall_System_MathF_Acosh,
// token 748,
ves_icall_System_MathF_Asin,
// token 749,
ves_icall_System_MathF_Asinh,
// token 750,
ves_icall_System_MathF_Atan,
// token 751,
ves_icall_System_MathF_Atan2,
// token 752,
ves_icall_System_MathF_Atanh,
// token 753,
ves_icall_System_MathF_Cbrt,
// token 754,
ves_icall_System_MathF_Ceiling,
// token 755,
ves_icall_System_MathF_Cos,
// token 756,
ves_icall_System_MathF_Cosh,
// token 757,
ves_icall_System_MathF_Exp,
// token 758,
ves_icall_System_MathF_Floor,
// token 759,
ves_icall_System_MathF_Log,
// token 760,
ves_icall_System_MathF_Log10,
// token 761,
ves_icall_System_MathF_Pow,
// token 762,
ves_icall_System_MathF_Sin,
// token 764,
ves_icall_System_MathF_Sinh,
// token 765,
ves_icall_System_MathF_Sqrt,
// token 766,
ves_icall_System_MathF_Tan,
// token 767,
ves_icall_System_MathF_Tanh,
// token 768,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 769,
ves_icall_System_MathF_Log2,
// token 770,
ves_icall_System_MathF_ModF,
// token 896,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 905,
ves_icall_RuntimeType_make_array_type_raw,
// token 908,
ves_icall_RuntimeType_make_byref_type_raw,
// token 910,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 915,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 916,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 918,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 919,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 923,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 924,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 926,
ves_icall_System_RuntimeType_getFullName_raw,
// token 927,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 930,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 931,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 932,
ves_icall_RuntimeType_GetFields_native_raw,
// token 935,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 937,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 940,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 942,
ves_icall_RuntimeType_GetName_raw,
// token 944,
ves_icall_RuntimeType_GetNamespace_raw,
// token 1015,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 1017,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 1019,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1028,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 1029,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 1030,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 1031,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1033,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1040,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1041,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1042,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1043,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1044,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1052,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1053,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 1054,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1058,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 1059,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1061,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1065,
ves_icall_System_String_FastAllocateString_raw,
// token 1066,
ves_icall_System_String_InternalIsInterned_raw,
// token 1067,
ves_icall_System_String_InternalIntern_raw,
// token 1338,
ves_icall_System_Type_internal_from_handle_raw,
// token 1533,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1534,
ves_icall_System_ValueType_Equals_raw,
// token 8791,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 8792,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 8794,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 8795,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 8796,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 8797,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 8798,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 8800,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 8802,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 8804,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 8805,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 8806,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 8815,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 8817,
mono_monitor_exit_icall_raw,
// token 8823,
ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw,
// token 8824,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 8826,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 8828,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 8830,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 8841,
ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw,
// token 8850,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 8851,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 8853,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 8854,
ves_icall_System_Threading_Thread_GetState_raw,
// token 8855,
ves_icall_System_Threading_Thread_SetState_raw,
// token 8856,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 8857,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 8859,
ves_icall_System_Threading_Thread_YieldInternal,
// token 8861,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 9927,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 9931,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 9933,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 9934,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 9935,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 9936,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 10079,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 10080,
ves_icall_System_GCHandle_InternalFree_raw,
// token 10081,
ves_icall_System_GCHandle_InternalGet_raw,
// token 10082,
ves_icall_System_GCHandle_InternalSet_raw,
// token 10102,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 10103,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 10104,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 10106,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 10149,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 10203,
mono_object_hash_icall_raw,
// token 10205,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 10216,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 10217,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 10218,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 10219,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 10644,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 10645,
ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw,
// token 10646,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 10651,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 10652,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 10685,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 10708,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 10714,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 10721,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 10731,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 10734,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 10822,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 10824,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 10836,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 10838,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 10839,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 10840,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 10847,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 10860,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 10880,
ves_icall_reflection_get_token_raw,
// token 10881,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 10889,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 10891,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 10898,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 10899,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 10902,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 10904,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 10909,
ves_icall_reflection_get_token_raw,
// token 10915,
ves_icall_get_method_info_raw,
// token 10916,
ves_icall_get_method_attributes,
// token 10923,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 10925,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 10937,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 10940,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 10941,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 10942,
ves_icall_reflection_get_token_raw,
// token 10953,
ves_icall_InternalInvoke_raw,
// token 10962,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 10968,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 10969,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 10970,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 10972,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 10973,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 10991,
ves_icall_InvokeClassConstructor_raw,
// token 10993,
ves_icall_InternalInvoke_raw,
// token 11007,
ves_icall_reflection_get_token_raw,
// token 11030,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 11031,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 11049,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 11054,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 11084,
ves_icall_reflection_get_token_raw,
// token 11085,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 11538,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 11539,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 11614,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 11693,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 11943,
ves_icall_ModuleBuilder_basic_init_raw,
// token 11944,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 11950,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 11951,
ves_icall_ModuleBuilder_getToken_raw,
// token 11952,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 11958,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 12028,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 12465,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 12466,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 12982,
ves_icall_System_Diagnostics_Debugger_IsLogging,
// token 12983,
ves_icall_System_Diagnostics_Debugger_Log,
// token 13917,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 13938,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 13945,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 13947,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_handles [] = {
0,
1,
1,
0,
1,
1,
1,
0,
1,
0,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
0,
1,
0,
0,
0,
1,
0,
1,
1,
1,
1,
0,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
};
