﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace WindowsBlogReader
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::WindowsBlogReader.App1_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.String fullName)
        {
            if(_provider == null)
            {
                _provider = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace WindowsBlogReader.App1_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            string standardName;
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                xamlType = GetXamlTypeByName(standardName);
            }
            else
            {
                xamlType = GetXamlTypeByName(type.FullName);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (global::System.String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (global::System.String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType> _xamlTypes = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();
        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember> _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();
        global::System.Collections.Generic.Dictionary<global::System.Type, string> _xamlTypeToStandardName = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();

        private void AddToMapOfTypeToStandardName(global::System.Type t, global::System.String str)
        {
            if(!_xamlTypeToStandardName.ContainsKey(t))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_0_FeedDataSource() { return new global::WindowsBlogReader.FeedDataSource(); }

        private object Activate_1_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::WindowsBlogReader.FeedData>(); }

        private object Activate_2_Collection() { return new global::System.Collections.ObjectModel.Collection<global::WindowsBlogReader.FeedData>(); }

        private object Activate_3_FeedData() { return new global::WindowsBlogReader.FeedData(); }

        private object Activate_6_List() { return new global::System.Collections.Generic.List<global::WindowsBlogReader.FeedItem>(); }

        private object Activate_7_FeedItem() { return new global::WindowsBlogReader.FeedItem(); }

        private object Activate_9_DateConverter() { return new global::WindowsBlogReader.DateConverter(); }

        private object Activate_10_MainPage() { return new global::WindowsBlogReader.MainPage(); }

        private void VectorAdd_1_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::WindowsBlogReader.FeedData>)instance;
            var newItem = (global::WindowsBlogReader.FeedData)item;
            collection.Add(newItem);
        }

        private void VectorAdd_2_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::WindowsBlogReader.FeedData>)instance;
            var newItem = (global::WindowsBlogReader.FeedData)item;
            collection.Add(newItem);
        }

        private void VectorAdd_6_List(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::WindowsBlogReader.FeedItem>)instance;
            var newItem = (global::WindowsBlogReader.FeedItem)item;
            collection.Add(newItem);
        }


        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(string typeName)
        {
            global::WindowsBlogReader.App1_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType userType;

            switch (typeName)
            {
            case "Object":
                xamlType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.Object));
                break;

            case "String":
                xamlType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.String));
                break;

            case "Windows.UI.Xaml.Controls.Page":
                xamlType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Page));
                break;

            case "Windows.UI.Xaml.Controls.UserControl":
                xamlType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.UserControl));
                break;

            case "WindowsBlogReader.FeedDataSource":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::WindowsBlogReader.FeedDataSource), GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_FeedDataSource;
                userType.AddMemberName("Feeds");
                AddToMapOfTypeToStandardName(typeof(global::System.Collections.ObjectModel.ObservableCollection<global::WindowsBlogReader.FeedData>),
                                                   "System.Collections.ObjectModel.ObservableCollection<WindowsBlogReader.FeedData>");
                xamlType = userType;
                break;

            case "System.Collections.ObjectModel.ObservableCollection<WindowsBlogReader.FeedData>":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.Collections.ObjectModel.ObservableCollection<global::WindowsBlogReader.FeedData>), GetXamlTypeByName("System.Collections.ObjectModel.Collection<WindowsBlogReader.FeedData>"));
                AddToMapOfTypeToStandardName(typeof(global::System.Collections.ObjectModel.ObservableCollection<global::WindowsBlogReader.FeedData>),
                                                   "System.Collections.ObjectModel.ObservableCollection<WindowsBlogReader.FeedData>");
                userType.Activator = Activate_1_ObservableCollection;
                userType.CollectionAdd = VectorAdd_1_ObservableCollection;
                xamlType = userType;
                break;

            case "System.Collections.ObjectModel.Collection<WindowsBlogReader.FeedData>":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.Collections.ObjectModel.Collection<global::WindowsBlogReader.FeedData>), GetXamlTypeByName("Object"));
                AddToMapOfTypeToStandardName(typeof(global::System.Collections.ObjectModel.Collection<global::WindowsBlogReader.FeedData>),
                                                   "System.Collections.ObjectModel.Collection<WindowsBlogReader.FeedData>");
                userType.Activator = Activate_2_Collection;
                userType.CollectionAdd = VectorAdd_2_Collection;
                xamlType = userType;
                break;

            case "WindowsBlogReader.FeedData":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::WindowsBlogReader.FeedData), GetXamlTypeByName("Object"));
                userType.Activator = Activate_3_FeedData;
                userType.AddMemberName("Title");
                AddToMapOfTypeToStandardName(typeof(global::System.String),
                                                   "String");
                userType.AddMemberName("Description");
                AddToMapOfTypeToStandardName(typeof(global::System.String),
                                                   "String");
                userType.AddMemberName("PubDate");
                userType.AddMemberName("Items");
                AddToMapOfTypeToStandardName(typeof(global::System.Collections.Generic.List<global::WindowsBlogReader.FeedItem>),
                                                   "System.Collections.Generic.List<WindowsBlogReader.FeedItem>");
                xamlType = userType;
                break;

            case "System.DateTime":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.DateTime), GetXamlTypeByName("System.ValueType"));
                xamlType = userType;
                break;

            case "System.ValueType":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.ValueType), GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case "System.Collections.Generic.List<WindowsBlogReader.FeedItem>":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.Collections.Generic.List<global::WindowsBlogReader.FeedItem>), GetXamlTypeByName("Object"));
                AddToMapOfTypeToStandardName(typeof(global::System.Collections.Generic.List<global::WindowsBlogReader.FeedItem>),
                                                   "System.Collections.Generic.List<WindowsBlogReader.FeedItem>");
                userType.Activator = Activate_6_List;
                userType.CollectionAdd = VectorAdd_6_List;
                xamlType = userType;
                break;

            case "WindowsBlogReader.FeedItem":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::WindowsBlogReader.FeedItem), GetXamlTypeByName("Object"));
                userType.Activator = Activate_7_FeedItem;
                userType.AddMemberName("Title");
                AddToMapOfTypeToStandardName(typeof(global::System.String),
                                                   "String");
                userType.AddMemberName("Author");
                AddToMapOfTypeToStandardName(typeof(global::System.String),
                                                   "String");
                userType.AddMemberName("Content");
                AddToMapOfTypeToStandardName(typeof(global::System.String),
                                                   "String");
                userType.AddMemberName("PubDate");
                userType.AddMemberName("Link");
                xamlType = userType;
                break;

            case "System.Uri":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.Uri), GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case "WindowsBlogReader.DateConverter":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::WindowsBlogReader.DateConverter), GetXamlTypeByName("Object"));
                userType.Activator = Activate_9_DateConverter;
                xamlType = userType;
                break;

            case "WindowsBlogReader.MainPage":
                userType = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::WindowsBlogReader.MainPage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_MainPage;
                xamlType = userType;
                break;

            }
            return xamlType;
        }


        private object get_0_FeedDataSource_Feeds(object instance)
        {
            var that = (global::WindowsBlogReader.FeedDataSource)instance;
            return that.Feeds;
        }
        private object get_1_FeedData_Title(object instance)
        {
            var that = (global::WindowsBlogReader.FeedData)instance;
            return that.Title;
        }
        private void set_1_FeedData_Title(object instance, object Value)
        {
            var that = (global::WindowsBlogReader.FeedData)instance;
            that.Title = (global::System.String)Value;
        }
        private object get_2_FeedData_Description(object instance)
        {
            var that = (global::WindowsBlogReader.FeedData)instance;
            return that.Description;
        }
        private void set_2_FeedData_Description(object instance, object Value)
        {
            var that = (global::WindowsBlogReader.FeedData)instance;
            that.Description = (global::System.String)Value;
        }
        private object get_3_FeedData_PubDate(object instance)
        {
            var that = (global::WindowsBlogReader.FeedData)instance;
            return that.PubDate;
        }
        private void set_3_FeedData_PubDate(object instance, object Value)
        {
            var that = (global::WindowsBlogReader.FeedData)instance;
            that.PubDate = (global::System.DateTime)Value;
        }
        private object get_4_FeedData_Items(object instance)
        {
            var that = (global::WindowsBlogReader.FeedData)instance;
            return that.Items;
        }
        private object get_5_FeedItem_Title(object instance)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            return that.Title;
        }
        private void set_5_FeedItem_Title(object instance, object Value)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            that.Title = (global::System.String)Value;
        }
        private object get_6_FeedItem_Author(object instance)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            return that.Author;
        }
        private void set_6_FeedItem_Author(object instance, object Value)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            that.Author = (global::System.String)Value;
        }
        private object get_7_FeedItem_Content(object instance)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            return that.Content;
        }
        private void set_7_FeedItem_Content(object instance, object Value)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            that.Content = (global::System.String)Value;
        }
        private object get_8_FeedItem_PubDate(object instance)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            return that.PubDate;
        }
        private void set_8_FeedItem_PubDate(object instance, object Value)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            that.PubDate = (global::System.DateTime)Value;
        }
        private object get_9_FeedItem_Link(object instance)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            return that.Link;
        }
        private void set_9_FeedItem_Link(object instance, object Value)
        {
            var that = (global::WindowsBlogReader.FeedItem)instance;
            that.Link = (global::System.Uri)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember xamlMember = null;
            global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "WindowsBlogReader.FeedDataSource.Feeds":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedDataSource");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "Feeds", "System.Collections.ObjectModel.ObservableCollection<WindowsBlogReader.FeedData>");
                xamlMember.Getter = get_0_FeedDataSource_Feeds;
                xamlMember.SetIsReadOnly();
                break;
            case "WindowsBlogReader.FeedData.Title":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedData");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "Title", "String");
                xamlMember.Getter = get_1_FeedData_Title;
                xamlMember.Setter = set_1_FeedData_Title;
                break;
            case "WindowsBlogReader.FeedData.Description":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedData");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "Description", "String");
                xamlMember.Getter = get_2_FeedData_Description;
                xamlMember.Setter = set_2_FeedData_Description;
                break;
            case "WindowsBlogReader.FeedData.PubDate":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedData");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "PubDate", "System.DateTime");
                xamlMember.Getter = get_3_FeedData_PubDate;
                xamlMember.Setter = set_3_FeedData_PubDate;
                break;
            case "WindowsBlogReader.FeedData.Items":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedData");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "Items", "System.Collections.Generic.List<WindowsBlogReader.FeedItem>");
                xamlMember.Getter = get_4_FeedData_Items;
                xamlMember.SetIsReadOnly();
                break;
            case "WindowsBlogReader.FeedItem.Title":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedItem");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "Title", "String");
                xamlMember.Getter = get_5_FeedItem_Title;
                xamlMember.Setter = set_5_FeedItem_Title;
                break;
            case "WindowsBlogReader.FeedItem.Author":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedItem");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "Author", "String");
                xamlMember.Getter = get_6_FeedItem_Author;
                xamlMember.Setter = set_6_FeedItem_Author;
                break;
            case "WindowsBlogReader.FeedItem.Content":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedItem");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "Content", "String");
                xamlMember.Getter = get_7_FeedItem_Content;
                xamlMember.Setter = set_7_FeedItem_Content;
                break;
            case "WindowsBlogReader.FeedItem.PubDate":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedItem");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "PubDate", "System.DateTime");
                xamlMember.Getter = get_8_FeedItem_PubDate;
                xamlMember.Setter = set_8_FeedItem_PubDate;
                break;
            case "WindowsBlogReader.FeedItem.Link":
                userType = (global::WindowsBlogReader.App1_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WindowsBlogReader.FeedItem");
                xamlMember = new global::WindowsBlogReader.App1_XamlTypeInfo.XamlMember(this, "Link", "System.Uri");
                xamlMember.Getter = get_9_FeedItem_Link;
                xamlMember.Setter = set_9_FeedItem_Link;
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(global::System.String input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::WindowsBlogReader.App1_XamlTypeInfo.XamlSystemBaseType
    {
        global::WindowsBlogReader.App1_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::WindowsBlogReader.App1_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public global::System.Object CreateFromString(global::System.String input)
        {
            if (_enumValues != null)
            {
                global::System.Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    global::System.Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( global::System.String.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::WindowsBlogReader.App1_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::WindowsBlogReader.App1_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(global::System.String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

