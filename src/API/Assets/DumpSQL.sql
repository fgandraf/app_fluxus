CREATE DATABASE  IF NOT EXISTS `fluxus` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `fluxus`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: fluxus
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


DROP TABLE IF EXISTS `tb_agencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_agencias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
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
  PRIMARY KEY (`id`),
  UNIQUE KEY `agencia_UNIQUE` (`agencia`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


DROP TABLE IF EXISTS `tb_atividades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_atividades` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `descricao` varchar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `valor_atividade` decimal(10,2) NOT NULL,
  `valor_deslocamento` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_UNIQUE` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



DROP TABLE IF EXISTS `tb_dadoscadastrais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_dadoscadastrais` (
  `id` int(11) NOT NULL,
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
  `logo` mediumblob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;


DROP TABLE IF EXISTS `tb_os`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_os` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `referencia` varchar(33) CHARACTER SET latin1 COLLATE latin1_bin NOT NULL,
  `agencia` varchar(4) DEFAULT NULL,
  `titulo` varchar(150) DEFAULT NULL,
  `data_ordem` date DEFAULT NULL,
  `prazo_execucao` date DEFAULT NULL,
  `profissional_cod` varchar(3) DEFAULT NULL,
  `atividade_cod` varchar(10) DEFAULT NULL,
  `valor_atividade` decimal(10,2) NOT NULL,
  `valor_deslocamento` decimal(10,2) NOT NULL,
  `siopi` tinyint(1) DEFAULT NULL,
  `nome_cliente` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `nome_contato` varchar(100) DEFAULT NULL,
  `telefone_contato` varchar(15) DEFAULT NULL,
  `coordenada` varchar(40) DEFAULT NULL,
  `status` varchar(10) DEFAULT NULL,
  `data_pendente` date DEFAULT NULL,
  `data_vistoria` date DEFAULT NULL,
  `data_concluida` date DEFAULT NULL,
  `obs` text,
  `fatura_cod` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



DROP TABLE IF EXISTS `tb_profissionais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_profissionais` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_profissionais`
--

LOCK TABLES `tb_profissionais` WRITE;
/*!40000 ALTER TABLE `tb_profissionais` DISABLE KEYS */;
INSERT INTO `tb_profissionais` VALUES (1,'A01','FELIPE FERREIRA GANDRA','ARQ. FELIPE GANDRA','000.111.222-33','1984-03-01','ARQUITETO E URBANISTA','A00000-1','C.A.U. - CONSELHO DE ARQUITETURA E URBANISMO','(11) 99999-8888','(11) 4444-3333','email@gmail.com',1,1,1,'fgandraf','123456');
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

-- Dump completed on 2020-10-23 11:53:52
