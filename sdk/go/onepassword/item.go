// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package onepassword

import (
	"context"
	"reflect"

	"errors"
	"github.com/1Password/pulumi-onepassword/sdk/go/onepassword/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A 1Password item.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/1Password/pulumi-onepassword/sdk/go/onepassword"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := onepassword.NewItem(ctx, "demoPassword", &onepassword.ItemArgs{
//				Vault:    pulumi.Any(_var.Demo_vault),
//				Title:    pulumi.String("Demo Password Recipe"),
//				Category: pulumi.String("password"),
//				PasswordRecipe: &onepassword.ItemPasswordRecipeArgs{
//					Length:  pulumi.Int(40),
//					Symbols: pulumi.Bool(false),
//				},
//				Sections: onepassword.ItemSectionArray{
//					&onepassword.ItemSectionArgs{
//						Label: pulumi.String("Credential metadata"),
//						Fields: onepassword.ItemSectionFieldArray{
//							&onepassword.ItemSectionFieldArgs{
//								Label: pulumi.String("Expiration"),
//								Type:  pulumi.String("DATE"),
//								Value: pulumi.String("2024-01-31"),
//							},
//						},
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = onepassword.NewItem(ctx, "demoLogin", &onepassword.ItemArgs{
//				Vault:    pulumi.Any(_var.Demo_vault),
//				Title:    pulumi.String("Demo Terraform Login"),
//				Category: pulumi.String("login"),
//				Username: pulumi.String("test@example.com"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = onepassword.NewItem(ctx, "demoDb", &onepassword.ItemArgs{
//				Vault:    pulumi.Any(_var.Demo_vault),
//				Category: pulumi.String("database"),
//				Type:     pulumi.String("mysql"),
//				Title:    pulumi.String("Demo TF Database"),
//				Username: pulumi.String("root"),
//				Database: pulumi.String("Example MySQL Instance"),
//				Hostname: pulumi.String("localhost"),
//				Port:     pulumi.String("3306"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Import
//
// import an existing 1Password item
//
// ```sh
// $ pulumi import onepassword:index/item:Item myitem vaults/<vault uuid>/items/<item uuid>
// ```
type Item struct {
	pulumi.CustomResourceState

	// The category of the item. One of ["login" "password" "database"]
	Category pulumi.StringPtrOutput `pulumi:"category"`
	// (Only applies to the database category) The name of the database.
	Database pulumi.StringPtrOutput `pulumi:"database"`
	// (Only applies to the database category) The address where the database can be found
	Hostname pulumi.StringPtrOutput `pulumi:"hostname"`
	// Password for this item.
	Password pulumi.StringOutput `pulumi:"password"`
	// Password for this item.
	PasswordRecipe ItemPasswordRecipePtrOutput `pulumi:"passwordRecipe"`
	// (Only applies to the database category) The port the database is listening on.
	Port pulumi.StringPtrOutput `pulumi:"port"`
	// A list of custom sections in an item
	Sections ItemSectionArrayOutput `pulumi:"sections"`
	// An array of strings of the tags assigned to the item.
	Tags pulumi.StringArrayOutput `pulumi:"tags"`
	// The title of the item.
	Title pulumi.StringPtrOutput `pulumi:"title"`
	// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// The primary URL for the item.
	Url pulumi.StringPtrOutput `pulumi:"url"`
	// Username for this item.
	Username pulumi.StringPtrOutput `pulumi:"username"`
	// The UUID of the item. Item identifiers are unique within a specific vault.
	Uuid pulumi.StringOutput `pulumi:"uuid"`
	// The UUID of the vault the item is in.
	Vault pulumi.StringOutput `pulumi:"vault"`
}

// NewItem registers a new resource with the given unique name, arguments, and options.
func NewItem(ctx *pulumi.Context,
	name string, args *ItemArgs, opts ...pulumi.ResourceOption) (*Item, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Vault == nil {
		return nil, errors.New("invalid value for required argument 'Vault'")
	}
	if args.Password != nil {
		args.Password = pulumi.ToSecret(args.Password).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"password",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Item
	err := ctx.RegisterResource("onepassword:index/item:Item", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetItem gets an existing Item resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetItem(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ItemState, opts ...pulumi.ResourceOption) (*Item, error) {
	var resource Item
	err := ctx.ReadResource("onepassword:index/item:Item", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Item resources.
type itemState struct {
	// The category of the item. One of ["login" "password" "database"]
	Category *string `pulumi:"category"`
	// (Only applies to the database category) The name of the database.
	Database *string `pulumi:"database"`
	// (Only applies to the database category) The address where the database can be found
	Hostname *string `pulumi:"hostname"`
	// Password for this item.
	Password *string `pulumi:"password"`
	// Password for this item.
	PasswordRecipe *ItemPasswordRecipe `pulumi:"passwordRecipe"`
	// (Only applies to the database category) The port the database is listening on.
	Port *string `pulumi:"port"`
	// A list of custom sections in an item
	Sections []ItemSection `pulumi:"sections"`
	// An array of strings of the tags assigned to the item.
	Tags []string `pulumi:"tags"`
	// The title of the item.
	Title *string `pulumi:"title"`
	// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
	Type *string `pulumi:"type"`
	// The primary URL for the item.
	Url *string `pulumi:"url"`
	// Username for this item.
	Username *string `pulumi:"username"`
	// The UUID of the item. Item identifiers are unique within a specific vault.
	Uuid *string `pulumi:"uuid"`
	// The UUID of the vault the item is in.
	Vault *string `pulumi:"vault"`
}

type ItemState struct {
	// The category of the item. One of ["login" "password" "database"]
	Category pulumi.StringPtrInput
	// (Only applies to the database category) The name of the database.
	Database pulumi.StringPtrInput
	// (Only applies to the database category) The address where the database can be found
	Hostname pulumi.StringPtrInput
	// Password for this item.
	Password pulumi.StringPtrInput
	// Password for this item.
	PasswordRecipe ItemPasswordRecipePtrInput
	// (Only applies to the database category) The port the database is listening on.
	Port pulumi.StringPtrInput
	// A list of custom sections in an item
	Sections ItemSectionArrayInput
	// An array of strings of the tags assigned to the item.
	Tags pulumi.StringArrayInput
	// The title of the item.
	Title pulumi.StringPtrInput
	// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
	Type pulumi.StringPtrInput
	// The primary URL for the item.
	Url pulumi.StringPtrInput
	// Username for this item.
	Username pulumi.StringPtrInput
	// The UUID of the item. Item identifiers are unique within a specific vault.
	Uuid pulumi.StringPtrInput
	// The UUID of the vault the item is in.
	Vault pulumi.StringPtrInput
}

func (ItemState) ElementType() reflect.Type {
	return reflect.TypeOf((*itemState)(nil)).Elem()
}

type itemArgs struct {
	// The category of the item. One of ["login" "password" "database"]
	Category *string `pulumi:"category"`
	// (Only applies to the database category) The name of the database.
	Database *string `pulumi:"database"`
	// (Only applies to the database category) The address where the database can be found
	Hostname *string `pulumi:"hostname"`
	// Password for this item.
	Password *string `pulumi:"password"`
	// Password for this item.
	PasswordRecipe *ItemPasswordRecipe `pulumi:"passwordRecipe"`
	// (Only applies to the database category) The port the database is listening on.
	Port *string `pulumi:"port"`
	// A list of custom sections in an item
	Sections []ItemSection `pulumi:"sections"`
	// An array of strings of the tags assigned to the item.
	Tags []string `pulumi:"tags"`
	// The title of the item.
	Title *string `pulumi:"title"`
	// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
	Type *string `pulumi:"type"`
	// The primary URL for the item.
	Url *string `pulumi:"url"`
	// Username for this item.
	Username *string `pulumi:"username"`
	// The UUID of the vault the item is in.
	Vault string `pulumi:"vault"`
}

// The set of arguments for constructing a Item resource.
type ItemArgs struct {
	// The category of the item. One of ["login" "password" "database"]
	Category pulumi.StringPtrInput
	// (Only applies to the database category) The name of the database.
	Database pulumi.StringPtrInput
	// (Only applies to the database category) The address where the database can be found
	Hostname pulumi.StringPtrInput
	// Password for this item.
	Password pulumi.StringPtrInput
	// Password for this item.
	PasswordRecipe ItemPasswordRecipePtrInput
	// (Only applies to the database category) The port the database is listening on.
	Port pulumi.StringPtrInput
	// A list of custom sections in an item
	Sections ItemSectionArrayInput
	// An array of strings of the tags assigned to the item.
	Tags pulumi.StringArrayInput
	// The title of the item.
	Title pulumi.StringPtrInput
	// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
	Type pulumi.StringPtrInput
	// The primary URL for the item.
	Url pulumi.StringPtrInput
	// Username for this item.
	Username pulumi.StringPtrInput
	// The UUID of the vault the item is in.
	Vault pulumi.StringInput
}

func (ItemArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*itemArgs)(nil)).Elem()
}

type ItemInput interface {
	pulumi.Input

	ToItemOutput() ItemOutput
	ToItemOutputWithContext(ctx context.Context) ItemOutput
}

func (*Item) ElementType() reflect.Type {
	return reflect.TypeOf((**Item)(nil)).Elem()
}

func (i *Item) ToItemOutput() ItemOutput {
	return i.ToItemOutputWithContext(context.Background())
}

func (i *Item) ToItemOutputWithContext(ctx context.Context) ItemOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ItemOutput)
}

// ItemArrayInput is an input type that accepts ItemArray and ItemArrayOutput values.
// You can construct a concrete instance of `ItemArrayInput` via:
//
//	ItemArray{ ItemArgs{...} }
type ItemArrayInput interface {
	pulumi.Input

	ToItemArrayOutput() ItemArrayOutput
	ToItemArrayOutputWithContext(context.Context) ItemArrayOutput
}

type ItemArray []ItemInput

func (ItemArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Item)(nil)).Elem()
}

func (i ItemArray) ToItemArrayOutput() ItemArrayOutput {
	return i.ToItemArrayOutputWithContext(context.Background())
}

func (i ItemArray) ToItemArrayOutputWithContext(ctx context.Context) ItemArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ItemArrayOutput)
}

// ItemMapInput is an input type that accepts ItemMap and ItemMapOutput values.
// You can construct a concrete instance of `ItemMapInput` via:
//
//	ItemMap{ "key": ItemArgs{...} }
type ItemMapInput interface {
	pulumi.Input

	ToItemMapOutput() ItemMapOutput
	ToItemMapOutputWithContext(context.Context) ItemMapOutput
}

type ItemMap map[string]ItemInput

func (ItemMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Item)(nil)).Elem()
}

func (i ItemMap) ToItemMapOutput() ItemMapOutput {
	return i.ToItemMapOutputWithContext(context.Background())
}

func (i ItemMap) ToItemMapOutputWithContext(ctx context.Context) ItemMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ItemMapOutput)
}

type ItemOutput struct{ *pulumi.OutputState }

func (ItemOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Item)(nil)).Elem()
}

func (o ItemOutput) ToItemOutput() ItemOutput {
	return o
}

func (o ItemOutput) ToItemOutputWithContext(ctx context.Context) ItemOutput {
	return o
}

// The category of the item. One of ["login" "password" "database"]
func (o ItemOutput) Category() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Item) pulumi.StringPtrOutput { return v.Category }).(pulumi.StringPtrOutput)
}

// (Only applies to the database category) The name of the database.
func (o ItemOutput) Database() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Item) pulumi.StringPtrOutput { return v.Database }).(pulumi.StringPtrOutput)
}

// (Only applies to the database category) The address where the database can be found
func (o ItemOutput) Hostname() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Item) pulumi.StringPtrOutput { return v.Hostname }).(pulumi.StringPtrOutput)
}

// Password for this item.
func (o ItemOutput) Password() pulumi.StringOutput {
	return o.ApplyT(func(v *Item) pulumi.StringOutput { return v.Password }).(pulumi.StringOutput)
}

// Password for this item.
func (o ItemOutput) PasswordRecipe() ItemPasswordRecipePtrOutput {
	return o.ApplyT(func(v *Item) ItemPasswordRecipePtrOutput { return v.PasswordRecipe }).(ItemPasswordRecipePtrOutput)
}

// (Only applies to the database category) The port the database is listening on.
func (o ItemOutput) Port() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Item) pulumi.StringPtrOutput { return v.Port }).(pulumi.StringPtrOutput)
}

// A list of custom sections in an item
func (o ItemOutput) Sections() ItemSectionArrayOutput {
	return o.ApplyT(func(v *Item) ItemSectionArrayOutput { return v.Sections }).(ItemSectionArrayOutput)
}

// An array of strings of the tags assigned to the item.
func (o ItemOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Item) pulumi.StringArrayOutput { return v.Tags }).(pulumi.StringArrayOutput)
}

// The title of the item.
func (o ItemOutput) Title() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Item) pulumi.StringPtrOutput { return v.Title }).(pulumi.StringPtrOutput)
}

// (Only applies to the database category) The type of database. One of ["db2" "filemaker" "msaccess" "mssql" "mysql" "oracle" "postgresql" "sqlite" "other"]
func (o ItemOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Item) pulumi.StringPtrOutput { return v.Type }).(pulumi.StringPtrOutput)
}

// The primary URL for the item.
func (o ItemOutput) Url() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Item) pulumi.StringPtrOutput { return v.Url }).(pulumi.StringPtrOutput)
}

// Username for this item.
func (o ItemOutput) Username() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Item) pulumi.StringPtrOutput { return v.Username }).(pulumi.StringPtrOutput)
}

// The UUID of the item. Item identifiers are unique within a specific vault.
func (o ItemOutput) Uuid() pulumi.StringOutput {
	return o.ApplyT(func(v *Item) pulumi.StringOutput { return v.Uuid }).(pulumi.StringOutput)
}

// The UUID of the vault the item is in.
func (o ItemOutput) Vault() pulumi.StringOutput {
	return o.ApplyT(func(v *Item) pulumi.StringOutput { return v.Vault }).(pulumi.StringOutput)
}

type ItemArrayOutput struct{ *pulumi.OutputState }

func (ItemArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Item)(nil)).Elem()
}

func (o ItemArrayOutput) ToItemArrayOutput() ItemArrayOutput {
	return o
}

func (o ItemArrayOutput) ToItemArrayOutputWithContext(ctx context.Context) ItemArrayOutput {
	return o
}

func (o ItemArrayOutput) Index(i pulumi.IntInput) ItemOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Item {
		return vs[0].([]*Item)[vs[1].(int)]
	}).(ItemOutput)
}

type ItemMapOutput struct{ *pulumi.OutputState }

func (ItemMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Item)(nil)).Elem()
}

func (o ItemMapOutput) ToItemMapOutput() ItemMapOutput {
	return o
}

func (o ItemMapOutput) ToItemMapOutputWithContext(ctx context.Context) ItemMapOutput {
	return o
}

func (o ItemMapOutput) MapIndex(k pulumi.StringInput) ItemOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Item {
		return vs[0].(map[string]*Item)[vs[1].(string)]
	}).(ItemOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ItemInput)(nil)).Elem(), &Item{})
	pulumi.RegisterInputType(reflect.TypeOf((*ItemArrayInput)(nil)).Elem(), ItemArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ItemMapInput)(nil)).Elem(), ItemMap{})
	pulumi.RegisterOutputType(ItemOutput{})
	pulumi.RegisterOutputType(ItemArrayOutput{})
	pulumi.RegisterOutputType(ItemMapOutput{})
}
