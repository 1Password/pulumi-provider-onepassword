// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Onepassword
{
    /// <summary>
    /// A 1Password item.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Onepassword = Pulumi.Onepassword;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var demoPassword = new Onepassword.Item("demoPassword", new()
    ///     {
    ///         Vault = @var.Demo_vault,
    ///         Title = "Demo Password Recipe",
    ///         Category = "password",
    ///         PasswordRecipe = new Onepassword.Inputs.ItemPasswordRecipeArgs
    ///         {
    ///             Length = 40,
    ///             Symbols = false,
    ///         },
    ///         Sections = new[]
    ///         {
    ///             new Onepassword.Inputs.ItemSectionArgs
    ///             {
    ///                 Label = "Credential metadata",
    ///                 Fields = new[]
    ///                 {
    ///                     new Onepassword.Inputs.ItemSectionFieldArgs
    ///                     {
    ///                         Label = "Expiration",
    ///                         Type = "DATE",
    ///                         Value = "2024-01-31",
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    ///     var demoLogin = new Onepassword.Item("demoLogin", new()
    ///     {
    ///         Vault = @var.Demo_vault,
    ///         Title = "Demo Terraform Login",
    ///         Category = "login",
    ///         Username = "test@example.com",
    ///     });
    /// 
    ///     var demoDb = new Onepassword.Item("demoDb", new()
    ///     {
    ///         Vault = @var.Demo_vault,
    ///         Category = "database",
    ///         Type = "mysql",
    ///         Title = "Demo TF Database",
    ///         Username = "root",
    ///         Database = "Example MySQL Instance",
    ///         Hostname = "localhost",
    ///         Port = "3306",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// import an existing 1Password item
    /// 
    /// ```sh
    /// $ pulumi import onepassword:index/item:Item myitem vaults/&lt;vault uuid&gt;/items/&lt;item uuid&gt;
    /// ```
    /// </summary>
    [OnepasswordResourceType("onepassword:index/item:Item")]
    public partial class Item : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The category of the item. One of ["login" "password" "database"]
        /// </summary>
        [Output("category")]
        public Output<string?> Category { get; private set; } = null!;

        /// <summary>
        /// (Only applies to the database category) The name of the database.
        /// </summary>
        [Output("database")]
        public Output<string?> Database { get; private set; } = null!;

        /// <summary>
        /// (Only applies to the database category) The address where the database can be found
        /// </summary>
        [Output("hostname")]
        public Output<string?> Hostname { get; private set; } = null!;

        /// <summary>
        /// Password for this item.
        /// </summary>
        [Output("password")]
        public Output<string> Password { get; private set; } = null!;

        /// <summary>
        /// Password for this item.
        /// </summary>
        [Output("passwordRecipe")]
        public Output<Outputs.ItemPasswordRecipe?> PasswordRecipe { get; private set; } = null!;

        /// <summary>
        /// (Only applies to the database category) The port the database is listening on.
        /// </summary>
        [Output("port")]
        public Output<string?> Port { get; private set; } = null!;

        /// <summary>
        /// A list of custom sections in an item
        /// </summary>
        [Output("sections")]
        public Output<ImmutableArray<Outputs.ItemSection>> Sections { get; private set; } = null!;

        /// <summary>
        /// An array of strings of the tags assigned to the item.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// The title of the item.
        /// </summary>
        [Output("title")]
        public Output<string?> Title { get; private set; } = null!;

        /// <summary>
        /// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;

        /// <summary>
        /// The primary URL for the item.
        /// </summary>
        [Output("url")]
        public Output<string?> Url { get; private set; } = null!;

        /// <summary>
        /// Username for this item.
        /// </summary>
        [Output("username")]
        public Output<string?> Username { get; private set; } = null!;

        /// <summary>
        /// The UUID of the item. Item identifiers are unique within a specific vault.
        /// </summary>
        [Output("uuid")]
        public Output<string> Uuid { get; private set; } = null!;

        /// <summary>
        /// The UUID of the vault the item is in.
        /// </summary>
        [Output("vault")]
        public Output<string> Vault { get; private set; } = null!;


        /// <summary>
        /// Create a Item resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Item(string name, ItemArgs args, CustomResourceOptions? options = null)
            : base("onepassword:index/item:Item", name, args ?? new ItemArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Item(string name, Input<string> id, ItemState? state = null, CustomResourceOptions? options = null)
            : base("onepassword:index/item:Item", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/1Password/pulumi-onepassword",
                AdditionalSecretOutputs =
                {
                    "password",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Item resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Item Get(string name, Input<string> id, ItemState? state = null, CustomResourceOptions? options = null)
        {
            return new Item(name, id, state, options);
        }
    }

    public sealed class ItemArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The category of the item. One of ["login" "password" "database"]
        /// </summary>
        [Input("category")]
        public Input<string>? Category { get; set; }

        /// <summary>
        /// (Only applies to the database category) The name of the database.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// (Only applies to the database category) The address where the database can be found
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password for this item.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Password for this item.
        /// </summary>
        [Input("passwordRecipe")]
        public Input<Inputs.ItemPasswordRecipeArgs>? PasswordRecipe { get; set; }

        /// <summary>
        /// (Only applies to the database category) The port the database is listening on.
        /// </summary>
        [Input("port")]
        public Input<string>? Port { get; set; }

        [Input("sections")]
        private InputList<Inputs.ItemSectionArgs>? _sections;

        /// <summary>
        /// A list of custom sections in an item
        /// </summary>
        public InputList<Inputs.ItemSectionArgs> Sections
        {
            get => _sections ?? (_sections = new InputList<Inputs.ItemSectionArgs>());
            set => _sections = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// An array of strings of the tags assigned to the item.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The title of the item.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        /// <summary>
        /// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// The primary URL for the item.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        /// <summary>
        /// Username for this item.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        /// <summary>
        /// The UUID of the vault the item is in.
        /// </summary>
        [Input("vault", required: true)]
        public Input<string> Vault { get; set; } = null!;

        public ItemArgs()
        {
        }
        public static new ItemArgs Empty => new ItemArgs();
    }

    public sealed class ItemState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The category of the item. One of ["login" "password" "database"]
        /// </summary>
        [Input("category")]
        public Input<string>? Category { get; set; }

        /// <summary>
        /// (Only applies to the database category) The name of the database.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// (Only applies to the database category) The address where the database can be found
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password for this item.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Password for this item.
        /// </summary>
        [Input("passwordRecipe")]
        public Input<Inputs.ItemPasswordRecipeGetArgs>? PasswordRecipe { get; set; }

        /// <summary>
        /// (Only applies to the database category) The port the database is listening on.
        /// </summary>
        [Input("port")]
        public Input<string>? Port { get; set; }

        [Input("sections")]
        private InputList<Inputs.ItemSectionGetArgs>? _sections;

        /// <summary>
        /// A list of custom sections in an item
        /// </summary>
        public InputList<Inputs.ItemSectionGetArgs> Sections
        {
            get => _sections ?? (_sections = new InputList<Inputs.ItemSectionGetArgs>());
            set => _sections = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// An array of strings of the tags assigned to the item.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The title of the item.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        /// <summary>
        /// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// The primary URL for the item.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        /// <summary>
        /// Username for this item.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        /// <summary>
        /// The UUID of the item. Item identifiers are unique within a specific vault.
        /// </summary>
        [Input("uuid")]
        public Input<string>? Uuid { get; set; }

        /// <summary>
        /// The UUID of the vault the item is in.
        /// </summary>
        [Input("vault")]
        public Input<string>? Vault { get; set; }

        public ItemState()
        {
        }
        public static new ItemState Empty => new ItemState();
    }
}
