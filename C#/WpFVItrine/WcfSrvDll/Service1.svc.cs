﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassLibDll;

namespace WcfSrvDll
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
       public static List<Article> liste = new List<Article>();

       public static List<Panier> paniers = new List<Panier>();

        static Service1()
        {
            liste.Add(new Article() { Nom = "Oblivion", Prix = 24, Quantite = 2, Description = "Action SF", Resume = "Aventure futurisque de Jack Harper(Tom Cruise)" });
            liste.Add(new Article() { Nom = "Zombiland", Prix = 16, Quantite = 1, Description = "Action Zombie Humour", Resume = "Bienvenu à Zombiland" });
            liste.Add(new Article() { Nom = "The Watchmen - Les justiciers", Prix = 18, Quantite = 5, Description = "Action Fantastique", Resume = "L'univers de DC" });
            liste.Add(new Article() { Nom = "Sins City - J'ai tué pour elle", Prix = 29, Quantite = 10, Description = "Action Polar", Resume = "Sins" });
            liste.Add(new Article() { Nom = "L'Age de glace", Prix = 10, Quantite = 3, Description = "Humour Anime", Resume = "Suivé les fole aventure de" });
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string login(string Nom, string Prenom)
        {
            bool exist = false;
            User user = new User();
            user.Nom = Nom;
            user.Prenom = Prenom;
            if(Prenom == "admin" && Nom == "admin")
            {
                user.Admin = true;
            }
            if (user.Admin != false)
            {
                user.ID = Nom + Prenom;
            }
            else
            {
                user.ID = "Admin007";
            }
            foreach (Panier p in paniers)
            {
                if (p.token == user.ID)
                {
                    exist = true;
                }
            }
            if (exist == false) 
            {
                paniers.Add(new Panier(user.ID));
            }
            return user.ID;
        }

        public List<Article> getListArticle()
        {
            return liste;
        }

        public List<Article> getPanier(string tok)
        {
            foreach (Panier item in paniers)
            {
                if (item.token == tok)
                {
                    return item.listePanier;   
                }
            }
            return new List<Article>();
        }

        public void ElemAddInPani(Article prod, string id)
        {
            //récupérer le panier
            //Article prod = produit as Article;
            bool existArticle = false;
            foreach (Panier p in paniers)
            {
                if (p.token == id)
                {
                    //verifier que le produit est pas déjà dans le panier
                    foreach (Article a in p.listePanier)
                    {
                        if (a.Nom == prod.Nom)
                        {
                            if(prod.Quantite > 0)
                            {                          
                                a.Quantite++;
                                foreach (Article art in liste)
                                {
                                    if (prod.Nom == art.Nom)
                                    {
                                        art.Quantite--;
                                        break;
                                    }
                                }
                                existArticle = true;
                            }
                            break;
                        }
                    }
                    if (existArticle == false)
                    {
                        if (prod.Quantite > 0)
                        {
                            foreach (Article art in liste)
                            {
                                if (prod.Nom == art.Nom)
                                {
                                    art.Quantite--;
                                    break;
                                }
                            }
                            Article produit = new Article() { Nom = prod.Nom, Prix = prod.Prix, Quantite = 1, Description = prod.Description, Resume = prod.Resume };
                            p.ajouter(produit);
                        }
                    }
                    break;
                }
            }
        }

        public void rajouter(string token)
        {

        }

        public void enlever(string token)
        {

        }

        public void retirer(string token)
        {

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
