using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
namespace Mod{
    public class Mod{
        public static void Main(){
            CategoryBuilder.Create("The QSMP Mod", "Adds characters and items from QSMP", ModAPI.LoadSprite("thumb.png"));

            //Brazillian Content Creators
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Cellbit",
                            NameToOrderByOverride = "E",
                            DescriptionOverride = "The new password is REGRET",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Cellbit-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Cellbit-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Felps",
                            NameToOrderByOverride = "E",
                            DescriptionOverride = "I always shined, Cellbit",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Felps-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Felps-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] President Forever",
                            NameToOrderByOverride = "E",
                            DescriptionOverride = "THIS IS THE PERFECT DAY",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/President-Forever-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/President-Forever-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Mike",
                            NameToOrderByOverride = "E",
                            DescriptionOverride = "Im not afraid of water Etoiles",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Mike-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Mike-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Pac",
                            NameToOrderByOverride = "E",
                            DescriptionOverride = "I dont want to be alone",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Pac-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Pac-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Bagi",
                            NameToOrderByOverride = "E",
                            DescriptionOverride = "I would love to go to a club",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Bagi-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Bagi-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("bagiHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/bagi.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            //English CCs
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Philza",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Get off her NOW",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Philza-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Philza-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                                var backpack = new GameObject("phWings");
                                backpack.transform.SetParent(Instance.transform.Find("Body").Find("UpperBody"));
                                backpack.transform.localPosition = new Vector3(0, 0f);
                                backpack.transform.localScale = new Vector3(1.2f, 1.2f);
                                var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                                backpackSprite.sprite = ModAPI.LoadSprite("Sprites/PhilzaWings.png");
                                backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                                var backpack2 = new GameObject("phHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/philza.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Tubbo",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Im a boy who yearns for eggs",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Tubbo-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Tubbo-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] BadBoyHalo",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Language",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/BadBoyHalo-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/BadBoyHalo-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] FitMC",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "The oldest anarchy server in Minecraft",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/FitMC-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/FitMC-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] DanTDM",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "I will never abandon you ever (he did)",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/DanTDM-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/DanTDM-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Quackity",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "I misclicked I misclicked",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Quackity-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Quackity-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Slimecicle",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Juanaflippa, you're my egg",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Slimecicle-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Slimecicle-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Foolish (KOC)",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "So we gotta kill Dapper",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Foolish-KOC-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Foolish-KOC-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Jaiden",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "No f*cking mames",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Jaiden-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Jaiden-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Wilbur Soot",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Tallulah, this is Quackity",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Wilbur-Soot-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Wilbur-Soot-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Niki Nihachu",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Tallullah I will protect you",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Niki-Nihachu-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Niki-Nihachu-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Tina Kitten",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Oh You got bubbles",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Tina-Kitten-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Tina-Kitten-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Lenay",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "I listen to French",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Lenay-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Lenay-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Iron Mouse",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Set it all on fire",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Iron-Mouse-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Iron-Mouse-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Foolish",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "I totem. But also. I shark",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Foolish.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Foolish.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Creation",
                            NameToOrderByOverride = "D",
                            DescriptionOverride = "Shells now (Tubbo's Creation)",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Creation.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Creation.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            //The Federation and other orgs
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Guard",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Carries a gun and a tazer",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Guard-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Guard-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;}

                                var backpack2 = new GameObject("guHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/guard.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Builder",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Whats the point of a janitor",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Builder-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Builder-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("buHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/builder.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Fred",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Tubbos Penpal",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Fred-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Fred-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 400f;
                                    limb.InitialHealth = 400f;
                                    limb.RegenerationSpeed += 150f;

                                }

                                var backpack2 = new GameObject("frHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/fred.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Cucurucho",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "What are you doing",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Cucurucho-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Cucurucho-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 500f;
                                    limb.InitialHealth = 500f;
                                    limb.RegenerationSpeed += 300f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Dark Cucurucho",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "HAHAHA",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Cucurevil-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Cucurevil-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 500f;
                                    limb.InitialHealth = 500f;
                                    limb.RegenerationSpeed += 300f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Ron",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Kidnapped by BadBoyHalo",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Ron-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Ron-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("roHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/builder.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Walter Bob",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "I might get punish",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Walter-Bob-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Walter-Bob-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Walter Bob Past",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Missing",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Walter-Bob-Past-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Walter-Bob-Past-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Android"),
                            NameOverride = "[QSMP] Code Monster",
                            NameToOrderByOverride = "C",
                            DescriptionOverride = "Binary Entity",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Code-Monster-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Code-Monster-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 500f;
                                    limb.InitialHealth = 500f;
                                    limb.RegenerationSpeed += 300f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Ron with Nightcap",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Given to him by BBH",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Ron-with-Nightcap-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Ron-with-Nightcap-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Head Guard",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Unconfirmed",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Head-Guard-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Head-Guard-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 400f;
                                    limb.InitialHealth = 400f;
                                    limb.RegenerationSpeed += 150f;

                                }

                                var backpack2 = new GameObject("hgHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/headguard.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Corrupted Builder",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "011000110110111101100100011001",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Corrupted-Builder-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Corrupted-Builder-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("cbHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/builder.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Contaminated Worker",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Corrupted with black material",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Contaminated-Worker-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Contaminated-Worker-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("cwHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/builder.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] The Watchers Worker",
                            NameToOrderByOverride = "B",
                            DescriptionOverride = "HAHAHA",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/The-Watchers-Worker-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/The-Watchers-Worker-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("wwHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/builder.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] The Watcher",
                            NameToOrderByOverride = "B",
                            DescriptionOverride = "I believe they called it Egg Island",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/The-Watcher-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/The-Watcher-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 500f;
                                    limb.InitialHealth = 500f;
                                    limb.RegenerationSpeed += 200f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Fred but dirty",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Kidnapped by Quackity",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Fred-but-dirty-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Fred-but-dirty-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 350f;
                                    limb.InitialHealth = 350f;
                                    limb.RegenerationSpeed += 150f;

                                }

                                var backpack2 = new GameObject("fdHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/fred.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Elena",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "My life is perfect...",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Elena.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/elena.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 400f;
                                    limb.InitialHealth = 400f;
                                    limb.RegenerationSpeed += 150f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Dark Worker",
                            NameToOrderByOverride = "C",
                            DescriptionOverride = "Works for Dark Cucurucho",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/darkworker.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/darkworker.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("dwHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/darkworker.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Eye worker with hasmat suit",
                            NameToOrderByOverride = "B",
                            DescriptionOverride = "Works for The Watcher and ElQuackity",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/hasmat.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/hasmat.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 250f;
                                    limb.InitialHealth = 250f;
                                    limb.RegenerationSpeed += 100f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Prison Guard",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Please follow me",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/PrisonGuard.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/PrisonGuard.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("pg1Hat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/prisonguard.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Agent 18",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "I want you to understand my morals",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/agent18.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/agent18.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("18Hat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/guard.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] @v@",
                            NameToOrderByOverride = "C",
                            DescriptionOverride = "Who's Forever?",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/@v@.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/@v@.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Prison Guard 2",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Where would you like your eggs to go when you die?",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/PrisonGuard2.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/PrisonGuard2.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("pg2Hat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/prisonguard2.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Cider",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "…apple juice is what keeps me going…",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Cider.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Cider.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("ciderHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/cider.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Cider (Bruised)",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "You don’t have that same energy you had when I first met you, there’s something obviously bothering you!!",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/CiderBruised.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/CiderBruised.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 150f;
                                    limb.InitialHealth = 150f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("ciderbHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/cider.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Forgotten Ghost",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "Killed by Abueloier",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/ForgottenGhost.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/ForgottenGhost.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Lapin",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Please follow me",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/BlackBunny_Blue.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/BlackBunny_Blue.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("bunnyBHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/BlackBunny_Head.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Donny",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Please follow me",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/BlackBunny_Red.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/BlackBunny_Red.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("bunnyRHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/BlackBunny_Head.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Pipi",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Please follow me",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/BlackBunny_Yellow.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/BlackBunny_Yellow.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("bunnyYHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/BlackBunny_Head.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Bobinho",
                            NameToOrderByOverride = "A",
                            DescriptionOverride = "Please follow me",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/BlackBunny_Green.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/BlackBunny_Green.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("bunnyGHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/BlackBunny_Head.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            //French CCs
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Antoine Daniel",
                            NameToOrderByOverride = "F",
                            DescriptionOverride = "We will guillotine the codes",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Antoine-Daniel-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Antoine-Daniel-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Aypierre",
                            NameToOrderByOverride = "F",
                            DescriptionOverride = "I know a method",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Aypierre-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Aypierre-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Baghera",
                            NameToOrderByOverride = "F",
                            DescriptionOverride = "Pomme go in the fire",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Baghera-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Baghera-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Etoiles",
                            NameToOrderByOverride = "F",
                            DescriptionOverride = "GGs good fight nice try",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Etoiles-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Etoiles-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 500f;
                                    limb.InitialHealth = 500f;
                                    limb.RegenerationSpeed += 200f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Kameto",
                            NameToOrderByOverride = "F",
                            DescriptionOverride = "Lets trade Richarlyson for Bobby",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Kameto-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Kameto-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            //QSMP Prison
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Antoine (Prison)",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "Hello, child. Do you remember dying?",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Antoine.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Antoine.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Aypierre (Prison)",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "No Badboy, don’t let me babysit Tubbo alone!",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Aypierre.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Aypierre.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Bagi (Prison)",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "Quackity says I would die in a hospital someday",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Bagi.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Bagi.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("bagiPHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/QSMP_Prison_Bagi.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] BadBoyHalo (Prison)",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "Aw.. Pepito, you know i can't hit a child.. Eh, i guess I can.",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_BBH.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_BBH.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Etoiles (Prison)",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "Sometimes I wake up, and feel like I’m a legend",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Etoiles.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Etoiles.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] FitMC (Prison)",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "SNEEG SHUT UP I'M DOING GAY ROLEPLAY RIGHT NOW!",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Fit.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Fit.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Foolish (Prison)",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "Lying is fun!",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Foolish.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Foolish.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Missa (Prison)",
                            NameToOrderByOverride = "I",
                            DescriptionOverride = "They shouldn't show me that because now I want to blow everything",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Missa.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Missa.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

             ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Nihachu (Prison)",
                             NameToOrderByOverride = "I",
                            DescriptionOverride = "I think if it makes you happy, you should do it",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Nihachu.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Nihachu.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

             ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Philza (Prison)",
                             NameToOrderByOverride = "I",
                            DescriptionOverride = "That wasn't feedback, that was a threat. Don't lay a fucking finger on his head.",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Philza.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Philza.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("philzaPHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/QSMP_Prison_Philza.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});

             ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Quackity (Prison)",
                             NameToOrderByOverride = "I",
                            DescriptionOverride = "The salary I'm going to pay you is my friendship, that's all you need.",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Quackity.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Quackity.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

             ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] TinaKitten (Prison)",
                             NameToOrderByOverride = "I",
                            DescriptionOverride = "Listen, Mom has had 50 drinks.",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Tina.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Tina.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

             ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Tubbo (Prison)",
                             NameToOrderByOverride = "I",
                            DescriptionOverride = "Soo... how about we... set your spawn in my house tonight?",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/QSMP_Prison_Tubbo.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/QSMP_Prison_Tubbo.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            //Weapons and Items
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Sword"),
                            NameOverride = "[QSMP] IMMORTAL",
                            NameToOrderByOverride = "K",
                            DescriptionOverride = "Used by the Code and Etoiles",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/IMMORTAL-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/IMMORTAL.png");
                                Instance.FixColliders();

                            }

            });

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] King Crown", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "Won at Lucky Ducks", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/King_Crown.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/King_Crown.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/King_Crown.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                }
            );

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Queen Crown", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "Won at Lucky Ducks", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Queen_Crown.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Queen_Crown.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/Queen_Crown.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                }
            );


            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Balaclava", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "Passa Tudo", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Balaclava.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Balaclava.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/Balaclava.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                }
            );

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Knife"),
                            NameOverride = "[QSMP] Rubro Knife",
                            NameToOrderByOverride = "K",
                            DescriptionOverride = "ATTACK THEM ALL",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/RubroKnife.png"),
                            AfterSpawn = (Instance) =>{
                                Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/RubroKnife.png");
                                Instance.FixColliders();

                            }});

            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Gas Mask", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "BOLAS BOLAS BOLAS", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/bolas.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/bolas.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/bolas.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                }
            );

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Red Gas Mask", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "Given by Cellbit as a symbol of loyalty to Bolas in Purgatory 2", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/redbolas.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/redbolas.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/redbolas.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Blue Gas Mask", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "Given by Cellbit as a symbol of loyalty to Bolas in Purgatory 2", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/bluebolas.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/bluebolas.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/bluebolas.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Green Gas Mask", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "Given by Cellbit as a symbol of loyalty to Bolas in Purgatory 2", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/greenbolas.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/greenbolas.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/greenbolas.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Sword"),
                            NameOverride = "[QSMP] Nightmare Scythe",
                            NameToOrderByOverride = "K",
                            DescriptionOverride = "A powerful weapon, used by lots of the islanders",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Nightmarescythe.png"),
                            AfterSpawn = (Instance) =>{
                                Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Nightmarescythe.png");
                                Instance.FixColliders();

                            }});

                ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Sword"),
                            NameOverride = "[QSMP] Soul Sabre",
                            NameToOrderByOverride = "K",
                            DescriptionOverride = "A powerful weapon, used by many people",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Soulsaber.png"),
                            AfterSpawn = (Instance) =>{
                                Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Soulsaber.png");
                                Instance.FixColliders();

                            }});

                ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Baseball Bat"),
                            NameOverride = "[QSMP] Frying Pan",
                            NameToOrderByOverride = "K",
                            DescriptionOverride = "You can whack people with it",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/FryingPan.png"),
                            AfterSpawn = (Instance) =>{
                                Instance.GetComponent<PhysicalBehaviour>().InitialMass = 1f;
                                Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 1f;
                                Instance.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Metal");
                                Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/FryingPan.png");
                                Instance.FixColliders();

                            }});

                ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Metal Cube"),
                            NameOverride = "[QSMP] Cucurucho Radio",
                            NameToOrderByOverride = "K",
                            DescriptionOverride = "What's this?",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/CucuruchoRadio.png"),
                            AfterSpawn = (Instance) =>{
                                Instance.GetComponent<PhysicalBehaviour>().InitialMass = 2f;
                                Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 2f;
                                Instance.GetComponent<PhysicalBehaviour>().Properties = ModAPI.FindPhysicalProperties("Plastic");
                                Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/CucuruchoRadio.png");
                                Instance.FixColliders();
                                AudioSource spawnSound = Instance.AddComponent<AudioSource>();
                                spawnSound.minDistance = 1;
                                spawnSound.maxDistance = 15;
                                spawnSound.loop = false;
                                AudioClip[] data = new AudioClip[]{ModAPI.LoadSound("Sounds/juanaflippa.mp3")};
                                spawnSound.clip = data[0];
                                var cucMusicPlaying = false;
                                Instance.AddComponent<UseEventTrigger>().Action = () => {
                                    if(cucMusicPlaying == false) {
                                        spawnSound.Play();
                                        cucMusicPlaying = true;
                                    }
                                    else {
                                        spawnSound.Stop();
                                        cucMusicPlaying = false;
                                    }
                                };


                            }});

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Sombrero", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "A simple Mexican sombrero", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Sombrero.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Sombrero.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/Sombrero.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Straw Hat", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "A simple straw hat", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/StrawHat.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/StrawHat.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/StrawHat.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Froststalker Helmet", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "A simple froststalker helmet", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/FroststalkerHelmet.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/FroststalkerHelmet.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/FroststalkerHelmet.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Novelty Hat", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "A simple novelty hat", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/NoveltyHat.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/NoveltyHat.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/NoveltyHat.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Cyan Leather Cap", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "A simple cyan leather cap", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/CyanLeatherCap.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/CyanLeatherCap.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/CyanLeatherCap.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Face Mask", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "Protects from weak fumes", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/FaceMask.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/FaceMask.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/FaceMask.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Diving Helmet", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "A simple diving helmet", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/DivingHelmet.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/DivingHelmet.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/DivingHelmet.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Rod"), //item to derive from
                    NameOverride = "[QSMP] Goggles", //new item name with a suffix to assure it is globally unique
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "A simple pair of goggles", //new item description
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Goggles.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Goggles.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 0.1f;
                        Instance.GetComponent<PhysicalBehaviour>().rigidbody.mass = 0.1f;
                        int PartCount = 3;

                        Instance.AddComponent<ArmorBehaviour>();

                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();

                        prop.armorPiece = "Head";
                        prop.armorTier = 2;
                        prop.sprite = "Sprites/Goggles.png";

                        armor.prop = prop;
                        armor.SetProperties();
                    }
                });

                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Chainsaw"),
                    NameOverride = "[QSMP] Chainsaw",
                    NameToOrderByOverride = "K",
                    DescriptionOverride = "This chainsaw is mainly used by Cucurucho",
                    CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/chainsaw.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/chainsaw.png");
                        Instance.GetComponent<PhysicalBehaviour>().InitialMass = 1.15f;
                        Instance.GetComponent<PhysicalBehaviour>().TrueInitialMass = 1.15f;
                        Instance.FixColliders();

        }
    }
);
                ModAPI.Register(new Modification(){
                    OriginalItem = ModAPI.FindSpawnable("Pistol"),
                                NameOverride = "[QSMP] Glock",
                                NameToOrderByOverride = "K",
                                DescriptionOverride = "Used by Federation guards",
                                CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                                ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Glock.png"),
                                AfterSpawn = (Instance) =>{
                                    ModAPI.KeepExtraObjects();
                                    var QGlockSlide = Instance.transform.Find("Slide");
                                    QGlockSlide.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/GlockSlide.png");

                                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/Glock.png");
                                    var firearm = Instance.GetComponent<FirearmBehaviour>();
                                    Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                                    customCartridge.name = "[QSMP] Glock Cartridge";
                                    customCartridge.Damage *= 1f;
                                    customCartridge.StartSpeed *= 1.5f;
                                    customCartridge.PenetrationRandomAngleMultiplier *= 0.5f;
                                    customCartridge.Recoil *= 0.7f;
                                    customCartridge.ImpactForce *= 1f;
                                    firearm.Cartridge = customCartridge;

                                }});

                //Hispanic CCs
                ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] El Mariana",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "No sexo with the new people",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/El-Mariana-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/El-Mariana-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] El Quackity",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "BUENA SUERTE",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/El-Quackity-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/El-Quackity-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Luzu",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "I just found out I was a dad",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Luzu-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Luzu-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "[QSMP] Maximus",
                NameToOrderByOverride = "G",
                DescriptionOverride = "Quackity didnt pay the server",
                CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Maximus-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Maximus-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }

                                var backpack2 = new GameObject("mxHat");
                                backpack2.transform.SetParent(Instance.transform.Find("Head"));
                                backpack2.transform.localPosition = new Vector3(0, 0f);
                                backpack2.transform.localScale = new Vector3(1f, 1f);
                                var backpackSprite2 = backpack2.AddComponent<SpriteRenderer>();
                                backpackSprite2.sprite = ModAPI.LoadSprite("HatLayers/maximus.png");
                                backpack2.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";
                            }});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Missa",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "We raised a warrior",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Missa-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Missa-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Roier",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "Kiss me mien",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Roier-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Roier-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Spreen",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "Dead",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Spreen-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Spreen-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Vegetta",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "Yes its my six pack",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Vegetta-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Vegetta-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Carre",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "Ill kill you with my chainsaw",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Carre-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Carre-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] German",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "Mr YouTube Rewind",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/German-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/German-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Polispol",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "Im an old man",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Polispol-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Polispol-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Rivers",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "Did you have the wedding",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Rivers-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Rivers-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Willyrex",
                            NameToOrderByOverride = "G",
                            DescriptionOverride = "The lore of laying mines",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Willyrex-thumb.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Willyrex-skin.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            //Korean CCs
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Acau",
                            NameToOrderByOverride = "H",
                            DescriptionOverride = "Pizza Minecraft",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Acau.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Acau.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] KongKong",
                            NameToOrderByOverride = "H",
                            DescriptionOverride = "QSMP Wiki has no quotes how am I supposed to write a description???",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/KongKong.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/KongKong.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] YD",
                            NameToOrderByOverride = "H",
                            DescriptionOverride = "I think he is crazy, you better run away...",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/YD.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/YD.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Jungryeok",
                            NameToOrderByOverride = "H",
                            DescriptionOverride = "Whoa, it's a perfect house! By any chance, did you build it in 5 minutes?",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Jungryeok.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Jungryeok.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            //German Content Creators
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Let's Hugo",
                            NameToOrderByOverride = "N",
                            DescriptionOverride = "Ich bin geil",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/LetsHugo.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LetsHugo.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            //Little Buddies
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Barriguinha Mole",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by Baghera",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/BarriguinhaMole.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LittleBuddiesBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("bmHat");
                            backpack.transform.SetParent(Instance.transform.Find("Head"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Sombrero.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Top";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Luffy",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by FitMC",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Luffy.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LittleBuddiesBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("luHat");
                            backpack.transform.SetParent(Instance.transform.Find("Head"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/StrawHat.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Top";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Bertie",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by Tubbo",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Bertie.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LittleBuddiesBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Bolitas Peludas",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by Baghera and Roier",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/BolitasPeludas.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LittleBuddiesBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("bpHat");
                            backpack.transform.SetParent(Instance.transform.Find("Head"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/FroststalkerHelmet.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Top";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Caramel",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by Tubbo",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Caramel.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LittleBuddiesBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("caHat");
                            backpack.transform.SetParent(Instance.transform.Find("Head"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/NoveltyHat.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Top";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Coco",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by Badboyhalo",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Coco.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LittleBuddiesBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("coHat");
                            backpack.transform.SetParent(Instance.transform.Find("Head"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/CyanLeatherCap.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Top";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Rupert",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by Tubbo",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Rupert.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LittleBuddiesBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("ruHat");
                            backpack.transform.SetParent(Instance.transform.Find("Head"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/FaceMask.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Top";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Scoob",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by Tubbo",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Scoob.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/LittleBuddiesBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("scHat");
                            backpack.transform.SetParent(Instance.transform.Find("Head"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/DivingHelmet.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Top";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Trousers",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Named by Badboyhalo and Pac",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Trousers.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Trousers.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("trHat");
                            backpack.transform.SetParent(Instance.transform.Find("Head"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Goggles.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Top";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Dark Buddy",
                            NameToOrderByOverride = "L",
                            DescriptionOverride = "Controlled by The Watcher",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/DarkBuddie.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/DarkBuddie.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                };

                            }});

            //The eggs
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Bobby",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "BEST FAMILY LOVE Y'ALL",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Bobby.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("boEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Bobby.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Chayanne",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "I'll cook I WILL COOK 100% I'LL COOK",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Chayanne.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("chEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Chayanne.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Egg A1",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "ElQuackity discovered this mysterious egg",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/EggA1.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("a1Egg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/EggA1.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Dapper",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "I kinda want to stay to anno- make company to Foolish",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Dapper.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("daEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Dapper.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Gegg",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "Definitely not Charlie Slimecicle",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/gegg.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("gEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/gegg.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] JuanaFlippa",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "Love my parents, thanks for all",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/JuanaFlippa.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("jfEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/JuanaFlippa.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Leonarda",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "Trump is my best friend",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Leonarda.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("leEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Leonarda.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Ramón",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "All things come with time, some good or bad",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Ramón.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("raEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Ramón.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Richarlyson",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "I'M AN >EGG< I DON'T HAVE AN ASS",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Richarlyson.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/RicharlysonBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("riEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Richarlyson.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Tallulah",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "If I'm gone, find me in the amapolas",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Tallulah.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("taEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Tallulah.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Tilín",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "I understand his pain, he wants love",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Tilín.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("tiEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Tilín.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Trump",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "I love you dad, take care of yourself and my cousins too <3",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Trump.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("trEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Trump.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] SunnySideUp",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "No, friendship is giving me money",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Sunny.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("suEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Sunny.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Pepito",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "No pronouns don’t talk to me or about me",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Pepito.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("peEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Pepito.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Empanada",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "I shot myself with it :D",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Empanada.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("emEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Empanada.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Pomme",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "Yeah but my dad is unkillable :'D",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Pomme.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("poEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Pomme.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Chunsik",
                            NameToOrderByOverride = "M",
                            DescriptionOverride = "Wiki admins please add quotes lmao",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Chunsik.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/EggBase.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                person.transform.localScale = new Vector3(0.75f, 0.75f);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 300f;
                                    limb.InitialHealth = 300f;
                                    limb.RegenerationSpeed += 50f;

                                };
                            var backpack = new GameObject("chunsikEgg");
                            backpack.transform.SetParent(Instance.transform.Find("Body").Find("MiddleBody"));
                            backpack.transform.localPosition = new Vector3(0, 0f);
                            backpack.transform.localScale = new Vector3(1.05f, 1.05f);
                            var backpackSprite = backpack.AddComponent<SpriteRenderer>();
                            backpackSprite.sprite = ModAPI.LoadSprite("Sprites/Chunsik.png");
                            backpack.GetComponent<SpriteRenderer>().sortingLayerName = "Bubbles";

                            }});

            //Other characters
            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Madagio",
                            NameToOrderByOverride = "J",
                            DescriptionOverride = "Should you disregard the mission entirely.... or attempt to cheat me.... I will ensure you spend the rest of your life in this toxic and vile wasteland.",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Madagio.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Madagio.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 400f;
                                    limb.InitialHealth = 400f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Technoblade †",
                            NameToOrderByOverride = "J",
                            DescriptionOverride = "Technoblade never dies!",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/Technoblade.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/Technoblade.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 1000f;
                                    limb.InitialHealth = 1000f;
                                    limb.RegenerationSpeed += 500f;

                                }}});

            ModAPI.Register(new Modification(){
                OriginalItem = ModAPI.FindSpawnable("Human"),
                            NameOverride = "[QSMP] Hank Schrader",
                            NameToOrderByOverride = "J",
                            DescriptionOverride = "I wanna put him in a fucking Jail, man",
                            CategoryOverride = ModAPI.FindCategory("The QSMP Mod"),
                            ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/HankSchrader.png"),
                            AfterSpawn = (Instance) =>{
                                var skin = ModAPI.LoadTexture("Sprites/HankSchrader.png");
                                var flesh = ModAPI.LoadTexture("Sprites/flesh.png");
                                var bone = ModAPI.LoadTexture("Sprites/bone.png");
                                var person = Instance.GetComponent<PersonBehaviour>();
                                person.SetBodyTextures(skin, flesh, bone, 1);
                                foreach (var limb in person.Limbs){
                                    limb.Health = 200f;
                                    limb.InitialHealth = 200f;
                                    limb.RegenerationSpeed += 50f;

                                }}});

        }}}
