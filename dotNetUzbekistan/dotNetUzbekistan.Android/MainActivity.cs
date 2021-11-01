using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Views;
using Java.Util.Concurrent;
using Android.Content;
using Android.Content.Res;
using Java.IO;
using Java.Lang;
using Android.Graphics.Drawables;
using Android.Transitions;
using AndroidX.Lifecycle;
using Java.Interop;
using AndroidX.AppCompat.App;
using System.IO;
using Android.Database.Sqlite;
using Android.Database;
using Android.Graphics;
using Android.Views.Accessibility;
using Android.Util;
using Java.Util.Functions;
using Android.App.Assist;
using System.Collections.Generic;

namespace dotNetUzbekistan.Droid
{
    [Activity(Label = "dotNetUzbekistan", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public override string AttributionTag => base.AttributionTag;

        public override Display Display => base.Display;

        public override bool IsRestricted => base.IsRestricted;

        public override IExecutor MainExecutor => base.MainExecutor;

        public override string OpPackageName => base.OpPackageName;

        public override Context ApplicationContext => base.ApplicationContext;

        public override ApplicationInfo ApplicationInfo => base.ApplicationInfo;

        public override AssetManager Assets => base.Assets;

        public override Context BaseContext => base.BaseContext;

        public override Java.IO.File CacheDir => base.CacheDir;

        public override ClassLoader ClassLoader => base.ClassLoader;

        public override Java.IO.File CodeCacheDir => base.CodeCacheDir;

        public override ContentResolver ContentResolver => base.ContentResolver;

        public override Java.IO.File DataDir => base.DataDir;

        public override Java.IO.File ExternalCacheDir => base.ExternalCacheDir;

        public override Java.IO.File FilesDir => base.FilesDir;

        public override bool IsDeviceProtectedStorage => base.IsDeviceProtectedStorage;

        public override Looper MainLooper => base.MainLooper;

        public override Java.IO.File NoBackupFilesDir => base.NoBackupFilesDir;

        public override Java.IO.File ObbDir => base.ObbDir;

        public override string PackageCodePath => base.PackageCodePath;

        public override PackageManager PackageManager => base.PackageManager;

        public override string PackageName => base.PackageName;

        public override string PackageResourcePath => base.PackageResourcePath;

        public override Resources Resources => base.Resources;

        public override Resources.Theme Theme => base.Theme;

        public override Drawable Wallpaper => base.Wallpaper;

        public override int WallpaperDesiredMinimumHeight => base.WallpaperDesiredMinimumHeight;

        public override int WallpaperDesiredMinimumWidth => base.WallpaperDesiredMinimumWidth;

        public override Android.App.ActionBar ActionBar => base.ActionBar;

        public override ComponentName CallingActivity => base.CallingActivity;

        public override string CallingPackage => base.CallingPackage;

        public override ConfigChanges ChangingConfigurations => base.ChangingConfigurations;

        public override ComponentName ComponentName => base.ComponentName;

        public override Scene ContentScene => base.ContentScene;

        public override TransitionManager ContentTransitionManager { get => base.ContentTransitionManager; set => base.ContentTransitionManager = value; }

        public override View CurrentFocus => base.CurrentFocus;

        public override Android.App.FragmentManager FragmentManager => base.FragmentManager;

        public override bool HasWindowFocus => base.HasWindowFocus;

        public override bool Immersive { get => base.Immersive; set => base.Immersive = value; }
        public override Intent Intent { get => base.Intent; set => base.Intent = value; }

        public override bool IsActivityTransitionRunning => base.IsActivityTransitionRunning;

        public override bool IsChangingConfigurations => base.IsChangingConfigurations;

        public override bool IsDestroyed => base.IsDestroyed;

        public override bool IsFinishing => base.IsFinishing;

        public override bool IsInMultiWindowMode => base.IsInMultiWindowMode;

        public override bool IsInPictureInPictureMode => base.IsInPictureInPictureMode;

        public override bool IsLocalVoiceInteractionSupported => base.IsLocalVoiceInteractionSupported;

        public override bool IsTaskRoot => base.IsTaskRoot;

        public override bool IsVoiceInteraction => base.IsVoiceInteraction;

        public override bool IsVoiceInteractionRoot => base.IsVoiceInteractionRoot;

        public override Java.Lang.Object LastNonConfigurationInstance => base.LastNonConfigurationInstance;

        public override LayoutInflater LayoutInflater => base.LayoutInflater;

        public override Android.App.LoaderManager LoaderManager => base.LoaderManager;

        public override string LocalClassName => base.LocalClassName;

        public override int MaxNumPictureInPictureActions => base.MaxNumPictureInPictureActions;

        public override MenuInflater MenuInflater => base.MenuInflater;

        public override Intent ParentActivityIntent => base.ParentActivityIntent;

        public override Android.Net.Uri Referrer => base.Referrer;

        public override ScreenOrientation RequestedOrientation { get => base.RequestedOrientation; set => base.RequestedOrientation = value; }

        public override int TaskId => base.TaskId;

        public override VoiceInteractor VoiceInteractor => base.VoiceInteractor;

        public override Window Window => base.Window;

        public override IWindowManager WindowManager => base.WindowManager;

        public override ViewModelProvider.IFactory DefaultViewModelProviderFactory => base.DefaultViewModelProviderFactory;

        public override Java.Lang.Object LastCustomNonConfigurationInstance => base.LastCustomNonConfigurationInstance;

        public override ViewModelStore ViewModelStore => base.ViewModelStore;

        public override Lifecycle Lifecycle => base.Lifecycle;

        public override AndroidX.Fragment.App.FragmentManager SupportFragmentManager => base.SupportFragmentManager;

        public override AndroidX.Loader.App.LoaderManager SupportLoaderManager => base.SupportLoaderManager;

        public override JniPeerMembers JniPeerMembers => base.JniPeerMembers;

        protected override IntPtr ThresholdClass => base.ThresholdClass;

        protected override Type ThresholdType => base.ThresholdType;

        public override AppCompatDelegate Delegate => base.Delegate;

        public override ActionBarDrawerToggle.IDelegate DrawerToggleDelegate => base.DrawerToggleDelegate;

        public override AndroidX.AppCompat.App.ActionBar SupportActionBar => base.SupportActionBar;

        public override Intent SupportParentActivityIntent => base.SupportParentActivityIntent;

        protected override bool AllowFragmentRestore => base.AllowFragmentRestore;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected override Java.Lang.Object Clone()
        {
            return base.Clone();
        }

        public override bool Equals(Java.Lang.Object obj)
        {
            return base.Equals(obj);
        }

        protected override void JavaFinalize()
        {
            base.JavaFinalize();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public override bool BindService(Intent service, [GeneratedEnum] Bind flags, IExecutor executor, IServiceConnection conn)
        {
            return base.BindService(service, flags, executor, conn);
        }

        public override bool BindServiceAsUser(Intent service, IServiceConnection conn, int flags, UserHandle user)
        {
            return base.BindServiceAsUser(service, conn, flags, user);
        }

        public override Context CreateAttributionContext(string attributionTag)
        {
            return base.CreateAttributionContext(attributionTag);
        }

        public override Context CreateWindowContext(int type, Bundle options)
        {
            return base.CreateWindowContext(type, options);
        }

        public override void RegisterComponentCallbacks(IComponentCallbacks callback)
        {
            base.RegisterComponentCallbacks(callback);
        }

        public override void SendBroadcastWithMultiplePermissions(Intent intent, string[] receiverPermissions)
        {
            base.SendBroadcastWithMultiplePermissions(intent, receiverPermissions);
        }

        public override void SendOrderedBroadcast(Intent intent, string receiverPermission, string receiverAppOp, BroadcastReceiver resultReceiver, Handler scheduler, [GeneratedEnum] Result initialCode, string initialData, Bundle initialExtras)
        {
            base.SendOrderedBroadcast(intent, receiverPermission, receiverAppOp, resultReceiver, scheduler, initialCode, initialData, initialExtras);
        }

        public override void UnregisterComponentCallbacks(IComponentCallbacks callback)
        {
            base.UnregisterComponentCallbacks(callback);
        }

        public override void UpdateServiceGroup(IServiceConnection conn, int group, int importance)
        {
            base.UpdateServiceGroup(conn, group, importance);
        }

        protected override void AttachBaseContext(Context @base)
        {
            base.AttachBaseContext(@base);
        }

        public override bool BindService(Intent service, IServiceConnection conn, [GeneratedEnum] Bind flags)
        {
            return base.BindService(service, conn, flags);
        }

        public override Permission CheckCallingOrSelfPermission(string permission)
        {
            return base.CheckCallingOrSelfPermission(permission);
        }

        public override Permission CheckCallingOrSelfUriPermission(Android.Net.Uri uri, [GeneratedEnum] ActivityFlags modeFlags)
        {
            return base.CheckCallingOrSelfUriPermission(uri, modeFlags);
        }

        public override Permission CheckCallingPermission(string permission)
        {
            return base.CheckCallingPermission(permission);
        }

        public override Permission CheckCallingUriPermission(Android.Net.Uri uri, [GeneratedEnum] ActivityFlags modeFlags)
        {
            return base.CheckCallingUriPermission(uri, modeFlags);
        }

        public override Permission CheckPermission(string permission, int pid, int uid)
        {
            return base.CheckPermission(permission, pid, uid);
        }

        [return: GeneratedEnum]
        public override Permission CheckSelfPermission(string permission)
        {
            return base.CheckSelfPermission(permission);
        }

        public override Permission CheckUriPermission(Android.Net.Uri uri, int pid, int uid, [GeneratedEnum] ActivityFlags modeFlags)
        {
            return base.CheckUriPermission(uri, pid, uid, modeFlags);
        }

        public override Permission CheckUriPermission(Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, [GeneratedEnum] ActivityFlags modeFlags)
        {
            return base.CheckUriPermission(uri, readPermission, writePermission, pid, uid, modeFlags);
        }

        public override void ClearWallpaper()
        {
            base.ClearWallpaper();
        }

        public override Context CreateConfigurationContext(Configuration overrideConfiguration)
        {
            return base.CreateConfigurationContext(overrideConfiguration);
        }

        public override Context CreateContextForSplit(string splitName)
        {
            return base.CreateContextForSplit(splitName);
        }

        public override Context CreateDeviceProtectedStorageContext()
        {
            return base.CreateDeviceProtectedStorageContext();
        }

        public override Context CreateDisplayContext(Display display)
        {
            return base.CreateDisplayContext(display);
        }

        public override Context CreatePackageContext(string packageName, [GeneratedEnum] PackageContextFlags flags)
        {
            return base.CreatePackageContext(packageName, flags);
        }

        public override string[] DatabaseList()
        {
            return base.DatabaseList();
        }

        public override bool DeleteDatabase(string name)
        {
            return base.DeleteDatabase(name);
        }

        public override bool DeleteFile(string name)
        {
            return base.DeleteFile(name);
        }

        public override bool DeleteSharedPreferences(string name)
        {
            return base.DeleteSharedPreferences(name);
        }

        public override void EnforceCallingOrSelfPermission(string permission, string message)
        {
            base.EnforceCallingOrSelfPermission(permission, message);
        }

        public override void EnforceCallingOrSelfUriPermission(Android.Net.Uri uri, [GeneratedEnum] ActivityFlags modeFlags, string message)
        {
            base.EnforceCallingOrSelfUriPermission(uri, modeFlags, message);
        }

        public override void EnforceCallingPermission(string permission, string message)
        {
            base.EnforceCallingPermission(permission, message);
        }

        public override void EnforceCallingUriPermission(Android.Net.Uri uri, [GeneratedEnum] ActivityFlags modeFlags, string message)
        {
            base.EnforceCallingUriPermission(uri, modeFlags, message);
        }

        public override void EnforcePermission(string permission, int pid, int uid, string message)
        {
            base.EnforcePermission(permission, pid, uid, message);
        }

        public override void EnforceUriPermission(Android.Net.Uri uri, int pid, int uid, [GeneratedEnum] ActivityFlags modeFlags, string message)
        {
            base.EnforceUriPermission(uri, pid, uid, modeFlags, message);
        }

        public override void EnforceUriPermission(Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, [GeneratedEnum] ActivityFlags modeFlags, string message)
        {
            base.EnforceUriPermission(uri, readPermission, writePermission, pid, uid, modeFlags, message);
        }

        public override string[] FileList()
        {
            return base.FileList();
        }

        public override Java.IO.File GetDatabasePath(string name)
        {
            return base.GetDatabasePath(name);
        }

        public override Java.IO.File GetDir(string name, [GeneratedEnum] FileCreationMode mode)
        {
            return base.GetDir(name, mode);
        }

        public override Java.IO.File[] GetExternalCacheDirs()
        {
            return base.GetExternalCacheDirs();
        }

        public override Java.IO.File GetExternalFilesDir(string type)
        {
            return base.GetExternalFilesDir(type);
        }

        public override Java.IO.File[] GetExternalFilesDirs(string type)
        {
            return base.GetExternalFilesDirs(type);
        }

        public override Java.IO.File[] GetExternalMediaDirs()
        {
            return base.GetExternalMediaDirs();
        }

        public override Java.IO.File GetFileStreamPath(string name)
        {
            return base.GetFileStreamPath(name);
        }

        public override Java.IO.File[] GetObbDirs()
        {
            return base.GetObbDirs();
        }

        public override ISharedPreferences GetSharedPreferences(string name, [GeneratedEnum] FileCreationMode mode)
        {
            return base.GetSharedPreferences(name, mode);
        }

        public override Java.Lang.Object GetSystemService(string name)
        {
            return base.GetSystemService(name);
        }

        public override string GetSystemServiceName(Class serviceClass)
        {
            return base.GetSystemServiceName(serviceClass);
        }

        public override void GrantUriPermission(string toPackage, Android.Net.Uri uri, [GeneratedEnum] ActivityFlags modeFlags)
        {
            base.GrantUriPermission(toPackage, uri, modeFlags);
        }

        public override bool MoveDatabaseFrom(Context sourceContext, string name)
        {
            return base.MoveDatabaseFrom(sourceContext, name);
        }

        public override bool MoveSharedPreferencesFrom(Context sourceContext, string name)
        {
            return base.MoveSharedPreferencesFrom(sourceContext, name);
        }

        public override Stream OpenFileInput(string name)
        {
            return base.OpenFileInput(name);
        }

        public override Stream OpenFileOutput(string name, [GeneratedEnum] FileCreationMode mode)
        {
            return base.OpenFileOutput(name, mode);
        }

        public override SQLiteDatabase OpenOrCreateDatabase(string name, [GeneratedEnum] FileCreationMode mode, SQLiteDatabase.ICursorFactory factory)
        {
            return base.OpenOrCreateDatabase(name, mode, factory);
        }

        public override SQLiteDatabase OpenOrCreateDatabase(string name, [GeneratedEnum] FileCreationMode mode, SQLiteDatabase.ICursorFactory factory, IDatabaseErrorHandler errorHandler)
        {
            return base.OpenOrCreateDatabase(name, mode, factory, errorHandler);
        }

        public override Drawable PeekWallpaper()
        {
            return base.PeekWallpaper();
        }

        public override Intent RegisterReceiver(BroadcastReceiver receiver, IntentFilter filter)
        {
            return base.RegisterReceiver(receiver, filter);
        }

        public override Intent RegisterReceiver(BroadcastReceiver receiver, IntentFilter filter, [GeneratedEnum] ActivityFlags flags)
        {
            return base.RegisterReceiver(receiver, filter, flags);
        }

        public override Intent RegisterReceiver(BroadcastReceiver receiver, IntentFilter filter, string broadcastPermission, Handler scheduler)
        {
            return base.RegisterReceiver(receiver, filter, broadcastPermission, scheduler);
        }

        public override Intent RegisterReceiver(BroadcastReceiver receiver, IntentFilter filter, string broadcastPermission, Handler scheduler, [GeneratedEnum] ActivityFlags flags)
        {
            return base.RegisterReceiver(receiver, filter, broadcastPermission, scheduler, flags);
        }

        public override void RemoveStickyBroadcast(Intent intent)
        {
            base.RemoveStickyBroadcast(intent);
        }

        public override void RemoveStickyBroadcastAsUser(Intent intent, UserHandle user)
        {
            base.RemoveStickyBroadcastAsUser(intent, user);
        }

        public override void RevokeUriPermission(Android.Net.Uri uri, [GeneratedEnum] ActivityFlags modeFlags)
        {
            base.RevokeUriPermission(uri, modeFlags);
        }

        public override void RevokeUriPermission(string targetPackage, Android.Net.Uri uri, [GeneratedEnum] ActivityFlags modeFlags)
        {
            base.RevokeUriPermission(targetPackage, uri, modeFlags);
        }

        public override void SendBroadcast(Intent intent)
        {
            base.SendBroadcast(intent);
        }

        public override void SendBroadcast(Intent intent, string receiverPermission)
        {
            base.SendBroadcast(intent, receiverPermission);
        }

        public override void SendBroadcastAsUser(Intent intent, UserHandle user)
        {
            base.SendBroadcastAsUser(intent, user);
        }

        public override void SendBroadcastAsUser(Intent intent, UserHandle user, string receiverPermission)
        {
            base.SendBroadcastAsUser(intent, user, receiverPermission);
        }

        public override void SendOrderedBroadcast(Intent intent, int initialCode, string receiverPermission, string receiverAppOp, BroadcastReceiver resultReceiver, Handler scheduler, string initialData, Bundle initialExtras, Bundle options)
        {
            base.SendOrderedBroadcast(intent, initialCode, receiverPermission, receiverAppOp, resultReceiver, scheduler, initialData, initialExtras, options);
        }

        public override void SendOrderedBroadcast(Intent intent, string receiverPermission)
        {
            base.SendOrderedBroadcast(intent, receiverPermission);
        }

        public override void SendOrderedBroadcast(Intent intent, string receiverPermission, BroadcastReceiver resultReceiver, Handler scheduler, [GeneratedEnum] Result initialCode, string initialData, Bundle initialExtras)
        {
            base.SendOrderedBroadcast(intent, receiverPermission, resultReceiver, scheduler, initialCode, initialData, initialExtras);
        }

        public override void SendOrderedBroadcastAsUser(Intent intent, UserHandle user, string receiverPermission, BroadcastReceiver resultReceiver, Handler scheduler, [GeneratedEnum] Result initialCode, string initialData, Bundle initialExtras)
        {
            base.SendOrderedBroadcastAsUser(intent, user, receiverPermission, resultReceiver, scheduler, initialCode, initialData, initialExtras);
        }

        public override void SendStickyBroadcast(Intent intent)
        {
            base.SendStickyBroadcast(intent);
        }

        public override void SendStickyBroadcastAsUser(Intent intent, UserHandle user)
        {
            base.SendStickyBroadcastAsUser(intent, user);
        }

        public override void SendStickyOrderedBroadcast(Intent intent, BroadcastReceiver resultReceiver, Handler scheduler, [GeneratedEnum] Result initialCode, string initialData, Bundle initialExtras)
        {
            base.SendStickyOrderedBroadcast(intent, resultReceiver, scheduler, initialCode, initialData, initialExtras);
        }

        public override void SendStickyOrderedBroadcastAsUser(Intent intent, UserHandle user, BroadcastReceiver resultReceiver, Handler scheduler, [GeneratedEnum] Result initialCode, string initialData, Bundle initialExtras)
        {
            base.SendStickyOrderedBroadcastAsUser(intent, user, resultReceiver, scheduler, initialCode, initialData, initialExtras);
        }

        public override void SetTheme(int resid)
        {
            base.SetTheme(resid);
        }

        public override void SetWallpaper(Bitmap bitmap)
        {
            base.SetWallpaper(bitmap);
        }

        public override void SetWallpaper(Stream data)
        {
            base.SetWallpaper(data);
        }

        public override void StartActivities(Intent[] intents)
        {
            base.StartActivities(intents);
        }

        public override void StartActivities(Intent[] intents, Bundle options)
        {
            base.StartActivities(intents, options);
        }

        public override void StartActivity(Intent intent)
        {
            base.StartActivity(intent);
        }

        public override void StartActivity(Intent intent, Bundle options)
        {
            base.StartActivity(intent, options);
        }

        public override ComponentName StartForegroundService(Intent service)
        {
            return base.StartForegroundService(service);
        }

        public override bool StartInstrumentation(ComponentName className, string profileFile, Bundle arguments)
        {
            return base.StartInstrumentation(className, profileFile, arguments);
        }

        public override void StartIntentSender(IntentSender intent, Intent fillInIntent, [GeneratedEnum] ActivityFlags flagsMask, [GeneratedEnum] ActivityFlags flagsValues, int extraFlags)
        {
            base.StartIntentSender(intent, fillInIntent, flagsMask, flagsValues, extraFlags);
        }

        public override void StartIntentSender(IntentSender intent, Intent fillInIntent, [GeneratedEnum] ActivityFlags flagsMask, [GeneratedEnum] ActivityFlags flagsValues, int extraFlags, Bundle options)
        {
            base.StartIntentSender(intent, fillInIntent, flagsMask, flagsValues, extraFlags, options);
        }

        public override ComponentName StartService(Intent service)
        {
            return base.StartService(service);
        }

        public override bool StopService(Intent name)
        {
            return base.StopService(name);
        }

        public override void UnbindService(IServiceConnection conn)
        {
            base.UnbindService(conn);
        }

        public override void UnregisterReceiver(BroadcastReceiver receiver)
        {
            base.UnregisterReceiver(receiver);
        }

        public override void ApplyOverrideConfiguration(Configuration overrideConfiguration)
        {
            base.ApplyOverrideConfiguration(overrideConfiguration);
        }

        protected override void OnApplyThemeResource(Resources.Theme theme, int resId, bool first)
        {
            base.OnApplyThemeResource(theme, resId, first);
        }

        public override void SetTheme(Resources.Theme theme)
        {
            base.SetTheme(theme);
        }

        public override void AddContentView(View view, ViewGroup.LayoutParams @params)
        {
            base.AddContentView(view, @params);
        }

        public override void CloseContextMenu()
        {
            base.CloseContextMenu();
        }

        public override void CloseOptionsMenu()
        {
            base.CloseOptionsMenu();
        }

        public override PendingIntent CreatePendingResult(int requestCode, Intent data, [GeneratedEnum] PendingIntentFlags flags)
        {
            return base.CreatePendingResult(requestCode, data, flags);
        }

        public override bool DispatchGenericMotionEvent(MotionEvent ev)
        {
            return base.DispatchGenericMotionEvent(ev);
        }

        public override bool DispatchKeyEvent(KeyEvent e)
        {
            return base.DispatchKeyEvent(e);
        }

        public override bool DispatchKeyShortcutEvent(KeyEvent e)
        {
            return base.DispatchKeyShortcutEvent(e);
        }

        public override bool DispatchPopulateAccessibilityEvent(AccessibilityEvent e)
        {
            return base.DispatchPopulateAccessibilityEvent(e);
        }

        public override bool DispatchTouchEvent(MotionEvent ev)
        {
            return base.DispatchTouchEvent(ev);
        }

        public override bool DispatchTrackballEvent(MotionEvent ev)
        {
            return base.DispatchTrackballEvent(ev);
        }

        public override void Dump(string prefix, FileDescriptor fd, PrintWriter writer, string[] args)
        {
            base.Dump(prefix, fd, writer, args);
        }

        public override void EnterPictureInPictureMode()
        {
            base.EnterPictureInPictureMode();
        }

        public override bool EnterPictureInPictureMode(PictureInPictureParams @params)
        {
            return base.EnterPictureInPictureMode(@params);
        }

        public override View FindViewById(int id)
        {
            return base.FindViewById(id);
        }

        public override void Finish()
        {
            base.Finish();
        }

        public override void FinishActivity(int requestCode)
        {
            base.FinishActivity(requestCode);
        }

        public override void FinishActivityFromChild(Activity child, int requestCode)
        {
            base.FinishActivityFromChild(child, requestCode);
        }

        public override void FinishAffinity()
        {
            base.FinishAffinity();
        }

        public override void FinishAfterTransition()
        {
            base.FinishAfterTransition();
        }

        public override void FinishAndRemoveTask()
        {
            base.FinishAndRemoveTask();
        }

        public override void FinishFromChild(Activity child)
        {
            base.FinishFromChild(child);
        }

        public override ISharedPreferences GetPreferences([GeneratedEnum] FileCreationMode mode)
        {
            return base.GetPreferences(mode);
        }

        public override void InvalidateOptionsMenu()
        {
            base.InvalidateOptionsMenu();
        }

        public override bool MoveTaskToBack(bool nonRoot)
        {
            return base.MoveTaskToBack(nonRoot);
        }

        public override bool NavigateUpTo(Intent upIntent)
        {
            return base.NavigateUpTo(upIntent);
        }

        public override bool NavigateUpToFromChild(Activity child, Intent upIntent)
        {
            return base.NavigateUpToFromChild(child, upIntent);
        }

        public override void OnActionModeFinished(Android.Views.ActionMode mode)
        {
            base.OnActionModeFinished(mode);
        }

        public override void OnActionModeStarted(Android.Views.ActionMode mode)
        {
            base.OnActionModeStarted(mode);
        }

        public override void OnActivityReenter(int resultCode, Intent data)
        {
            base.OnActivityReenter(resultCode, data);
        }

        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
        }

        public override void OnAttachFragment(Android.App.Fragment fragment)
        {
            base.OnAttachFragment(fragment);
        }

        protected override void OnChildTitleChanged(Activity childActivity, ICharSequence title)
        {
            base.OnChildTitleChanged(childActivity, title);
        }

        public override void OnContentChanged()
        {
            base.OnContentChanged();
        }

        public override bool OnContextItemSelected(IMenuItem item)
        {
            return base.OnContextItemSelected(item);
        }

        public override void OnContextMenuClosed(IMenu menu)
        {
            base.OnContextMenuClosed(menu);
        }

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        public override void OnCreateContextMenu(IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
        {
            base.OnCreateContextMenu(menu, v, menuInfo);
        }

        public override ICharSequence OnCreateDescriptionFormatted()
        {
            return base.OnCreateDescriptionFormatted();
        }

        protected override Dialog OnCreateDialog(int id)
        {
            return base.OnCreateDialog(id);
        }

        protected override Dialog OnCreateDialog(int id, Bundle args)
        {
            return base.OnCreateDialog(id, args);
        }

        public override void OnCreateNavigateUpTaskStack(Android.App.TaskStackBuilder builder)
        {
            base.OnCreateNavigateUpTaskStack(builder);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnCreatePanelMenu(int featureId, IMenu menu)
        {
            return base.OnCreatePanelMenu(featureId, menu);
        }

        public override View OnCreatePanelView(int featureId)
        {
            return base.OnCreatePanelView(featureId);
        }

        public override bool OnCreateThumbnail(Bitmap outBitmap, Canvas canvas)
        {
            return base.OnCreateThumbnail(outBitmap, canvas);
        }

        public override View OnCreateView(View parent, string name, Context context, IAttributeSet attrs)
        {
            return base.OnCreateView(parent, name, context, attrs);
        }

        public override View OnCreateView(string name, Context context, IAttributeSet attrs)
        {
            return base.OnCreateView(name, context, attrs);
        }

        public override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();
        }

        public override void OnEnterAnimationComplete()
        {
            base.OnEnterAnimationComplete();
        }

        public override bool OnGenericMotionEvent(MotionEvent e)
        {
            return base.OnGenericMotionEvent(e);
        }

        public override void OnGetDirectActions(CancellationSignal cancellationSignal, IConsumer callback)
        {
            base.OnGetDirectActions(cancellationSignal, callback);
        }

        public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            return base.OnKeyDown(keyCode, e);
        }

        public override bool OnKeyLongPress([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            return base.OnKeyLongPress(keyCode, e);
        }

        public override bool OnKeyMultiple([GeneratedEnum] Keycode keyCode, int repeatCount, KeyEvent e)
        {
            return base.OnKeyMultiple(keyCode, repeatCount, e);
        }

        public override bool OnKeyShortcut([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            return base.OnKeyShortcut(keyCode, e);
        }

        public override bool OnKeyUp([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            return base.OnKeyUp(keyCode, e);
        }

        public override void OnLocalVoiceInteractionStarted()
        {
            base.OnLocalVoiceInteractionStarted();
        }

        public override void OnLocalVoiceInteractionStopped()
        {
            base.OnLocalVoiceInteractionStopped();
        }

        public override void OnLowMemory()
        {
            base.OnLowMemory();
        }

        public override bool OnMenuOpened(int featureId, IMenu menu)
        {
            return base.OnMenuOpened(featureId, menu);
        }

        public override void OnMultiWindowModeChanged(bool isInMultiWindowMode)
        {
            base.OnMultiWindowModeChanged(isInMultiWindowMode);
        }

        public override void OnMultiWindowModeChanged(bool isInMultiWindowMode, Configuration newConfig)
        {
            base.OnMultiWindowModeChanged(isInMultiWindowMode, newConfig);
        }

        public override bool OnNavigateUp()
        {
            return base.OnNavigateUp();
        }

        public override bool OnNavigateUpFromChild(Activity child)
        {
            return base.OnNavigateUpFromChild(child);
        }

        public override void OnOptionsMenuClosed(IMenu menu)
        {
            base.OnOptionsMenuClosed(menu);
        }

        public override void OnPanelClosed(int featureId, IMenu menu)
        {
            base.OnPanelClosed(featureId, menu);
        }

        public override void OnPerformDirectAction(string actionId, Bundle arguments, CancellationSignal cancellationSignal, IConsumer resultListener)
        {
            base.OnPerformDirectAction(actionId, arguments, cancellationSignal, resultListener);
        }

        public override void OnPictureInPictureModeChanged(bool isInPictureInPictureMode)
        {
            base.OnPictureInPictureModeChanged(isInPictureInPictureMode);
        }

        public override void OnPictureInPictureModeChanged(bool isInPictureInPictureMode, Configuration newConfig)
        {
            base.OnPictureInPictureModeChanged(isInPictureInPictureMode, newConfig);
        }

        public override bool OnPictureInPictureRequested()
        {
            return base.OnPictureInPictureRequested();
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
        }

        public override void OnPostCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnPostCreate(savedInstanceState, persistentState);
        }

        protected override void OnPostResume()
        {
            base.OnPostResume();
        }

        protected override void OnPrepareDialog(int id, Dialog dialog)
        {
            base.OnPrepareDialog(id, dialog);
        }

        protected override void OnPrepareDialog(int id, Dialog dialog, Bundle args)
        {
            base.OnPrepareDialog(id, dialog, args);
        }

        public override void OnPrepareNavigateUpTaskStack(Android.App.TaskStackBuilder builder)
        {
            base.OnPrepareNavigateUpTaskStack(builder);
        }

        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            return base.OnPrepareOptionsMenu(menu);
        }

        public override bool OnPreparePanel(int featureId, View view, IMenu menu)
        {
            return base.OnPreparePanel(featureId, view, menu);
        }

        public override void OnProvideAssistContent(AssistContent outContent)
        {
            base.OnProvideAssistContent(outContent);
        }

        public override void OnProvideAssistData(Bundle data)
        {
            base.OnProvideAssistData(data);
        }

        public override void OnProvideKeyboardShortcuts(IList<KeyboardShortcutGroup> data, IMenu menu, int deviceId)
        {
            base.OnProvideKeyboardShortcuts(data, menu, deviceId);
        }

        public override Android.Net.Uri OnProvideReferrer()
        {
            return base.OnProvideReferrer();
        }

        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);
        }

        public override void OnRestoreInstanceState(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnRestoreInstanceState(savedInstanceState, persistentState);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
        }

        public override void OnSaveInstanceState(Bundle outState, PersistableBundle outPersistentState)
        {
            base.OnSaveInstanceState(outState, outPersistentState);
        }

        public override bool OnSearchRequested()
        {
            return base.OnSearchRequested();
        }

        public override bool OnSearchRequested(SearchEvent searchEvent)
        {
            return base.OnSearchRequested(searchEvent);
        }

        public override void OnStateNotSaved()
        {
            base.OnStateNotSaved();
        }

        protected override void OnTitleChanged(ICharSequence title, Color color)
        {
            base.OnTitleChanged(title, color);
        }

        public override void OnTopResumedActivityChanged(bool isTopResumedActivity)
        {
            base.OnTopResumedActivityChanged(isTopResumedActivity);
        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            return base.OnTouchEvent(e);
        }

        public override bool OnTrackballEvent(MotionEvent e)
        {
            return base.OnTrackballEvent(e);
        }

        public override void OnTrimMemory([GeneratedEnum] TrimMemory level)
        {
            base.OnTrimMemory(level);
        }

        public override void OnUserInteraction()
        {
            base.OnUserInteraction();
        }

        protected override void OnUserLeaveHint()
        {
            base.OnUserLeaveHint();
        }

        public override void OnVisibleBehindCanceled()
        {
            base.OnVisibleBehindCanceled();
        }

        public override void OnWindowAttributesChanged(WindowManagerLayoutParams @params)
        {
            base.OnWindowAttributesChanged(@params);
        }

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            base.OnWindowFocusChanged(hasFocus);
        }

        public override Android.Views.ActionMode OnWindowStartingActionMode(Android.Views.ActionMode.ICallback callback)
        {
            return base.OnWindowStartingActionMode(callback);
        }

        public override Android.Views.ActionMode OnWindowStartingActionMode(Android.Views.ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type)
        {
            return base.OnWindowStartingActionMode(callback, type);
        }

        public override void OpenContextMenu(View view)
        {
            base.OpenContextMenu(view);
        }

        public override void OpenOptionsMenu()
        {
            base.OpenOptionsMenu();
        }

        public override void OverridePendingTransition(int enterAnim, int exitAnim)
        {
            base.OverridePendingTransition(enterAnim, exitAnim);
        }

        public override void PostponeEnterTransition()
        {
            base.PostponeEnterTransition();
        }

        public override void Recreate()
        {
            base.Recreate();
        }

        public override void RegisterActivityLifecycleCallbacks(Application.IActivityLifecycleCallbacks callback)
        {
            base.RegisterActivityLifecycleCallbacks(callback);
        }

        public override void RegisterForContextMenu(View view)
        {
            base.RegisterForContextMenu(view);
        }

        public override bool ReleaseInstance()
        {
            return base.ReleaseInstance();
        }

        public override void ReportFullyDrawn()
        {
            base.ReportFullyDrawn();
        }

        public override DragAndDropPermissions RequestDragAndDropPermissions(DragEvent e)
        {
            return base.RequestDragAndDropPermissions(e);
        }

        public override bool RequestVisibleBehind(bool visible)
        {
            return base.RequestVisibleBehind(visible);
        }

        public override void SetActionBar(Android.Widget.Toolbar toolbar)
        {
            base.SetActionBar(toolbar);
        }

        public override void SetContentView(View view)
        {
            base.SetContentView(view);
        }

        public override void SetContentView(View view, ViewGroup.LayoutParams @params)
        {
            base.SetContentView(view, @params);
        }

        public override void SetContentView(int layoutResID)
        {
            base.SetContentView(layoutResID);
        }

        public override void SetEnterSharedElementCallback(Android.App.SharedElementCallback callback)
        {
            base.SetEnterSharedElementCallback(callback);
        }

        public override void SetExitSharedElementCallback(Android.App.SharedElementCallback callback)
        {
            base.SetExitSharedElementCallback(callback);
        }

        public override void SetFinishOnTouchOutside(bool finish)
        {
            base.SetFinishOnTouchOutside(finish);
        }

        public override void SetInheritShowWhenLocked(bool inheritShowWhenLocked)
        {
            base.SetInheritShowWhenLocked(inheritShowWhenLocked);
        }

        public override void SetLocusContext(LocusId locusId, Bundle bundle)
        {
            base.SetLocusContext(locusId, bundle);
        }

        public override void SetPersistent(bool isPersistent)
        {
            base.SetPersistent(isPersistent);
        }

        public override void SetPictureInPictureParams(PictureInPictureParams @params)
        {
            base.SetPictureInPictureParams(@params);
        }

        public override void SetShowWhenLocked(bool showWhenLocked)
        {
            base.SetShowWhenLocked(showWhenLocked);
        }

        public override void SetTaskDescription(ActivityManager.TaskDescription taskDescription)
        {
            base.SetTaskDescription(taskDescription);
        }

        public override void SetTitle(int titleId)
        {
            base.SetTitle(titleId);
        }

        public override bool SetTranslucent(bool translucent)
        {
            return base.SetTranslucent(translucent);
        }

        public override void SetTurnScreenOn(bool turnScreenOn)
        {
            base.SetTurnScreenOn(turnScreenOn);
        }

        public override void SetVisible(bool visible)
        {
            base.SetVisible(visible);
        }

        public override void SetVrModeEnabled(bool enabled, ComponentName requestedComponent)
        {
            base.SetVrModeEnabled(enabled, requestedComponent);
        }

        public override bool ShouldShowRequestPermissionRationale(string permission)
        {
            return base.ShouldShowRequestPermissionRationale(permission);
        }

        public override bool ShouldUpRecreateTask(Intent targetIntent)
        {
            return base.ShouldUpRecreateTask(targetIntent);
        }

        public override bool ShowAssist(Bundle args)
        {
            return base.ShowAssist(args);
        }

        public override void ShowLockTaskEscapeMessage()
        {
            base.ShowLockTaskEscapeMessage();
        }

        public override Android.Views.ActionMode StartActionMode(Android.Views.ActionMode.ICallback callback)
        {
            return base.StartActionMode(callback);
        }

        public override Android.Views.ActionMode StartActionMode(Android.Views.ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type)
        {
            return base.StartActionMode(callback, type);
        }

        public override void StartActivityForResult(Intent intent, int requestCode)
        {
            base.StartActivityForResult(intent, requestCode);
        }

        public override void StartActivityForResult(Intent intent, int requestCode, Bundle options)
        {
            base.StartActivityForResult(intent, requestCode, options);
        }

        public override void StartActivityFromChild(Activity child, Intent intent, int requestCode)
        {
            base.StartActivityFromChild(child, intent, requestCode);
        }

        public override void StartActivityFromChild(Activity child, Intent intent, int requestCode, Bundle options)
        {
            base.StartActivityFromChild(child, intent, requestCode, options);
        }

        public override void StartActivityFromFragment(Android.App.Fragment fragment, Intent intent, int requestCode)
        {
            base.StartActivityFromFragment(fragment, intent, requestCode);
        }

        public override void StartActivityFromFragment(Android.App.Fragment fragment, Intent intent, int requestCode, Bundle options)
        {
            base.StartActivityFromFragment(fragment, intent, requestCode, options);
        }

        public override bool StartActivityIfNeeded(Intent intent, int requestCode)
        {
            return base.StartActivityIfNeeded(intent, requestCode);
        }

        public override bool StartActivityIfNeeded(Intent intent, int requestCode, Bundle options)
        {
            return base.StartActivityIfNeeded(intent, requestCode, options);
        }

        public override void StartIntentSenderForResult(IntentSender intent, int requestCode, Intent fillInIntent, [GeneratedEnum] ActivityFlags flagsMask, [GeneratedEnum] ActivityFlags flagsValues, int extraFlags)
        {
            base.StartIntentSenderForResult(intent, requestCode, fillInIntent, flagsMask, flagsValues, extraFlags);
        }

        public override void StartIntentSenderForResult(IntentSender intent, int requestCode, Intent fillInIntent, [GeneratedEnum] ActivityFlags flagsMask, [GeneratedEnum] ActivityFlags flagsValues, int extraFlags, Bundle options)
        {
            base.StartIntentSenderForResult(intent, requestCode, fillInIntent, flagsMask, flagsValues, extraFlags, options);
        }

        public override void StartIntentSenderFromChild(Activity child, IntentSender intent, int requestCode, Intent fillInIntent, [GeneratedEnum] ActivityFlags flagsMask, [GeneratedEnum] ActivityFlags flagsValues, int extraFlags)
        {
            base.StartIntentSenderFromChild(child, intent, requestCode, fillInIntent, flagsMask, flagsValues, extraFlags);
        }

        public override void StartIntentSenderFromChild(Activity child, IntentSender intent, int requestCode, Intent fillInIntent, [GeneratedEnum] ActivityFlags flagsMask, [GeneratedEnum] ActivityFlags flagsValues, int extraFlags, Bundle options)
        {
            base.StartIntentSenderFromChild(child, intent, requestCode, fillInIntent, flagsMask, flagsValues, extraFlags, options);
        }

        public override void StartLocalVoiceInteraction(Bundle privateOptions)
        {
            base.StartLocalVoiceInteraction(privateOptions);
        }

        public override void StartLockTask()
        {
            base.StartLockTask();
        }

        public override void StartManagingCursor(ICursor c)
        {
            base.StartManagingCursor(c);
        }

        public override bool StartNextMatchingActivity(Intent intent)
        {
            return base.StartNextMatchingActivity(intent);
        }

        public override bool StartNextMatchingActivity(Intent intent, Bundle options)
        {
            return base.StartNextMatchingActivity(intent, options);
        }

        public override void StartPostponedEnterTransition()
        {
            base.StartPostponedEnterTransition();
        }

        public override void StartSearch(string initialQuery, bool selectInitialQuery, Bundle appSearchData, bool globalSearch)
        {
            base.StartSearch(initialQuery, selectInitialQuery, appSearchData, globalSearch);
        }

        public override void StopLocalVoiceInteraction()
        {
            base.StopLocalVoiceInteraction();
        }

        public override void StopLockTask()
        {
            base.StopLockTask();
        }

        public override void StopManagingCursor(ICursor c)
        {
            base.StopManagingCursor(c);
        }

        public override void TakeKeyEvents(bool get)
        {
            base.TakeKeyEvents(get);
        }

        public override void TriggerSearch(string query, Bundle appSearchData)
        {
            base.TriggerSearch(query, appSearchData);
        }

        public override void UnregisterActivityLifecycleCallbacks(Application.IActivityLifecycleCallbacks callback)
        {
            base.UnregisterActivityLifecycleCallbacks(callback);
        }

        public override void UnregisterForContextMenu(View view)
        {
            base.UnregisterForContextMenu(view);
        }

        public override Java.Lang.Object GetExtraData(Class extraDataClass)
        {
            return base.GetExtraData(extraDataClass);
        }

        public override void PutExtraData(ExtraData extraData)
        {
            base.PutExtraData(extraData);
        }

        public override bool SuperDispatchKeyEvent(KeyEvent e)
        {
            return base.SuperDispatchKeyEvent(e);
        }

        public override Java.Lang.Object OnRetainCustomNonConfigurationInstance()
        {
            return base.OnRetainCustomNonConfigurationInstance();
        }

        public override void OnAttachFragment(AndroidX.Fragment.App.Fragment fragment)
        {
            base.OnAttachFragment(fragment);
        }

        protected override bool OnPrepareOptionsPanel(View view, IMenu menu)
        {
            return base.OnPrepareOptionsPanel(view, menu);
        }

        protected override void OnResumeFragments()
        {
            base.OnResumeFragments();
        }

        public override void SetEnterSharedElementCallback(AndroidX.Core.App.SharedElementCallback callback)
        {
            base.SetEnterSharedElementCallback(callback);
        }

        public override void SetExitSharedElementCallback(AndroidX.Core.App.SharedElementCallback listener)
        {
            base.SetExitSharedElementCallback(listener);
        }

        public override void StartActivityFromFragment(AndroidX.Fragment.App.Fragment fragment, Intent intent, int requestCode)
        {
            base.StartActivityFromFragment(fragment, intent, requestCode);
        }

        public override void StartActivityFromFragment(AndroidX.Fragment.App.Fragment fragment, Intent intent, int requestCode, Bundle options)
        {
            base.StartActivityFromFragment(fragment, intent, requestCode, options);
        }

        public override void StartIntentSenderFromFragment(AndroidX.Fragment.App.Fragment fragment, IntentSender intent, int requestCode, Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, Bundle options)
        {
            base.StartIntentSenderFromFragment(fragment, intent, requestCode, fillInIntent, flagsMask, flagsValues, extraFlags, options);
        }

        public override void SupportFinishAfterTransition()
        {
            base.SupportFinishAfterTransition();
        }

        public override void SupportInvalidateOptionsMenu()
        {
            base.SupportInvalidateOptionsMenu();
        }

        public override void SupportPostponeEnterTransition()
        {
            base.SupportPostponeEnterTransition();
        }

        public override void SupportStartPostponedEnterTransition()
        {
            base.SupportStartPostponedEnterTransition();
        }

        public override void OnCreateSupportNavigateUpTaskStack(AndroidX.Core.App.TaskStackBuilder builder)
        {
            base.OnCreateSupportNavigateUpTaskStack(builder);
        }

        protected override void OnNightModeChanged(int mode)
        {
            base.OnNightModeChanged(mode);
        }

        public override void OnPrepareSupportNavigateUpTaskStack(AndroidX.Core.App.TaskStackBuilder builder)
        {
            base.OnPrepareSupportNavigateUpTaskStack(builder);
        }

        public override void OnSupportActionModeFinished(AndroidX.AppCompat.View.ActionMode mode)
        {
            base.OnSupportActionModeFinished(mode);
        }

        public override void OnSupportActionModeStarted(AndroidX.AppCompat.View.ActionMode mode)
        {
            base.OnSupportActionModeStarted(mode);
        }

        public override void OnSupportContentChanged()
        {
            base.OnSupportContentChanged();
        }

        public override bool OnSupportNavigateUp()
        {
            return base.OnSupportNavigateUp();
        }

        public override AndroidX.AppCompat.View.ActionMode OnWindowStartingSupportActionMode(AndroidX.AppCompat.View.ActionMode.ICallback callback)
        {
            return base.OnWindowStartingSupportActionMode(callback);
        }

        public override void SetSupportActionBar(AndroidX.AppCompat.Widget.Toolbar toolbar)
        {
            base.SetSupportActionBar(toolbar);
        }

        public override void SetSupportProgress(int progress)
        {
            base.SetSupportProgress(progress);
        }

        public override void SetSupportProgressBarIndeterminate(bool indeterminate)
        {
            base.SetSupportProgressBarIndeterminate(indeterminate);
        }

        public override void SetSupportProgressBarIndeterminateVisibility(bool visible)
        {
            base.SetSupportProgressBarIndeterminateVisibility(visible);
        }

        public override void SetSupportProgressBarVisibility(bool visible)
        {
            base.SetSupportProgressBarVisibility(visible);
        }

        public override AndroidX.AppCompat.View.ActionMode StartSupportActionMode(AndroidX.AppCompat.View.ActionMode.ICallback callback)
        {
            return base.StartSupportActionMode(callback);
        }

        public override void SupportNavigateUpTo(Intent upIntent)
        {
            base.SupportNavigateUpTo(upIntent);
        }

        public override bool SupportRequestWindowFeature(int featureId)
        {
            return base.SupportRequestWindowFeature(featureId);
        }

        public override bool SupportShouldUpRecreateTask(Intent targetIntent)
        {
            return base.SupportShouldUpRecreateTask(targetIntent);
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            return base.OnOptionsItemSelected(item);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
        }

        protected override void OnPause()
        {
            base.OnPause();
        }

        protected override void OnRestart()
        {
            base.OnRestart();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnStop()
        {
            base.OnStop();
        }
    }
}