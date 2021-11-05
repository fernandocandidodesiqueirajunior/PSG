using System;
using System.Collections.Generic;
using ConsoleApp.Poco;

namespace ConsoleApp.FakeDB
{
    public static class EstoqueFakeDB 
    {

        private static List<CategoriaPoco> categorias;

        private static List<SubCategoriaPoco> subCategorias;

        private static List<ProdutoPoco> produtos;

        private static void inicializarCategoria()
        {
            DateTime dataInsert = DateTime.Now;
            adicionarCategoria(1, "Alimento Infantil", dataInsert);
            adicionarCategoria(2, "Suplementos", dataInsert);
            adicionarCategoria(3, "Bebidas", dataInsert);
        }



 private static void adicionarCategoria(int id, String descricao, DateTime dataInsert)
        {
            CategoriaPoco c = new CategoriaPoco();
            c.CategoriaID = id;
            c.Descricao = descricao;
            c.DataInsert = dataInsert;
            categorias.Add(c);

        }




        private static void adicionarSubCategoria(int id, int catid, String descricao, DateTime dataInsert)
        {
            SubCategoriaPoco sc = new SubCategoriaPoco();
            sc.SubCategoriaID = id;
            sc.CategoriaID = catid;
            sc.Descricao = descricao;
            sc.DataInsert = dataInsert;
            subCategorias.Add(sc);
        }

        private static void adicionarProduto(int id, int subcatid, int catid, String descricao, DateTime dataInsert)
        {
            ProdutoPoco pr = new ProdutoPoco();
            pr.ProdutoID = id;
            pr.SubCategoriaID = subcatid;
            pr.CategoriaID = catid;
            pr.Descricao = descricao;
            pr.DataInsert = dataInsert;
            produtos.Add(pr);
        }



        public static List<CategoriaPoco> Categorias
        {
            get
            {
                if (categorias == null)
                {
                    categorias = new List<CategoriaPoco>();
                    inicializarCategoria();
            }
                return categorias;
            }
        }

        public static List<SubCategoriaPoco> SubCategorias
        {
            get
            {
                if (subCategorias == null)
                {
                    subCategorias = new List<SubCategoriaPoco>();
                    inicializarSubCategoria();
                }
                return subCategorias;
            }
        }


        public static List<ProdutoPoco> Produtos
        {
            get
            {
                if (produtos == null)
                {
                    produtos = new List<ProdutoPoco>();
                    inicializarProdutos();
                }
                return produtos;
            }
        }


        private static void inicializarSubCategoria()
        {
            DateTime dataInsert = DateTime.Now;
            adicionarSubCategoria(1, 1, "Papinha", dataInsert);
            adicionarSubCategoria(2, 1, "Sopinha", dataInsert);

            adicionarSubCategoria(3, 2, "Proteína", dataInsert);
            adicionarSubCategoria(4, 2, "Carboidratos", dataInsert);
            adicionarSubCategoria(5, 2, "Vitaminas", dataInsert);
            adicionarSubCategoria(6, 2, "Hipercalóricos", dataInsert);
            adicionarSubCategoria(7, 2, "Óxido Nítrico", dataInsert);
            adicionarSubCategoria(8, 2, "Aminoácidos", dataInsert);
            adicionarSubCategoria(9, 2, "Propriedade Funcional", dataInsert);

            adicionarSubCategoria(10, 3, "Achocolatados", dataInsert);
            adicionarSubCategoria(11, 3, "Bebidas a Base de Soja", dataInsert);
            adicionarSubCategoria(12, 3, "Bebidas Alcoólicas", dataInsert);
            adicionarSubCategoria(13, 3, "Café e Cia", dataInsert);
            adicionarSubCategoria(14, 3, "Chás", dataInsert);
            adicionarSubCategoria(15, 3, "Isotônicos e Energéticos", dataInsert);
            adicionarSubCategoria(16, 3, "Refrescos em Pó", dataInsert);
            adicionarSubCategoria(17, 3, "Refrigerantes", dataInsert);
            adicionarSubCategoria(18, 3, "Sucos Concentrados", dataInsert);
            adicionarSubCategoria(19, 3, "Sucos de Frutas Prontos", dataInsert);
            adicionarSubCategoria(20, 3, "Sucos Naturais", dataInsert);
            adicionarSubCategoria(21, 3, "Sucos Orgânicos", dataInsert);
        }

        private static void inicializarProdutos()
        {
            DateTime dataInsert = DateTime.Now;
            adicionarProduto(1, 1, 1, "Papinha Infantil de Ameixa NESTLÉ", dataInsert);
            adicionarProduto(2, 1, 1, "Papinha Infantil de Banana NESTLÉ", dataInsert);
            adicionarProduto(3, 1, 1, "Papinha Infantil de Goiaba NESTLÉ", dataInsert);
            adicionarProduto(4, 1, 1, "Papinha Infantil de Frutas Sortidas NESTLÉ", dataInsert);
            adicionarProduto(5, 1, 1, "Papinha Infantil de Maçã e Ameixa NESTLÉ", dataInsert);
            adicionarProduto(6, 1, 1, "Papinha Infantil de Maçã e Banana NESTLÉ", dataInsert);
            adicionarProduto(7, 1, 1, "Papinha Infantil de Pêra NESTLÉ", dataInsert);
            adicionarProduto(8, 2, 1, "Sopinha de Carne e Macarrão com Molho de Tomate Baby Duo NESTLÉ", dataInsert);
            adicionarProduto(9, 2, 1, "Sopinha de Strogonofinho com Arroz NESTLÉ", dataInsert);
            adicionarProduto(10, 2, 1, "Sopinha Infantil de Carne e Legumes NESTLÉ", dataInsert);
            adicionarProduto(11, 2, 1, "Sopinha Infantil de Carne, Cenoura, Mandioquinha e Batata NESTLÉ", dataInsert);
            adicionarProduto(12, 2, 1, "Sopinha Infantil de Carne, Legumes, Arroz e Gemas de Ovos NESTLÉ", dataInsert);
            adicionarProduto(13, 2, 1, "Sopinha Infantil de Espaguetinho à Bolonhesa NESTLÉ", dataInsert);
            adicionarProduto(14, 2, 1, "Sopinha Infantil de Feijão, Arroz, Beterraba e Legumes NESTLÉ", dataInsert);
            adicionarProduto(15, 2, 1, "Sopinha Infantil de Galinha e Legumes NESTLÉ", dataInsert);
            adicionarProduto(16, 2, 1, "Sopinha Infantil de Galinha, Legumes e Macarrão NESTLÉ", dataInsert);
            adicionarProduto(17, 2, 1, "Sopinha Infantil de Mandioquinha NESTLÉ", dataInsert);
            adicionarProduto(18, 2, 1, "Sopinha Infantil Picadinho de Carne NESTLÉ", dataInsert);
            adicionarProduto(19, 2, 1, "Sopinha Infantil Risotinho de Frango NESTLÉ", dataInsert);
            adicionarProduto(20, 3, 2, "Whey Protein 80% (Concentrado) (Growth Supplements)", dataInsert);
            adicionarProduto(21, 3, 2, "Albumina Saltos", dataInsert);
            adicionarProduto(22, 3, 2, "100% Whey Protein - Optimum", dataInsert);
            adicionarProduto(23, 3, 2, "100% Whey Protein - EAS", dataInsert);
            adicionarProduto(24, 3, 2, "Designer Whey Protein - Designer", dataInsert);
            adicionarProduto(25, 3, 2, "Whey Protein Perfect - Natures Best", dataInsert);
            adicionarProduto(26, 3, 2, "Whey Protein Pure - Health Labs", dataInsert);
            adicionarProduto(27, 3, 2, "Intra Pro Whey Protein Gaspari", dataInsert);
            adicionarProduto(28, 3, 2, "Milk Protein", dataInsert);
            adicionarProduto(29, 3, 2, "100% Casein Protein", dataInsert);
            adicionarProduto(30, 3, 2, "Syntha-6", dataInsert);
            adicionarProduto(31, 3, 2, "Platinum Hydrowhey", dataInsert);
            adicionarProduto(32, 3, 2, "Whey Protein Isolado 90% (Isolado) (Growth Supplements)", dataInsert);
            adicionarProduto(33, 3, 2, "Muscle Whey Protein NO2 (Neo Nutri)", dataInsert);
            adicionarProduto(34, 3, 2, "100% Pure Whey Morango PROBIÓTICA", dataInsert);
            adicionarProduto(35, 3, 2, "Pro Complex - Optimum", dataInsert);
            adicionarProduto(36, 3, 2, "Combat Powder - Muscle Pharm", dataInsert);
            adicionarProduto(37, 3, 2, "VP2 Whey Isolate", dataInsert);
            adicionarProduto(38, 3, 2, "3 Whey Protein - Probiótica", dataInsert);
            adicionarProduto(39, 3, 2, "Pro V60 - Labrada", dataInsert);
            adicionarProduto(40, 3, 2, "Top Whey - Max Titanium", dataInsert);
            adicionarProduto(41, 3, 2, "ISO Protein Zero Carb (900g) - Integralmédica", dataInsert);
            adicionarProduto(42, 3, 2, "Whey Protein - Extreme Whey Protein Solaris", dataInsert);
            adicionarProduto(43, 3, 2, "Milk Protein - Growth Supplements", dataInsert);
            adicionarProduto(44, 3, 2, "Pro Muscle - Probiótica", dataInsert);
            adicionarProduto(45, 3, 2, "Micellar Pro (Protein Time-Release) - Atlhetica Evolution", dataInsert);
            adicionarProduto(46, 3, 2, "MyoFusion - Gaspari Nutrition", dataInsert);
            adicionarProduto(47, 3, 2, "Elite Whey Protein - Dymatize", dataInsert);
            adicionarProduto(48, 3, 2, "100% Whey Protein Fuel - Twinlab", dataInsert);
            adicionarProduto(49, 3, 2, "Elite Fusion 7 - Dymatize", dataInsert);
            adicionarProduto(50, 3, 2, "Albumina Fama", dataInsert);
            adicionarProduto(51, 3, 2, "Albumina Naturovos", dataInsert);
            adicionarProduto(52, 4, 2, "Dextrose Millennium", dataInsert);
            adicionarProduto(53, 4, 2, "Malto Dextrin Body Action", dataInsert);
            adicionarProduto(54, 4, 2, "Mega Maltodextrin", dataInsert);
            adicionarProduto(55, 4, 2, "Maltodextrina - IntegralMedica", dataInsert);
            adicionarProduto(56, 4, 2, "(Maltodextrina) - Dynamic Lab", dataInsert);
            adicionarProduto(57, 4, 2, "Mega Malto Dextrin 1000g (maltodextrina) - Millennium", dataInsert);
            adicionarProduto(58, 4, 2, "Malto Active - D.N.A.", dataInsert);
            adicionarProduto(59, 4, 2, "Maltodextrina Refil - Atlhetica", dataInsert);
            adicionarProduto(60, 4, 2, "Maltodextrina - Neo-Nutri", dataInsert);
            adicionarProduto(61, 4, 2, "Maltodextrina - Milly", dataInsert);
            adicionarProduto(62, 4, 2, "CarboPlex (maltodextrina) - Advanced Products", dataInsert);
            adicionarProduto(63, 4, 2, "Carbo Fitness c/ Maltodextrina - Suplemente", dataInsert);
            adicionarProduto(64, 4, 2, "Nutry Carbo Maltodextrina - Solaris Nutrition", dataInsert);
            adicionarProduto(65, 4, 2, "Peter Carbo (Maltodextrina) - Peter Food", dataInsert);
            adicionarProduto(66, 4, 2, "Malto Dextrin Plus (Maltodextrina) - Milly", dataInsert);
            adicionarProduto(67, 4, 2, "Malto - C - Peter Food", dataInsert);
            adicionarProduto(68, 4, 2, "Malto Mix Carbo - Max Titanium", dataInsert);
            adicionarProduto(69, 4, 2, "Maltodextrina - D.N.A.", dataInsert);
            adicionarProduto(70, 4, 2, "Maltodextrina - MidWay", dataInsert);
            adicionarProduto(71, 4, 2, "Maltodextrina - Power Sport", dataInsert);
            adicionarProduto(72, 4, 2, "Maltodextrine Pure - Suplemente", dataInsert);
            adicionarProduto(73, 4, 2, "Maltodextrina - Max Titanium", dataInsert);
            adicionarProduto(74, 4, 2, "Maltodextrina - Growth Supplements", dataInsert);
            adicionarProduto(75, 4, 2, "Dextrose - Dextrose Neo Nutri", dataInsert);
            adicionarProduto(76, 4, 2, "Glyco-Maize", dataInsert);
            adicionarProduto(77, 4, 2, "NATURON ENDURANCE - NATURON", dataInsert);
            adicionarProduto(78, 5, 2, "Opti-Men", dataInsert);
            adicionarProduto(79, 5, 2, "Animal Pak", dataInsert);
            adicionarProduto(80, 5, 2, "Daily Life - Bodygenics", dataInsert);
            adicionarProduto(81, 5, 2, "Chromium Picolinate - Universal", dataInsert);
            adicionarProduto(82, 5, 2, "Magnésio + Vitamina C - Tiaraju", dataInsert);
            adicionarProduto(83, 5, 2, "Vitamina B12 - Tiaraju", dataInsert);
            adicionarProduto(84, 5, 2, "Ferro e Vitamina C - Phytomare", dataInsert);
            adicionarProduto(85, 5, 2, "Daily Formula - Universal", dataInsert);
            adicionarProduto(86, 6, 2, "Anticatabolic Mass 27000 - Nutrilatina AGE", dataInsert);
            adicionarProduto(87, 6, 2, "3000 Perfect - Natures Best", dataInsert);
            adicionarProduto(88, 6, 2, "Nutri Massa 15000 - IntegralMedica", dataInsert);
            adicionarProduto(89, 6, 2, "Hiper Mass Protein - Atlhetica", dataInsert);
            adicionarProduto(90, 6, 2, "Get Big 25000 - MidWay", dataInsert);
            adicionarProduto(91, 6, 2, "Mass Gainers 4400 - Nutrilatina AGE", dataInsert);
            adicionarProduto(92, 6, 2, "Hiper Mass 17500 Refil - Atlhetica", dataInsert);
            adicionarProduto(93, 6, 2, "Vit Thor 15000 - MidWay", dataInsert);
            adicionarProduto(94, 6, 2, "Mass Hyper Dyn - Dynamic Lab", dataInsert);
            adicionarProduto(95, 6, 2, "Heavy Weight 25000 - D.N.A.", dataInsert);
            adicionarProduto(96, 6, 2, "Heavy Mass 4000 - Neo-Nutri", dataInsert);
            adicionarProduto(97, 6, 2, "Hiper Mass 17500 (Edição Especial) - Atlhetica", dataInsert);
            adicionarProduto(98, 6, 2, "Nitroxx Mass - Atlhetica Evolution", dataInsert);
            adicionarProduto(99, 6, 2, "Real Gains - Universal", dataInsert);
            adicionarProduto(100, 6, 2, "Serious Performance Gainer - Performance Nutrition", dataInsert);
            adicionarProduto(101, 6, 2, "Gainers Mass 3000 - IntegralMedica", dataInsert);
            adicionarProduto(102, 6, 2, "Will Mass 9000 - Milly", dataInsert);
            adicionarProduto(103, 6, 2, "Critical Mass Advanced 3500 - NutriSport", dataInsert);
            adicionarProduto(104, 6, 2, "Will Mass Plus 16000 - Milly", dataInsert);
            adicionarProduto(105, 6, 2, "PerforMass - Performance Nutrition", dataInsert);
            adicionarProduto(106, 6, 2, "Will Mass 18000 - Milly", dataInsert);
            adicionarProduto(107, 6, 2, "Massa 3200 Probiótica", dataInsert);
            adicionarProduto(108, 6, 2, "Hipercalorico Elite mass - Dymatizer Nutrition", dataInsert);
            adicionarProduto(109, 6, 2, "MASS TITANIUM 17500", dataInsert);
            adicionarProduto(110, 7, 2, "No-Explode", dataInsert);
            adicionarProduto(111, 7, 2, "White Flood", dataInsert);
            adicionarProduto(112, 7, 2, "Jack3d", dataInsert);
            adicionarProduto(113, 7, 2, "SuperPump250", dataInsert);
            adicionarProduto(114, 7, 2, "NO Shotgun", dataInsert);
            adicionarProduto(115, 8, 2, "Creatina", dataInsert);
            adicionarProduto(116, 8, 2, "L-Glutamina - Body Action", dataInsert);
            adicionarProduto(117, 8, 2, "GlutaLean - Glutamina - Labrada", dataInsert);
            adicionarProduto(118, 8, 2, "Glutamina - Arnold Nutrition", dataInsert);
            adicionarProduto(119, 8, 2, "Glutamina - Universal", dataInsert);
            adicionarProduto(120, 8, 2, "Glutamina Powder - Optimum", dataInsert);
            adicionarProduto(121, 8, 2, "L-Glutamina 100% Pure - Milly", dataInsert);
            adicionarProduto(122, 8, 2, "L-Glutamina - Probiótica", dataInsert);
            adicionarProduto(123, 8, 2, "Glutamina - Ethika", dataInsert);
            adicionarProduto(124, 8, 2, "BCAA (Growth Supplements)", dataInsert);
            adicionarProduto(125, 8, 2, "Amino Fluid 37000 NO2 - Probiótica", dataInsert);
            adicionarProduto(126, 8, 2, "Poli Amino Acid 38000 (ZMA Cr) - IntegralMedica", dataInsert);
            adicionarProduto(127, 8, 2, "Creatina (Growth Supplements)", dataInsert);
            adicionarProduto(128, 8, 2, "Glutamina (Growth Supplements)", dataInsert);
            adicionarProduto(129, 8, 2, "BCAA MAX TITANIUM 1,2G", dataInsert);
            adicionarProduto(130, 9, 2, "Óleo de Peixe - Growth Supplements", dataInsert);
            adicionarProduto(131, 9, 2, "ZMA - Growth Supplements", dataInsert);
            adicionarProduto(132, 10, 3, "Achocolatado em Pó Sabor Chocolate com Coco TODDY Mais", dataInsert);
            adicionarProduto(133, 10, 3, "Achocolatado ELEGÊ Kids", dataInsert);
            adicionarProduto(134, 10, 3, "Achocolatado em Pó Nescau NESTLÉ", dataInsert);
            adicionarProduto(135, 10, 3, "Achocolatado em Pó Nescau Power NESTLÉ", dataInsert);
            adicionarProduto(136, 10, 3, "Achocolatado em Pó NOVOMILKE", dataInsert);
            adicionarProduto(137, 10, 3, "Achocolatado em Pó OVOMALTINE", dataInsert);
            adicionarProduto(138, 10, 3, "Achocolatado em Pó Sabor Chocolate ao Leite TODDY Mais", dataInsert);
            adicionarProduto(139, 10, 3, "Achocolatado em Pó Sabor Guaraná NESCAU", dataInsert);
            adicionarProduto(140, 10, 3, "Achocolatado em Pó Tipo Suíço OVOMALTINE", dataInsert);
            adicionarProduto(141, 10, 3, "Achocolatado em Pó TODDY", dataInsert);
            adicionarProduto(142, 10, 3, "Achocolatado Líquido Chocomilk BATAVO", dataInsert);
            adicionarProduto(143, 10, 3, "Achocolatado Líquido Danette DANONE", dataInsert);
            adicionarProduto(144, 10, 3, "Achocolatado Líquido Nescau NESTLÉ", dataInsert);
            adicionarProduto(145, 10, 3, "Achocolatado Líquido Prontinho Light Nescau NESTLÉ", dataInsert);
            adicionarProduto(146, 10, 3, "Achocolatado Líquido Prontinho Nescau NESTLÉ", dataInsert);
            adicionarProduto(147, 10, 3, "Achocolatado Líquido Sabor Brigadeiro TODDYNHO", dataInsert);
            adicionarProduto(148, 10, 3, "Achocolatado Líquido Sabor Brigadeiro TODDYNHO", dataInsert);
            adicionarProduto(149, 10, 3, "Achocolatado Líquido Sabor Napolitano TODDYNHO", dataInsert);
            adicionarProduto(150, 11, 3, "Bebida a Base de Soja DEL VALLE Light Tangerina", dataInsert);
            adicionarProduto(151, 11, 3, "Bebida a Base de Soja ADES Abacaxi", dataInsert);
            adicionarProduto(152, 11, 3, "Bebida a Base de Soja ADES Capuccino", dataInsert);
            adicionarProduto(153, 11, 3, "Bebida a Base de Soja ADES Chocolate", dataInsert);
            adicionarProduto(154, 11, 3, "Bebida a Base de Soja ADES Goiaba", dataInsert);
            adicionarProduto(155, 11, 3, "Bebida a Base de Soja ADES Laranja", dataInsert);
            adicionarProduto(156, 11, 3, "Bebida a Base de Soja ADES Maçã", dataInsert);
            adicionarProduto(157, 11, 3, "Bebida a Base de Soja ADES Manga", dataInsert);
            adicionarProduto(158, 11, 3, "Bebida a Base de Soja ADES Maracujá", dataInsert);
            adicionarProduto(159, 11, 3, "Bebida a Base de Soja ADES Morango", dataInsert);
            adicionarProduto(160, 11, 3, "a Base de Soja ADES Original", dataInsert);
            adicionarProduto(161, 11, 3, "Bebida a Base de Soja ADES Pessego", dataInsert);
            adicionarProduto(162, 11, 3, "Bebida a Base de Soja ADES Uva", dataInsert);
            adicionarProduto(163, 11, 3, "Bebida a Base de Soja ADES Verão Abacaxi com Hortelã", dataInsert);
            adicionarProduto(164, 11, 3, "Bebida a Base de Soja ADES Verão Limonada Suíça", dataInsert);
            adicionarProduto(165, 11, 3, "Bebida a Base de Soja ADES Verão Melancia", dataInsert);
            adicionarProduto(166, 11, 3, "Bebida a Base de Soja ADES Verão Pêra", dataInsert);
            adicionarProduto(167, 11, 3, "Bebida a Base de Soja ADES Verão Pêssego com Tangerina", dataInsert);
            adicionarProduto(168, 11, 3, "Bebida a Base de Soja BATAVO Original", dataInsert);
            adicionarProduto(169, 11, 3, "Bebida a Base de Soja DEL VALLE Abacaxi com Coco", dataInsert);
            adicionarProduto(170, 11, 3, "Bebida a Base de Soja DEL VALLE Goiaba", dataInsert);
            adicionarProduto(171, 11, 3, "Bebida a Base de Soja DEL VALLE Laranja", dataInsert);
            adicionarProduto(172, 11, 3, "Bebida a Base de Soja DEL VALLE Light Abacaxi com Coco", dataInsert);
            adicionarProduto(173, 11, 3, "Bebida a Base de Soja DEL VALLE Light Frutas Vermelhas", dataInsert);
            adicionarProduto(174, 11, 3, "Bebida a Base de Soja DEL VALLE Light Maçã com Canela", dataInsert);
            adicionarProduto(175, 11, 3, "Bebida a Base de Soja DEL VALLE Maçã", dataInsert);
            adicionarProduto(176, 11, 3, "Bebida a Base de Soja DEL VALLE Morango", dataInsert);
            adicionarProduto(177, 11, 3, "Bebida a Base de Soja DEL VALLE Pêssego", dataInsert);
            adicionarProduto(178, 11, 3, "Bebida a Base de Soja PURITY Laranja", dataInsert);
            adicionarProduto(179, 11, 3, "Bebida a Base de Soja PURITY Maçã", dataInsert);
            adicionarProduto(180, 11, 3, "Bebida a Base de Soja PURITY Original", dataInsert);
            adicionarProduto(181, 11, 3, "Bebida a Base de Soja PURITY Pêssego", dataInsert);
            adicionarProduto(182, 11, 3, "Bebida a Base de Soja PURITY Uva", dataInsert);
            adicionarProduto(183, 11, 3, "Bebida a Base de Soja SHEFA Frutas Tropicais", dataInsert);
            adicionarProduto(184, 11, 3, "Bebida a Base de Soja SHEFA Frutas Vermelhas", dataInsert);
            adicionarProduto(185, 11, 3, "Bebida a Base de Soja SHEFA Laranja com Pêssego", dataInsert);
            adicionarProduto(186, 11, 3, "Bebida a Base de Soja SHEFA Maçã", dataInsert);
            adicionarProduto(187, 11, 3, "Bebida a Base de Soja SHEFA Pêra", dataInsert);
            adicionarProduto(188, 11, 3, "Bebida a Base de Soja SHEFA Uva", dataInsert);
            adicionarProduto(189, 11, 3, "Bebida a Base de Soja SPLITZ Frutas Tropicais", dataInsert);
            adicionarProduto(190, 11, 3, "Bebida a Base de Soja SPLITZ Laranja com Pêssego", dataInsert);
            adicionarProduto(191, 11, 3, "Bebida a Base de Soja SPLITZ Maçã", dataInsert);
            adicionarProduto(192, 11, 3, "Bebida a Base de Soja SPLITZ Maracujá", dataInsert);
            adicionarProduto(193, 11, 3, "Bebida a Base de Soja SPLITZ Pêra", dataInsert);
            adicionarProduto(194, 11, 3, "Bebida a Base de Soja SPLITZ Frutas Vermelhas", dataInsert);
            adicionarProduto(195, 11, 3, "Bebida a Base de Soja SPLITZ Original", dataInsert);
            adicionarProduto(196, 11, 3, "Bebida a Base de Soja TONYU Abacaxi", dataInsert);
            adicionarProduto(197, 11, 3, "Bebida a Base de Soja TONYU Laranja e Mamão", dataInsert);
            adicionarProduto(198, 11, 3, "Bebida a Base de Soja TONYU Maçã", dataInsert);
            adicionarProduto(199, 11, 3, "Bebida a Base de Soja TONYU Maracujá", dataInsert);
            adicionarProduto(200, 11, 3, "Bebida a Base de Soja TONYU Morango", dataInsert);
            adicionarProduto(201, 11, 3, "Bebida Light à Base de Soja PURITY", dataInsert);
            adicionarProduto(202, 11, 3, "Bebida Light à Base de Soja PURITY Sabor Uva", dataInsert);
            adicionarProduto(203, 11, 3, "Bebida Light à Base Soja SPLITZ Original", dataInsert);
            adicionarProduto(204, 12, 3, "Aguardente", dataInsert);
            adicionarProduto(205, 12, 3, "Bloody Mary (bebída alcoólica)", dataInsert);
            adicionarProduto(206, 12, 3, "Bourbon e Soda (bebída alcoólica)", dataInsert);
            adicionarProduto(207, 12, 3, "Cerveja", dataInsert);
            adicionarProduto(208, 12, 3, "Champanhe", dataInsert);
            adicionarProduto(209, 12, 3, "Cidra", dataInsert);
            adicionarProduto(210, 12, 3, "Conhaque", dataInsert);
            adicionarProduto(211, 12, 3, "Creme de Menta, teor 72 (bebída alcoólica)", dataInsert);
            adicionarProduto(212, 12, 3, "Gim, teor 100", dataInsert);
            adicionarProduto(213, 12, 3, "Gim, teor 80", dataInsert);
            adicionarProduto(214, 12, 3, "Gim, teor 86", dataInsert);
            adicionarProduto(215, 12, 3, "Gim, teor 90", dataInsert);
            adicionarProduto(216, 12, 3, "Gim, teor 94", dataInsert);
            adicionarProduto(217, 12, 3, "Licor de Café com Creme, teor 34", dataInsert);
            adicionarProduto(218, 12, 3, "Licor de Café, teor 53", dataInsert);
            adicionarProduto(219, 12, 3, "Licor de Café, teor 63", dataInsert);
            adicionarProduto(220, 12, 3, "Licores", dataInsert);
            adicionarProduto(221, 12, 3, "Martini", dataInsert);
            adicionarProduto(222, 12, 3, "Pina Colada, em lata", dataInsert);
            adicionarProduto(223, 12, 3, "Pina Colada, preparada de receita", dataInsert);
            adicionarProduto(224, 12, 3, "Rum, teor 100", dataInsert);
            adicionarProduto(225, 12, 3, "Rum, teor 80", dataInsert);
            adicionarProduto(226, 12, 3, "Rum, teor 86", dataInsert);
            adicionarProduto(227, 12, 3, "Rum, teor 90", dataInsert);
            adicionarProduto(228, 12, 3, "Rum, teor 94", dataInsert);
            adicionarProduto(229, 12, 3, "Sakê", dataInsert);
            adicionarProduto(230, 12, 3, "Screwdriver (bebida alcoólica)", dataInsert);
            adicionarProduto(231, 12, 3, "Suco de Acerola", dataInsert);
            adicionarProduto(232, 12, 3, "Tequila Sunrise, enlatada", dataInsert);
            adicionarProduto(233, 12, 3, "Tom Collins (bebida alcoólica)", dataInsert);
            adicionarProduto(234, 12, 3, "Vermute, doce (bebida alcoólica)", dataInsert);
            adicionarProduto(235, 12, 3, "Vermute, seco (bebida alcoólica)", dataInsert);
            adicionarProduto(236, 12, 3, "Vinho aperitivo, doce", dataInsert);
            adicionarProduto(237, 12, 3, "Vinho aperitivo, seco", dataInsert);
            adicionarProduto(238, 12, 3, "Vinho aperitivo, seco", dataInsert);
            adicionarProduto(239, 12, 3, "Vinho Branco, médio", dataInsert);
            adicionarProduto(240, 12, 3, "Vinho Branco, seco", dataInsert);
            adicionarProduto(241, 12, 3, "Vinho de Jenipapo", dataInsert);
            adicionarProduto(242, 12, 3, "Vinho de Maçã", dataInsert);
            adicionarProduto(243, 12, 3, "Vinho Moscatel", dataInsert);
            adicionarProduto(244, 12, 3, "Vinho Rosé", dataInsert);
            adicionarProduto(245, 12, 3, "Vinho Tinto", dataInsert);
            adicionarProduto(246, 12, 3, "Vinho, em média", dataInsert);
            adicionarProduto(247, 12, 3, "Vodka, teor 100", dataInsert);
            adicionarProduto(248, 12, 3, "Vodka, teor 80", dataInsert);
            adicionarProduto(249, 12, 3, "Whiskey, teor 86", dataInsert);
            adicionarProduto(250, 12, 3, "Vodka, teor 90", dataInsert);
            adicionarProduto(251, 12, 3, "Vodka, teor 94", dataInsert);
            adicionarProduto(252, 12, 3, "Whiskey Amargo", dataInsert);
            adicionarProduto(253, 12, 3, "Whiskey, teor 100", dataInsert);
            adicionarProduto(254, 12, 3, "Whiskey, teor 80", dataInsert);
            adicionarProduto(255, 12, 3, "Whiskey, teor 86", dataInsert);
            adicionarProduto(256, 12, 3, "Whiskey, teor 90", dataInsert);
            adicionarProduto(257, 12, 3, "Whiskey, teor 94", dataInsert);
            adicionarProduto(258, 13, 3, "Café com Leite NESCAFÉ", dataInsert);
            adicionarProduto(259, 13, 3, "Café, com açúcar (pronto para beber)", dataInsert);
            adicionarProduto(260, 13, 3, "Café, sem açúcar (pronto para beber)", dataInsert);
            adicionarProduto(261, 13, 3, "Cappuccino Classic 3 CORAÇÕES", dataInsert);
            adicionarProduto(262, 13, 3, "Cappuccino com Chocolate e Avelã PILÃO", dataInsert);
            adicionarProduto(263, 13, 3, "Cappuccino Descafeinado DI CAPRI", dataInsert);
            adicionarProduto(264, 13, 3, "Cappuccino Diet DI CAPRI", dataInsert);
            adicionarProduto(265, 13, 3, "Cappuccino Light 3 CORAÇÕES", dataInsert);
            adicionarProduto(266, 13, 3, "Cappuccino Light DI CAPRI", dataInsert);
            adicionarProduto(267, 13, 3, "Cappuccino Light PILÃO", dataInsert);
            adicionarProduto(268, 13, 3, "Cappuccino Sabor Canela DI CAPRI", dataInsert);
            adicionarProduto(269, 13, 3, "Cappuccino Sabor Chocolate 3 CORAÇÕES", dataInsert);
            adicionarProduto(270, 13, 3, "Cappuccino Sabor Chocolate Suíço DI CAPRI", dataInsert);
            adicionarProduto(271, 13, 3, "Cappuccino Tradicional DI CAPRI", dataInsert);
            adicionarProduto(272, 13, 3, "Cappuccino Tradicional PILÃO", dataInsert);
            adicionarProduto(273, 13, 3, "Cappuccino Tradicional Sem Açúcar DI CAPRI", dataInsert);
            adicionarProduto(274, 13, 3, "Capuccino (café)", dataInsert);
            adicionarProduto(275, 13, 3, "Shake Sabor Cappuccino Tradicional DI CAPRI", dataInsert);
            adicionarProduto(276, 14, 3, "Chá com Pessego SANTAL", dataInsert);
            adicionarProduto(277, 14, 3, "Chá de Ervas, fervido", dataInsert);
            adicionarProduto(278, 14, 3, "Chá Diet Matte LEÃO Sabor Limão", dataInsert);
            adicionarProduto(279, 14, 3, "Chá Diet Matte LEÃO Sabor Natural", dataInsert);
            adicionarProduto(280, 14, 3, "Chá Light LIPTON Ice Tea Sabor Limão", dataInsert);
            adicionarProduto(281, 14, 3, "Chá Diet Matte LEÃO Sabor Natural", dataInsert);
            adicionarProduto(282, 14, 3, "Chá Light LIPTON Ice Tea Sabor Limão", dataInsert);
            adicionarProduto(283, 14, 3, "Chá Light LIPTON Ice Tea Sabor Pêssego", dataInsert);
            adicionarProduto(284, 14, 3, "Chá Light NESTEA Sabor Limão", dataInsert);
            adicionarProduto(285, 14, 3, "Chá Light NESTEA Sabor Pêssego", dataInsert);
            adicionarProduto(286, 14, 3, "Chá Mate com Limão SANTAL", dataInsert);
            adicionarProduto(287, 14, 3, "Chá Verde com Tangerina LEÃO", dataInsert);
            adicionarProduto(288, 14, 3, "Chá Verde FEEL GOOD", dataInsert);
            adicionarProduto(289, 14, 3, "Chá, infuso sem açucar", dataInsert);
            adicionarProduto(290, 14, 3, "Iced Tea Limão LEÃO", dataInsert);
            adicionarProduto(291, 14, 3, "Iced Tea LIPTON Limão", dataInsert);
            adicionarProduto(292, 14, 3, "Iced Tea LIPTON Pessego", dataInsert);
            adicionarProduto(293, 14, 3, "Matte com Guaraná LEÃO", dataInsert);
            adicionarProduto(294, 14, 3, "Matte com Limão LEÃO", dataInsert);
            adicionarProduto(295, 14, 3, "Matte LEÃO", dataInsert);
            adicionarProduto(296, 14, 3, "NESTEA Limão", dataInsert);
            adicionarProduto(297, 14, 3, "NESTEA Maracujá", dataInsert);
            adicionarProduto(298, 14, 3, "NESTEA Pêssego", dataInsert);
            adicionarProduto(299, 14, 3, "NESTEA Tangerina", dataInsert);
            adicionarProduto(300, 14, 3, "Refresco em Pó CLIGHT Sabor Pêra", dataInsert);
            adicionarProduto(301, 15, 3, "Isotônico em Pó GOLLY POWER Sabor Maracujá", dataInsert);
            adicionarProduto(302, 15, 3, "Isotônico em Pó GOLLY POWER Sabor Tangerina", dataInsert);
            adicionarProduto(303, 15, 3, "Repositor Energético em Gel CARB UP", dataInsert);
            adicionarProduto(304, 15, 3, "Repositor Energético em Pó Sabor Limão POWER BAR", dataInsert);
            adicionarProduto(305, 15, 3, "Repositor Energético em Pó Sabor Limão POWER BAR", dataInsert);
            adicionarProduto(306, 15, 3, "Bebida Energética Austríaco FLASH POWER", dataInsert);
            adicionarProduto(307, 15, 3, "Bebida Energética BAD BOY", dataInsert);
            adicionarProduto(308, 15, 3, "Bebida Energética Booster FLYING HORSE", dataInsert);
            adicionarProduto(309, 15, 3, "Bebida Energética BURN DRINK", dataInsert);
            adicionarProduto(310, 15, 3, "Bebida Energética FLY HORSE Light", dataInsert);
            adicionarProduto(311, 15, 3, "Bebida Energética RED BULL", dataInsert);
            adicionarProduto(312, 15, 3, "Bebida Energética RUSH Energy Drink", dataInsert);
            adicionarProduto(313, 15, 3, "Bebida Energética Sugar Free RED BULL", dataInsert);
            adicionarProduto(314, 15, 3, "Isotônico em Pó GOLLY POWER Sabor Frutas Cítricas", dataInsert);
            adicionarProduto(315, 15, 3, "Isotônico em Pó GOLLY POWER Sabor Laranja", dataInsert);
            adicionarProduto(316, 15, 3, "Isotônico em Pó GOLLY POWER Sabor Limão", dataInsert);
            adicionarProduto(317, 15, 3, "Isotônico GATORADE Cool Blue Sabor Framboesa", dataInsert);
            adicionarProduto(318, 15, 3, "Isotônico GATORADE Sabor Laranja", dataInsert);
            adicionarProduto(319, 15, 3, "Isotônico GATORADE Sabor Limão", dataInsert);
            adicionarProduto(320, 15, 3, "Isotônico GATORADE Sabor Maracujá", dataInsert);
            adicionarProduto(321, 15, 3, "Isotônico GATORADE Sabor Morango e Maracujá", dataInsert);
            adicionarProduto(322, 15, 3, "Isotônico GATORADE Sabor Tangerina", dataInsert);
            adicionarProduto(323, 15, 3, "Isotônico GATORADE Sabor Uva", dataInsert);
            adicionarProduto(324, 15, 3, "Repositor Energético INDAIA Citrus Sabor Frutas Cítricas", dataInsert);
            adicionarProduto(325, 15, 3, "Repositor Energético INDAIA Citrus Sabor Frutas Tropicais", dataInsert);
            adicionarProduto(326, 15, 3, "Repositor Energético Power Gel Baunilha POWER BAR", dataInsert);
            adicionarProduto(327, 15, 3, "Repositor Energético Power Gel Chocolate POWER BAR", dataInsert);
            adicionarProduto(328, 15, 3, "Repositor Energético Power Gel Frutas Tropicais POWER BAR", dataInsert);
            adicionarProduto(329, 15, 3, "Repositor Energético Power Gel Morango e Banana POWER BAR", dataInsert);
            adicionarProduto(330, 15, 3, "Repositor Energético Sabor Laranja POWERBAR", dataInsert);
            adicionarProduto(331, 15, 3, "Suplemento de Vitaminas Hiline YAKULT", dataInsert);
            adicionarProduto(332, 15, 3, "Suplemento de Vitaminas Taff Man-E YAKULT", dataInsert);
            adicionarProduto(333, 16, 3, "Refresco em Pó MID de Tangerina", dataInsert);
            adicionarProduto(334, 16, 3, "Refresco em Pó SUKEST de Tangerina0.01", dataInsert);
            adicionarProduto(335, 16, 3, "Chá em Pó CLIGHT de Limão", dataInsert);
            adicionarProduto(336, 16, 3, "Chá em Pó CLIGHT Sabor Pêssego", dataInsert);
            adicionarProduto(337, 16, 3, "Refresco em Pó CAMP de Coco Verde", dataInsert);
            adicionarProduto(338, 16, 3, "Refresco em Pó CAMP de Laranja", dataInsert);
            adicionarProduto(339, 16, 3, "Refresco em Pó CAMP de Limão", dataInsert);
            adicionarProduto(340, 16, 3, "Refresco em Pó CAMP de Manga", dataInsert);
            adicionarProduto(341, 16, 3, "Refresco em Pó CAMP de Maracujá", dataInsert);
            adicionarProduto(342, 16, 3, "Refresco em Pó CAMP de Morango", dataInsert);
            adicionarProduto(343, 16, 3, "Refresco em Pó CAMP de Tangerina", dataInsert);
            adicionarProduto(344, 16, 3, "Refresco em Pó CAMP de Uva", dataInsert);
            adicionarProduto(345, 16, 3, "Refresco em Pó CAMP Salada de Frutas", dataInsert);
            adicionarProduto(346, 16, 3, "Refresco em Pó CLIGHT Sabor Abacaxi com Hortelã", dataInsert);
            adicionarProduto(347, 16, 3, "Refresco em Pó CLIGHT Sabor Laranja", dataInsert);
            adicionarProduto(348, 16, 3, "Refresco em Pó CLIGHT Sabor Lima Limão", dataInsert);
            adicionarProduto(349, 16, 3, "Refresco em Pó CLIGHT Sabor Maracujá", dataInsert);
            adicionarProduto(350, 16, 3, "Refresco em Pó CLIGHT Sabor Morango Silvestre", dataInsert);
            adicionarProduto(351, 16, 3, "Refresco em Pó CLIGHT Sabor Tangerina", dataInsert);
            adicionarProduto(352, 16, 3, "Refresco em Pó CLIGHT Sabor Uva", dataInsert);
            adicionarProduto(353, 16, 3, "Refresco em Pó FRESH de Abacaxi", dataInsert);
            adicionarProduto(354, 16, 3, "Refresco em Pó FRESH de Laranja", dataInsert);
            adicionarProduto(355, 16, 3, "Refresco em Pó FRESH de Limão", dataInsert);
            adicionarProduto(356, 16, 3, "Refresco em Pó FRESH de Manga", dataInsert);
            adicionarProduto(357, 16, 3, "Refresco em Pó FRESH de Maracujá", dataInsert);
            adicionarProduto(358, 16, 3, "Refresco em Pó FRESH de Morango", dataInsert);
            adicionarProduto(359, 16, 3, "Refresco em Pó FRESH de Uva", dataInsert);
            adicionarProduto(360, 16, 3, "Refresco em Pó FRISCO de Tangerina", dataInsert);
            adicionarProduto(361, 16, 3, "Refresco em Pó FRISCO de Uva", dataInsert);
            adicionarProduto(362, 16, 3, "Refresco em Pó GOODLIGHT Sabor Laranja", dataInsert);
            adicionarProduto(363, 16, 3, "Refresco em Pó GOODLIGHT Sabor Maracujá", dataInsert);
            adicionarProduto(364, 16, 3, "Refresco em Pó GOODLIGHT Sabor Morango", dataInsert);
            adicionarProduto(365, 16, 3, "Refresco em Pó GOODLIGHT Sabor Tangerina", dataInsert);
            adicionarProduto(366, 16, 3, "Refresco em Pó MID de Abacaxi", dataInsert);
            adicionarProduto(367, 16, 3, "Refresco em Pó MID de Carambola", dataInsert);
            adicionarProduto(368, 16, 3, "Refresco em Pó MID de Graviola", dataInsert);
            adicionarProduto(369, 16, 3, "Refresco em Pó MID de Laranja", dataInsert);
            adicionarProduto(370, 16, 3, "Refresco em Pó MID de Limão", dataInsert);
            adicionarProduto(371, 16, 3, "Refresco em Pó MID de Maçã", dataInsert);
            adicionarProduto(372, 16, 3, "Refresco em Pó MID de Manga", dataInsert);
            adicionarProduto(373, 16, 3, "Refresco em Pó MID de Maracujá", dataInsert);
            adicionarProduto(374, 16, 3, "Refresco em Pó MID de Morango", dataInsert);
            adicionarProduto(375, 16, 3, "Refresco em Pó MID de Pêra", dataInsert);
            adicionarProduto(376, 16, 3, "Refresco em Pó MID de Pêssego", dataInsert);
            adicionarProduto(377, 16, 3, "Refresco em Pó MID de Uva", dataInsert);
            adicionarProduto(378, 16, 3, "Refresco em Pó SUKEST de Abacaxi", dataInsert);
            adicionarProduto(379, 16, 3, "Refresco em Pó SUKEST de Laranja", dataInsert);
            adicionarProduto(380, 16, 3, "Refresco em Pó SUKEST de Laranja com Acerola", dataInsert);
            adicionarProduto(381, 16, 3, "Refresco em Pó SUKEST de Laranja com Manga", dataInsert);
            adicionarProduto(382, 16, 3, "Refresco em Pó SUKEST de Limão", dataInsert);
            adicionarProduto(383, 16, 3, "Refresco em Pó SUKEST de Manga", dataInsert);
            adicionarProduto(384, 16, 3, "Refresco em Pó SUKEST de Maracujá", dataInsert);
            adicionarProduto(385, 16, 3, "Refresco em Pó SUKEST de Morango", dataInsert);
            adicionarProduto(386, 16, 3, "Refresco em Pó SUKEST de Uva", dataInsert);
            adicionarProduto(387, 16, 3, "Refresco em Pó TANG de Abacaxi", dataInsert);
            adicionarProduto(388, 16, 3, "Refresco em Pó TANG de Caju", dataInsert);
            adicionarProduto(389, 16, 3, "Refresco em Pó TANG de Goiaba", dataInsert);
            adicionarProduto(390, 16, 3, "Refresco em Pó TANG de Laranja", dataInsert);
            adicionarProduto(391, 16, 3, "Refresco em Pó TANG de Limão", dataInsert);
            adicionarProduto(392, 16, 3, "Refresco em Pó TANG de Manga", dataInsert);
            adicionarProduto(393, 16, 3, "Refresco em Pó TANG de Maracujá", dataInsert);
            adicionarProduto(394, 16, 3, "Refresco em Pó TANG de Morango", dataInsert);
            adicionarProduto(395, 16, 3, "Refresco em Pó TANG de Pêra", dataInsert);
            adicionarProduto(396, 16, 3, "Refresco em Pó TANG de Pêssego", dataInsert);
            adicionarProduto(397, 16, 3, "Refresco em Pó TANG de Tangerina", dataInsert);
            adicionarProduto(398, 16, 3, "Refresco em Pó TANG de Uva", dataInsert);
            adicionarProduto(399, 17, 3, "Refrigerante TAÍ Guaraná", dataInsert);
            adicionarProduto(400, 17, 3, "Refrigerante ANTARCTICA Guaraná", dataInsert);
            adicionarProduto(401, 17, 3, "Água Tônica ANTARCTICA", dataInsert);
            adicionarProduto(402, 17, 3, "Água Tônica ANTARCTICA Diet", dataInsert);
            adicionarProduto(403, 17, 3, "Água Tônica CLASSIC", dataInsert);
            adicionarProduto(404, 17, 3, "Água Tônica CLASSIC Diet", dataInsert);
            adicionarProduto(405, 17, 3, "Água Tônica CLASSIC Limão", dataInsert);
            adicionarProduto(406, 17, 3, "Água Tônica SCHWEPPES", dataInsert);
            adicionarProduto(407, 17, 3, "Refrigerante ANTARCTICA Diet Guaraná", dataInsert);
            adicionarProduto(408, 17, 3, "Refrigerante ANTARCTICA Diet Soda Limão", dataInsert);
            adicionarProduto(409, 17, 3, "Refrigerante ANTARCTICA Guaraná ZON", dataInsert);
            adicionarProduto(410, 17, 3, "Refrigerante ANTARCTICA Soda Limão", dataInsert);
            adicionarProduto(411, 17, 3, "Refrigerante CLASSIC Citrus", dataInsert);
            adicionarProduto(412, 17, 3, "Refrigerante COCA COLA", dataInsert);
            adicionarProduto(413, 17, 3, "Refrigerante COCA COLA Light", dataInsert);
            adicionarProduto(414, 17, 3, "Refrigerante COCA COLA Light Lemon", dataInsert);
            adicionarProduto(415, 17, 3, "Refrigerante de Limão de Baixa Caloria H2OH! PEPSI", dataInsert);
            adicionarProduto(416, 17, 3, "Refrigerante DOLLY Cola", dataInsert);
            adicionarProduto(417, 17, 3, "Refrigerante DOLLY Diet Guaraná", dataInsert);
            adicionarProduto(418, 17, 3, "Refrigerante DOLLY Diet Limão", dataInsert);
            adicionarProduto(419, 17, 3, "Refrigerante DOLLY Laranja", dataInsert);
            adicionarProduto(420, 17, 3, "Refrigerante FANTA Laranja", dataInsert);
            adicionarProduto(421, 17, 3, "Refrigerante FANTA Light Laranja", dataInsert);
            adicionarProduto(422, 17, 3, "Refrigerante FANTA Mix", dataInsert);
            adicionarProduto(423, 17, 3, "Refrigerante FANTA Uva", dataInsert);
            adicionarProduto(424, 17, 3, "Refrigerante Guaraná KUAT", dataInsert);
            adicionarProduto(425, 17, 3, "Refrigerante KUAT Guaraná com Laranja", dataInsert);
            adicionarProduto(426, 17, 3, "Refrigerante KUAT Guaraná Zero", dataInsert);
            adicionarProduto(427, 17, 3, "Refrigerante PEPSI", dataInsert);
            adicionarProduto(428, 17, 3, "Refrigerante PEPSI Energy Cola", dataInsert);
            adicionarProduto(429, 17, 3, "Refrigerante PEPSI Light", dataInsert);
            adicionarProduto(430, 17, 3, "Refrigerante PEPSI Twist", dataInsert);
            adicionarProduto(431, 17, 3, "Refrigerante PEPSI Twist Light", dataInsert);
            adicionarProduto(432, 17, 3, "Refrigerante SCHIN Guaraná", dataInsert);
            adicionarProduto(433, 17, 3, "Refrigerante SCHIN Laranja", dataInsert);
            adicionarProduto(434, 17, 3, "Refrigerante SCHIN Limão", dataInsert);
            adicionarProduto(435, 17, 3, "Refrigerante SCHINCARIOL Itubaina", dataInsert);
            adicionarProduto(436, 17, 3, "Refrigerante SCHINCARIOL Maçã", dataInsert);
            adicionarProduto(437, 17, 3, "Refrigerante SCHWEPPES Club Soda", dataInsert);
            adicionarProduto(438, 17, 3, "Refrigerante SEVEN UP Limão", dataInsert);
            adicionarProduto(439, 17, 3, "Refrigerante SPRITE", dataInsert);
            adicionarProduto(440, 17, 3, "Refrigerante SPRITE Zero", dataInsert);
            adicionarProduto(441, 17, 3, "Refrigerante SUKITA Laranja", dataInsert);
            adicionarProduto(442, 18, 3, "Suco Concentrado SANTÁL de Manga", dataInsert);
            adicionarProduto(443, 18, 3, "Suco Concentrado MILANI de Manga", dataInsert);
            adicionarProduto(444, 18, 3, "Suco Concentrado Congelado JAL de Acerola", dataInsert);
            adicionarProduto(445, 18, 3, "Suco Concentrado Congelado JAL de Laranja", dataInsert);
            adicionarProduto(446, 18, 3, "Suco Concentrado Congelado JAL de Limão", dataInsert);
            adicionarProduto(447, 18, 3, "Suco Concentrado Congelado JAL de Maracujá", dataInsert);
            adicionarProduto(448, 18, 3, "Suco Concentrado Congelado JAL de Tangerina", dataInsert);
            adicionarProduto(449, 18, 3, "Suco Concentrado Congelado JAL de Uva", dataInsert);
            adicionarProduto(450, 18, 3, "Suco Concentrado Congelado JAL sem Acúcar de Laranja", dataInsert);
            adicionarProduto(451, 18, 3, "Suco Concentrado JANDAIA de Abacaxi", dataInsert);
            adicionarProduto(452, 18, 3, "Suco Concentrado JANDAIA de Manga", dataInsert);
            adicionarProduto(453, 18, 3, "Suco Concentrado MAGUARY de Abacaxi", dataInsert);
            adicionarProduto(454, 18, 3, "Suco Concentrado MAGUARY de Caju", dataInsert);
            adicionarProduto(455, 18, 3, "Suco Concentrado MAGUARY de Goiaba", dataInsert);
            adicionarProduto(456, 18, 3, "Suco Concentrado MAGUARY de Laranja", dataInsert);
            adicionarProduto(457, 18, 3, "Suco Concentrado MAGUARY de Manga", dataInsert);
            adicionarProduto(458, 18, 3, "Suco Concentrado MAGUARY de Maracujá", dataInsert);
            adicionarProduto(459, 18, 3, "Suco Concentrado MAGUARY de Pêssego", dataInsert);
            adicionarProduto(460, 18, 3, "Suco Concentrado MAGUARY de Uva", dataInsert);
            adicionarProduto(461, 18, 3, "Suco Concentrado MILANI de Caju Garrafa", dataInsert);
            adicionarProduto(462, 18, 3, "Suco Concentrado MILANI de Goiaba", dataInsert);
            adicionarProduto(463, 18, 3, "Suco Concentrado MILANI de Maracujá", dataInsert);
            adicionarProduto(464, 18, 3, "Suco Concentrado MILANI de Tomate", dataInsert);
            adicionarProduto(465, 18, 3, "Suco Concentrado MILANI de Uva", dataInsert);
            adicionarProduto(466, 18, 3, "Suco Concentrado SALTON de Uva", dataInsert);
            adicionarProduto(467, 18, 3, "Suco Concentrado SANTÁL de Caju", dataInsert);
            adicionarProduto(468, 18, 3, "Suco Concentrado SANTÁL de Maracujá", dataInsert);
            adicionarProduto(469, 18, 3, "Suco Concentrado SANTÁL de Uva", dataInsert);
            adicionarProduto(470, 18, 3, "Suco Concentrado SUPERBOM de Tomate Integral", dataInsert);
            adicionarProduto(471, 18, 3, "Suco Concentrado SUPERBOM de Tomate Temperado", dataInsert);
            adicionarProduto(472, 18, 3, "Suco Concentrado SUPERBOM de Uva", dataInsert);
            adicionarProduto(473, 18, 3, "Xarope de Groselha G´NUTRE com Vitamina C", dataInsert);
            adicionarProduto(474, 18, 3, "Xarope de Groselha MILANI", dataInsert);
            adicionarProduto(475, 18, 3, "Xarope de Groselha MILANI Light", dataInsert);
            adicionarProduto(476, 18, 3, "Xarope de Groselha MILANI Vitaminado", dataInsert);
            adicionarProduto(477, 18, 3, "Xarope de Groselha NATURABELLA", dataInsert);
            adicionarProduto(478, 18, 3, "Xarope de Groselha TROPICAL", dataInsert);
            adicionarProduto(479, 18, 3, "Xarope de Guaraná G´NUTRE", dataInsert);
            adicionarProduto(480, 18, 3, "Xarope de Guaraná Orgânico IÚ MIRIM", dataInsert);
            adicionarProduto(481, 18, 3, "Xarope de Guaraná TROPICAL", dataInsert);
            adicionarProduto(482, 18, 3, "Xarope de Uva G´NUTRE", dataInsert);
            adicionarProduto(483, 18, 3, "Xarope Maple GULI GULI", dataInsert);
            adicionarProduto(484, 19, 3, "Suco de Caju SÚFRESH", dataInsert);
            adicionarProduto(485, 19, 3, "Suco de Laranja XANDÔ", dataInsert);
            adicionarProduto(486, 19, 3, "Suco de Morango e Kiwi com Iogurte Molico Light NESTLÉ", dataInsert);
            adicionarProduto(487, 19, 3, "Néctar de Goiaba MAGUARY", dataInsert);
            adicionarProduto(488, 19, 3, "Néctar de Laranja LECO", dataInsert);
            adicionarProduto(489, 19, 3, "Néctar de Laranja MAGUARY", dataInsert);
            adicionarProduto(490, 19, 3, "Néctar de Laranja NESTLÉ", dataInsert);
            adicionarProduto(491, 19, 3, "Néctar de Laranja SUFRESH", dataInsert);
            adicionarProduto(492, 19, 3, "Néctar de Maça SÚFRESH", dataInsert);
            adicionarProduto(493, 19, 3, "Néctar de Manga MAGUARY", dataInsert);
            adicionarProduto(494, 19, 3, "Néctar de Maracujá MAGUARY", dataInsert);
            adicionarProduto(495, 19, 3, "Néctar de Maracujá SÚFRESH", dataInsert);
            adicionarProduto(496, 19, 3, "Néctar de Morango SÚFRESH", dataInsert);
            adicionarProduto(497, 19, 3, "Néctar de Pêra SÚFRESH", dataInsert);
            adicionarProduto(498, 19, 3, "Néctar de Pêssego MAGUARY", dataInsert);
            adicionarProduto(499, 19, 3, "Néctar de Pêssego SANTÁL", dataInsert);
            adicionarProduto(500, 19, 3, "Néctar de Pêssego SÚFRESH", dataInsert);
            adicionarProduto(501, 19, 3, "Néctar de Uva MAGUARY", dataInsert);
            adicionarProduto(502, 19, 3, "Néctar de Uva SÚFRESH", dataInsert);
            adicionarProduto(503, 19, 3, "Néctar Light LECO Sabor Laranja", dataInsert);
            adicionarProduto(504, 19, 3, "Néctar Light MAGUARY Sabor Laranja", dataInsert);
            adicionarProduto(505, 19, 3, "Néctar Light MAGUARY Sabor Manga", dataInsert);
            adicionarProduto(506, 19, 3, "Néctar Light MAGUARY Sabor Maracujá", dataInsert);
            adicionarProduto(507, 19, 3, "Néctar Light MAGUARY Sabor Pêssego", dataInsert);
            adicionarProduto(508, 19, 3, "Néctar Light MAGUARY Sabor Uva", dataInsert);
            adicionarProduto(509, 19, 3, "Néctar Light SÚFRESH Sabor Manga", dataInsert);
            adicionarProduto(510, 19, 3, "Néctar Light SÚFRESH Sabor Maracujá", dataInsert);
            adicionarProduto(511, 19, 3, "Néctar Light SÚFRESH Sabor Pêssego", dataInsert);
            adicionarProduto(512, 19, 3, "Néctar Light SÚFRESH Sabor Uva", dataInsert);
            adicionarProduto(513, 19, 3, "Néctar Misto de Laranje e Morango DEL VALLE", dataInsert);
            adicionarProduto(514, 19, 3, "Suco Africano Damasco CERES", dataInsert);
            adicionarProduto(515, 19, 3, "Suco Africano de Lichia CERES", dataInsert);
            adicionarProduto(516, 19, 3, "Suco Africano de Manga e Laranja CERES", dataInsert);
            adicionarProduto(517, 19, 3, "Suco Africano de Mistura de Frutas CERES", dataInsert);
            adicionarProduto(518, 19, 3, "Suco Africano de Pêssego CERES", dataInsert);
            adicionarProduto(519, 19, 3, "Suco Africano de Pêssego e Maracujá CERES", dataInsert);
            adicionarProduto(520, 19, 3, "Suco Africano Marula CERES", dataInsert);
            adicionarProduto(521, 19, 3, "Suco Americano Bloody Mary Mix TABASCO", dataInsert);
            adicionarProduto(522, 19, 3, "Suco Americano Com Vegetais V8", dataInsert);
            adicionarProduto(523, 19, 3, "Suco Americano de Tomate CAMPBELLS", dataInsert);
            adicionarProduto(524, 19, 3, "Suco de Abacaxi com Iogurte Molico Light NESTLÉ", dataInsert);
            adicionarProduto(525, 19, 3, "Suco de Abacaxi KAPO", dataInsert);
            adicionarProduto(526, 19, 3, "Suco de Ameixa, envasado", dataInsert);
            adicionarProduto(527, 19, 3, "Suco de Caju MAGUARY", dataInsert);
            adicionarProduto(528, 19, 3, "Suco de Caju MAIS", dataInsert);
            adicionarProduto(529, 19, 3, "Suco de Frutas Cítricas SKINKA", dataInsert);
            adicionarProduto(530, 19, 3, "Suco de Frutas Tropicais INDAIA", dataInsert);
            adicionarProduto(531, 19, 3, "Suco de Frutas Vermelhas SKINKA", dataInsert);
            adicionarProduto(532, 19, 3, "Suco de Frutas, industrializado", dataInsert);
            adicionarProduto(533, 19, 3, "Suco de Goiaba MAIS", dataInsert);
            adicionarProduto(534, 19, 3, "Suco de Laranja com Açúcar FAST FRUIT", dataInsert);
            adicionarProduto(535, 19, 3, "Suco de Laranja DANONE", dataInsert);
            adicionarProduto(536, 19, 3, "Suco de Laranja DEL VALLE", dataInsert);
            adicionarProduto(537, 19, 3, "Suco de Laranja e Caju DEL VALLE", dataInsert);
            adicionarProduto(538, 19, 3, "Suco de Laranja FAST FRUIT", dataInsert);
            adicionarProduto(539, 19, 3, "Suco de Laranja FAST FRUIT Plus", dataInsert);
            adicionarProduto(540, 19, 3, "Suco de Laranja FAST FRUIT Triple", dataInsert);
            adicionarProduto(541, 19, 3, "Suco de Laranja FAZENDA BELA VISTA", dataInsert);
            adicionarProduto(542, 19, 3, "Suco de Laranja JANDAIA", dataInsert);
            adicionarProduto(543, 19, 3, "Suco de Laranja KAPO", dataInsert);
            adicionarProduto(544, 19, 3, "Suco de Laranja MAIS", dataInsert);
            adicionarProduto(545, 19, 3, "Suco de Laranja SANTÁL", dataInsert);
            adicionarProduto(546, 19, 3, "Suco de Laranja, concentrado, enlatado", dataInsert);
            adicionarProduto(547, 19, 3, "Suco de Laranja, envasado", dataInsert);
            adicionarProduto(548, 19, 3, "Suco de Maça MAIS", dataInsert);
            adicionarProduto(549, 19, 3, "Suco de Maçã YAKULT", dataInsert);
            adicionarProduto(550, 19, 3, "Suco de Manga JANDAIA", dataInsert);
            adicionarProduto(551, 19, 3, "Suco de Manga MAIS", dataInsert);
            adicionarProduto(552, 19, 3, "Suco de Manga SANTÁL", dataInsert);
            adicionarProduto(553, 19, 3, "Suco de Maracujá com Iogurte Frutess NESTLÉ", dataInsert);
            adicionarProduto(554, 19, 3, "Suco de Maracujá JANDAIA", dataInsert);
            adicionarProduto(555, 19, 3, "Suco de Maracujá KAPO", dataInsert);
            adicionarProduto(556, 19, 3, "Suco de Maracujá MAIS", dataInsert);
            adicionarProduto(557, 19, 3, "Suco de Maracujá SANTÁL", dataInsert);
            adicionarProduto(558, 19, 3, "Suco de Morango KAPO", dataInsert);
            adicionarProduto(559, 19, 3, "Suco de Pêssego JANDAIA", dataInsert);
            adicionarProduto(560, 19, 3, "Suco de Pêssego MAIS", dataInsert);
            adicionarProduto(561, 19, 3, "Suco de Tomate, envasado", dataInsert);
            adicionarProduto(562, 19, 3, "Suco de Toranja, enlatado", dataInsert);
            adicionarProduto(563, 19, 3, "Suco de Uva JANDAIA", dataInsert);
            adicionarProduto(564, 19, 3, "Suco de Uva KAPO", dataInsert);
            adicionarProduto(565, 19, 3, "Suco de Uva MAIS", dataInsert);
            adicionarProduto(566, 19, 3, "Suco de Uva SANTÁL", dataInsert);
            adicionarProduto(567, 19, 3, "Suco DEL VALLE Abacaxi", dataInsert);
            adicionarProduto(568, 19, 3, "Suco DEL VALLE Caju", dataInsert);
            adicionarProduto(569, 19, 3, "Suco DEL VALLE Goiaba", dataInsert);
            adicionarProduto(570, 19, 3, "Suco DEL VALLE Laranja", dataInsert);
            adicionarProduto(571, 19, 3, "Suco DEL VALLE Light Caju", dataInsert);
            adicionarProduto(572, 19, 3, "Suco DEL VALLE Light Maçã", dataInsert);
            adicionarProduto(573, 19, 3, "Suco DEL VALLE Light Manga", dataInsert);
            adicionarProduto(574, 19, 3, "Suco DEL VALLE Light Maracujá", dataInsert);
            adicionarProduto(575, 19, 3, "Suco DEL VALLE Light Pêssego", dataInsert);
            adicionarProduto(576, 19, 3, "Suco DEL VALLE Light Uva", dataInsert);
            adicionarProduto(577, 19, 3, "Suco DEL VALLE Maçã", dataInsert);
            adicionarProduto(578, 19, 3, "Suco DEL VALLE Manga", dataInsert);
            adicionarProduto(579, 19, 3, "Suco DEL VALLE Maracujá", dataInsert);
            adicionarProduto(580, 19, 3, "Suco DEL VALLE Morango", dataInsert);
            adicionarProduto(581, 19, 3, "Suco DEL VALLE Pêssego", dataInsert);
            adicionarProduto(582, 19, 3, "Suco DEL VALLE Uva", dataInsert);
            adicionarProduto(583, 19, 3, "Suco Light MAGUARY Sabor Caju", dataInsert);
            adicionarProduto(584, 19, 3, "Suco Light MAIS Sabor Goiaba", dataInsert);
            adicionarProduto(585, 19, 3, "Suco Light MAIS Sabor Manga", dataInsert);
            adicionarProduto(586, 19, 3, "Suco Light MAIS Sabor Pêssego", dataInsert);
            adicionarProduto(587, 19, 3, "Suco Light MAIS Sabor Uva", dataInsert);
            adicionarProduto(588, 19, 3, "Suco Orgânico de Laranja com Acerola MARAU", dataInsert);
            adicionarProduto(589, 20, 3, "Água de Côco", dataInsert);
            adicionarProduto(590, 20, 3, "Caldo de Cana", dataInsert);
            adicionarProduto(591, 20, 3, "Suco de Abacaxi", dataInsert);
            adicionarProduto(592, 20, 3, "Suco de Açai", dataInsert);
            adicionarProduto(593, 20, 3, "Suco de Acerola", dataInsert);
            adicionarProduto(594, 20, 3, "Suco de Ameixa, envasado", dataInsert);
            adicionarProduto(595, 20, 3, "Suco de Carne de Boi", dataInsert);
            adicionarProduto(596, 20, 3, "Suco de Cenoura", dataInsert);
            adicionarProduto(597, 20, 3, "Suco de Framboesa", dataInsert);
            adicionarProduto(598, 20, 3, "Suco de Frutas, industrializado", dataInsert);
            adicionarProduto(599, 20, 3, "Suco de Grape Fruit", dataInsert);
            adicionarProduto(600, 20, 3, "Suco de Groselha", dataInsert);
            adicionarProduto(601, 20, 3, "Suco de Laranja, concentrado, enlatado", dataInsert);
            adicionarProduto(602, 20, 3, "Suco de Laranja, envasado", dataInsert);
            adicionarProduto(603, 20, 3, "Suco de Laranja, fresco", dataInsert);
            adicionarProduto(604, 20, 3, "Suco de Lima", dataInsert);
            adicionarProduto(605, 20, 3, "Suco de Maracujá", dataInsert);
            adicionarProduto(606, 20, 3, "Suco de Pêssego", dataInsert);
            adicionarProduto(607, 20, 3, "Suco de Romã", dataInsert);
            adicionarProduto(608, 20, 3, "Suco de Tangerina", dataInsert);
            adicionarProduto(609, 20, 3, "Suco de Tomate, envasado", dataInsert);
            adicionarProduto(610, 20, 3, "Suco de Tomate, fresco", dataInsert);
            adicionarProduto(611, 20, 3, "Suco de Toranja, concentrado", dataInsert);
            adicionarProduto(612, 20, 3, "Suco de Toranja, enlatado", dataInsert);
            adicionarProduto(613, 21, 3, "Suco Orgânico de Banana, Morango e Vegetais BETTA", dataInsert);
            adicionarProduto(614, 21, 3, "Suco Orgânico de Clorofila Drink BETTA", dataInsert);
            adicionarProduto(615, 21, 3, "Suco Orgânico de Guaraná e Limão VELLOX", dataInsert);
            adicionarProduto(616, 21, 3, "Suco Orgânico de Guaraná e Pêssego VELLOX", dataInsert);
            adicionarProduto(617, 21, 3, "Suco Orgânico de Guaraná VELLOX", dataInsert);
            adicionarProduto(618, 21, 3, "Suco Orgânico de Laranja com Acerola MARAU", dataInsert);
            adicionarProduto(619, 21, 3, "Suco Orgânico de Laranja FAST FRUIT Bio", dataInsert);
            adicionarProduto(620, 21, 3, "Suco Orgânico de Laranja MARAU", dataInsert);
            adicionarProduto(621, 21, 3, "Suco Orgânico de Laranja NATIVE", dataInsert);
            adicionarProduto(622, 21, 3, "Suco Orgânico de Manga MARAU", dataInsert);
            adicionarProduto(623, 21, 3, "Suco Orgânico de Maracujá MARAU", dataInsert);
            adicionarProduto(624, 21, 3, "Suco Orgânico Light VELLOX Sabor Guaraná", dataInsert);
        }

    }
}