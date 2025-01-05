using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using shortid;
using shortid.Configuration;

namespace Roughcut.Atlassian.Interfaces.Extensions
{
    public static class ArtifactExtensions //<T> where T : IArtifact
    {
        //public static string GetArtifactType<T>(this T artifact)
        //{
        //    return artifact.GetType().Name;
        //}

        public static List<PropertyInfo> GetProperties<T>() //this IArtifact artifact)
        {
            List<PropertyInfo> propList = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
                //.Select(p => p.Name)
                .ToList();


            //foreach (var prop in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            //{
            //    //columns.Add().DataField(prop.Name);

            //    //if (prop.Name == "ArtifactKeyId" || prop.Name == "ArtifactType")
            //    //{
            //    //    columns.Add().DataField(prop.Name).Visible(false);
            //    //}
            //}

            return propList;
        }

        public static string GetShortStringId(this IArtifact artifact)
        {
            // https://github.com/bolorundurowb/shortid
            var options = new GenerationOptions
            (
                useNumbers: true,
                length: 10
                , useSpecialCharacters: false
                //, useUppercase: true
            );

            // id = O_bBY-YUkJg
            string stringId = ShortId.Generate(options);

            //
            return stringId;
        }


        public static void WriteToDisk(this string stringContent, string fullFilePath)
        {
            try
            {
                File.WriteAllText(fullFilePath, stringContent);
            }
            catch (Exception exc)
            {
                //Console.WriteLine(exc);
                if (exc != null) throw exc;
            }
        }

    }
}
