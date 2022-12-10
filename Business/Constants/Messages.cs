using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product Name is Invalid";
        public static string ProductDeleted = "Product Deleted";
        public static string ProductUpdated = "Product Updated";
        public static string ProductListed = "Products Listed";
        public static string ListedByCategoryID = "Listed By Category";
        public static string ListedByUnitPrice = "Listed By Price Range";
        public static string ProductDetailListed = "Product Detail Listed";
        public static string ListedById = "Listed By ID";
        public static string MaintenanceTime = "Out of Business Hours. Try later";

        public static string CategoryListed = "Category Listed";

        public static string AuthorizationDenied = "Authorization Denied";

        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successful Login";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
