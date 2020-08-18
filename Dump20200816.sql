CREATE DATABASE  IF NOT EXISTS `cef_db` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `cef_db`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: cef_db
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_agencias`
--

DROP TABLE IF EXISTS `tb_agencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_agencias` (
  `agencia` varchar(4) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `endereco` varchar(100) DEFAULT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `uf` varchar(2) DEFAULT NULL,
  `contato` varchar(20) DEFAULT NULL,
  `telefone1` varchar(15) DEFAULT NULL,
  `telefone2` varchar(15) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`agencia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_agencias`
--

LOCK TABLES `tb_agencias` WRITE;
/*!40000 ALTER TABLE `tb_agencias` DISABLE KEYS */;
INSERT INTO `tb_agencias` VALUES ('0287','BARIRI','RUA SETE DE SETEMBRO, 1006','','CENTRO','BARIRI','','SP','','(14) 3662-9140','','ag0287@caixa.gov.br'),('0315','JAÚ','RUA TENENTE LOPES, 215','','CENTRO','JAÚ','','','','(14) 3411-0200','','ag0315sp04@caixa.gov.br'),('0962','LENÇÓIS PAULISTA','RUA SÃO PAULO, 245','','VILA MAMEDINA','LENÇÓIS PAULISTA','','SP','','(14) 3269-1250','','ag0962sp03@caixa.gov.br'),('1920','QUATRO DE ABRIL','AVENIDA RIO BRANCO, 651','','CENTRO','MARÍLIA','','SP','','(14) 3414-9800','','ag1920@caixa.gov.br'),('2032','TERRA ROXA','AVENIDA IZALTINO DO AMARAL CARVALHO, 2149','','CH BELA VISTA','JAÚ','','SP','','(14) 3235-5750','','ag2032sp@caixa.gov.br'),('2141','ALTOS DA CIDADE','RUA GUSTAVO MACIEL, 24-14','','ALTOS DA CIDADE','BAURU','','SP','','(14) 2107-3250','','ag2141sp01@caixa.gov.br'),('3254','JOÃO RIBEIRO DE BARROS','RUA MARECHAL DEODORO, 839','','VILA NOVA','JAÚ','','SP','','(14) 2104-4200','','a3254sp@caixa.gov.br'),('3507','VILA FALCÃO','RUA OLEGARIO MACHADO QUADRA, 4-19','','VILA SOUTO','BAURU','','SP','','(14) 3233-2500','','ag3507sp01@caixa.gov.br'),('4078','NAÇÕES UNIDAS','AVENIDA NAÇÕES UNIDAS, 27-72','','VILA UNIVERSITÁRIA','BAURU','','SP','','(14) 2109-9800','','ag4078@caixa.gov.br'),('4210','JARDIM REDENTOR','AV CRUZEIRO DO SUL, 30-30','','JARDIM REDENTOR','BAURU','','SP','','(14) 3103-0500','','ag4210sp@caixa.gov.br'),('6992','HABITAÇÃO BAURU','AV GETULIO VARGAS, 20-105','','VILA AVIAÇÃO','BAURU','','SP','','(14) 3104-2750','','gihabbu06@caixa.gov.br');
/*!40000 ALTER TABLE `tb_agencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_atividades`
--

DROP TABLE IF EXISTS `tb_atividades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_atividades` (
  `codigo` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `descricao` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `valor_atividade` decimal(10,2) NOT NULL,
  `valor_deslocamento` decimal(10,2) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_atividades`
--

LOCK TABLES `tb_atividades` WRITE;
/*!40000 ALTER TABLE `tb_atividades` DISABLE KEYS */;
INSERT INTO `tb_atividades` VALUES ('A413',' AVALIAÇÃO VISTORIA PESQ MERC EST VEL VENDAS IM URB',430.00,37.00),('B438','AN PROJ UNIDADE ISOLADA COM AVALIAÇÃO IMÓVEL',923.00,37.00),('E401','AC IMÓVEL URBANO (CONSTRUÇÃO, AMPLIAÇÃO OU REFORMA)',369.00,37.00);
/*!40000 ALTER TABLE `tb_atividades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_dadoscadastrais`
--

DROP TABLE IF EXISTS `tb_dadoscadastrais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_dadoscadastrais` (
  `codigo` int(1) NOT NULL AUTO_INCREMENT,
  `cnpj` varchar(18) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `fantasia` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `razao` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `ie` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `im` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `endereco` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `complemento` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `bairro` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `cidade` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `cep` varchar(9) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `uf` varchar(2) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `constituicao` date DEFAULT NULL,
  `telefone` varchar(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `telefone2` varchar(15) DEFAULT NULL,
  `email` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `db_banco` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `db_tipo` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `db_agencia` varchar(6) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `db_operador` varchar(3) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `db_conta` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `ct_tomador` varchar(100) DEFAULT NULL,
  `ct_edital` varchar(50) DEFAULT NULL,
  `ct_contrato` varchar(50) DEFAULT NULL,
  `ct_celebrado` date DEFAULT NULL,
  `ct_inicio` date DEFAULT NULL,
  `ct_termino` date DEFAULT NULL,
  `logotipo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_dadoscadastrais`
--

LOCK TABLES `tb_dadoscadastrais` WRITE;
/*!40000 ALTER TABLE `tb_dadoscadastrais` DISABLE KEYS */;
INSERT INTO `tb_dadoscadastrais` VALUES (1,'35.367.026/0001-57','AYÊ ARQUITETURA','FELIPE FERREIRA GANDRA ARQUITETURA','ISENTO','591052','RUA VIRGÍLIO MALTA, 17-76','SALA 55','VILA MESQUITA','BAURU','17014-440','SP','2019-10-29','(14) 3245-7767','(14) 99132-7463','aye@ayearquitetura.com.br','CAIXA ECONÔMICA FEDERAL','Conta Corrente de Pessoa Jurídica','4184','003','1115-8','Caixa Econômica Federal','2528/2019','7062.01.2528.552/2019','2020-03-17','2020-03-17','2025-04-17','D:\\repos\\Arqueng\\Arqueng\\bin\\Debug\\logoaye.png');
/*!40000 ALTER TABLE `tb_dadoscadastrais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_fatura`
--

DROP TABLE IF EXISTS `tb_fatura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_fatura` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(20) DEFAULT NULL,
  `data` date DEFAULT NULL,
  `subtotal_os` decimal(10,2) DEFAULT NULL,
  `subtotal_desloc` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `rrtart` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_fatura`
--

LOCK TABLES `tb_fatura` WRITE;
/*!40000 ALTER TABLE `tb_fatura` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_fatura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_os`
--

DROP TABLE IF EXISTS `tb_os`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_os` (
  `referencia` varchar(33) CHARACTER SET latin1 COLLATE latin1_bin NOT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `data_ordem` date DEFAULT NULL,
  `prazo_execucao` date DEFAULT NULL,
  `profissional_cod` varchar(3) CHARACTER SET latin1 COLLATE latin1_bin DEFAULT NULL,
  `atividade_cod` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `siopi` tinyint(1) DEFAULT NULL,
  `nome_cliente` varchar(100) CHARACTER SET latin1 COLLATE latin1_bin DEFAULT NULL,
  `cidade` varchar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `nome_contato` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `telefone_contato` varchar(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `status` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `data_pendente` date DEFAULT NULL,
  `data_vistoria` date DEFAULT NULL,
  `data_concluida` date DEFAULT NULL,
  `obs` varchar(250) CHARACTER SET latin1 COLLATE latin1_bin DEFAULT NULL,
  `fatura_cod` int(11) DEFAULT '0',
  PRIMARY KEY (`referencia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_os`
--

LOCK TABLES `tb_os` WRITE;
/*!40000 ALTER TABLE `tb_os` DISABLE KEYS */;
INSERT INTO `tb_os` VALUES ('6992.0287.000320870/2020.01.01.01','BARIRI-320870','2020-06-08','2020-06-13','A01','E401',1,'ZILDA DE FATIMA FERREIRA PREVIDE','BARIRI','NILSON','(14) 99615-6265','CONCLUÍDA','2020-06-19','2020-06-10','2020-06-11','',0),('6992.0287.000355982/2020.01.01.01','E401-BARIRI-355982','2020-06-23','2020-06-28','E01','E401',1,'ANTONIO CARLOS BUDIN','BARIRI','ANTONIO','(14) 99823-5167','PENDENTE','2020-07-07','2020-07-07','2020-07-07','',0),('6992.0962.000382818/2020.01.01.01','E401-L. PAULISTA-382818','2020-07-03','2020-07-08','E01','E401',1,'GUILHERME DE OLIVEIRA RAPHAELI','L. PAULISTA','GUILHERME','(14) 99617-6714','CONCLUÍDA','2020-07-06','2020-07-06','2020-07-06','',0),('6992.1920.000342453/2020.01.01.01','E401-MARÍLIA-342453','2020-06-17','2020-06-22','E01','E401',1,'MIRIAN DUTRA GUERREIRO','MARÍLIA','JOÃO','(14) 99849-9899','RECEBIDA','2020-06-22','2020-06-22','2020-06-22','',0),('6992.2032.000344975/2020.01.01.01','E401-JAÚ-344975','2020-06-18','2020-06-23','E01','E401',1,'JAQUELINE MARCELO DA CUNHA','JAÚ','PIVETA','(14) 99789-3146','CONCLUÍDA','2020-07-07','2020-07-07','2020-07-07','',0),('6992.2032.000378519/2020.01.01.01','E401-JAÚ-378519','2020-07-02','2020-07-07','A01','E401',1,'FLAVIO HENRIQUE WITT DE OLIVEIRA','JAÚ','MARIA LUIZA','(14) 99608-7632','RECEBIDA','2020-07-07','2020-07-07','2020-07-07','',0),('6992.2141.000356615/2020.01.01.01','E401-BAURU-356615','2020-06-23','2020-06-28','E01','E401',1,'EUZEBIO RUIZ ARRUDA','BAURU','RUBENS','(14) 99855-4009','CONCLUÍDA','2020-07-07','2020-07-07','2020-07-07','',0),('6992.3507.000323929/2020.01.01.01','E401-BAURU-323929','2020-06-09','2020-06-14','A01','E401',1,'LEONARDO APARECIDO DA SILVA','BAURU','FERNANDO','(14) 99789-4468','VISTORIADA','2020-06-19','2020-06-15','2020-06-15','',0),('6992.3507.000376309/2020.01.01.01','BAURU-376309','2020-07-01','2020-07-07','A01','E401',1,'LUCAS FERNANDO GONÇALVES','BAURU','LUCAS','(14) 99832-1961','CONCLUÍDA','2020-07-07','2020-07-07','2020-07-07','',0),('6992.4078.000302623/2020.01.01.01','E401-BAURU-302623','2020-05-29','2020-06-03','A01','E401',1,'LUIZ GUSTAVO NASCIMENTO','BAURU','LUIZ GUSTAVO','(14) 99668-3486','RECEBIDA','2020-06-19','2020-06-03','2020-06-03','',0),('6992.4078.003111181/2020.01.01.01','PIRATININGA-3111181','2020-06-03','2020-06-08','A01','A401',1,'FABIO DO CARMO GANASSIN','PIRATININGA','MARCIO','(14) 99171-2010','CONCLUÍDA','2020-06-19','2020-06-08','2020-06-08','',0),('6992.6992.000366847/2020.01.01.01','BAURU-366847','2020-06-26','2020-07-02','A01','E401',0,'JOSE ANISIO FORATO','BAURU','JOSE FORATO','(14) 9982-0462','CONCLUÍDA','2020-07-07','2020-07-07','2020-07-07','Chamado: 79246',0);
/*!40000 ALTER TABLE `tb_os` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_profissionais`
--

DROP TABLE IF EXISTS `tb_profissionais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_profissionais` (
  `codigo` varchar(3) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `nomeid` varchar(100) DEFAULT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `nascimento` date DEFAULT NULL,
  `profissao` varchar(100) DEFAULT NULL,
  `carteira` varchar(100) DEFAULT NULL,
  `entidade` varchar(100) DEFAULT NULL,
  `telefone1` varchar(15) DEFAULT NULL,
  `telefone2` varchar(15) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `rt` tinyint(1) DEFAULT '0',
  `rl` tinyint(1) DEFAULT '0',
  `usr_ativo` tinyint(1) DEFAULT '0',
  `usr_nome` varchar(40) DEFAULT NULL,
  `usr_senha` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_profissionais`
--

LOCK TABLES `tb_profissionais` WRITE;
/*!40000 ALTER TABLE `tb_profissionais` DISABLE KEYS */;
INSERT INTO `tb_profissionais` VALUES ('A01','FELIPE FERREIRA GANDRA','ARQ. FELIPE GANDRA','321.687.858-99','1984-03-01','ARQUITETO E URBANISTA','A63642-1','C.A.U. - CONSELHO DE ARQUITETURA E URBANISMO','(14) 99829-0103','(11) 4051-1688','felipe@ayearquitetura.com.br',1,1,1,'fgandraf','123456'),('E01','PAULO VITOR JANZON GODOY','ENG. PAULO GODOY','643.199.708-53','1955-01-01','ENGENHEIRO CIVIL','060.060.256-1','C.R.E.A. - CONSELHO DE ENGENHARIA E AGRONOMIA','(14) 99795-8035','','pvjgodoy@terra.com.br',1,0,0,'paulog','abcde');
/*!40000 ALTER TABLE `tb_profissionais` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-16 20:13:40
