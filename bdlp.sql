-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tempo de Geração: Dez 20, 2017 as 11:48 PM
-- Versão do Servidor: 5.1.54
-- Versão do PHP: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Banco de Dados: `bdlp`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_brinquedo`
--

CREATE TABLE IF NOT EXISTS `tab_brinquedo` (
  `cod_brinquedo` int(11) NOT NULL AUTO_INCREMENT,
  `nome_brinquedo` varchar(100) NOT NULL,
  `categoria` varchar(30) DEFAULT NULL,
  `faixa_etaria` varchar(20) DEFAULT NULL,
  `marca` varchar(20) NOT NULL,
  `data_ultimareposicao` date DEFAULT NULL,
  `quantidade_em_estoque` int(11) DEFAULT NULL,
  PRIMARY KEY (`cod_brinquedo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Extraindo dados da tabela `tab_brinquedo`
--

INSERT INTO `tab_brinquedo` (`cod_brinquedo`, `nome_brinquedo`, `categoria`, `faixa_etaria`, `marca`, `data_ultimareposicao`, `quantidade_em_estoque`) VALUES
(1, 'Sabre de Luz', 'Fantasias', '7-9', 'Disney', '2017-12-12', 118),
(4, 'Max Steel', 'Bonecos', '7-9', 'Mattel', '2017-12-19', 118),
(5, 'Massinha de Modelar', 'Artes e Atividades', 'Para toda a família', 'Estrela', '2017-12-19', 120),
(6, 'Barbie', 'Bonecos', '4-6', 'Mattel', '2017-12-19', 120),
(7, 'Hot Wheels', 'Automóveis', '4-6', 'Hot Wheels', '2017-12-19', 120),
(8, 'Jenga', 'Jogos de Tabuleiro', 'Para toda a família', 'Hasbro', '2017-12-19', 119),
(9, 'War', 'Jogos de Tabuleiro', '14+', 'Grow', '2017-12-19', 120),
(10, 'Cabeça de Batata', 'Bonecos', '4-6', 'Hasbro', '2017-12-19', 120),
(11, 'Genius', 'Quebra-Cabeças', 'Para toda a família', 'Estrela', '2017-12-19', 120),
(12, 'Amoeba', 'Artes e Atividades', '7-9', 'Asca Toys', '2017-12-19', 120);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_cliente`
--

CREATE TABLE IF NOT EXISTS `tab_cliente` (
  `nome` varchar(100) DEFAULT NULL,
  `cpf` varchar(12) NOT NULL,
  `datanasc` date DEFAULT NULL,
  `email` varchar(80) DEFAULT NULL,
  `tel_celular` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tab_cliente`
--

INSERT INTO `tab_cliente` (`nome`, `cpf`, `datanasc`, `email`, `tel_celular`) VALUES
(' Luiza Costa Pacheco', '102945187-70', '2000-11-08', 'luizacpacheco@hotmail.com', '98135-9016'),
('João da Silva', '123456789-90', '2017-06-06', 'joaosilva@gmail.com', ' 12345-678'),
('Leonardo Corais', '132569874-45', '2001-05-17', 'leotroco@gmail.com', '99568-0991'),
(' Bianca di Gandolpho', '142355588-96', '2000-10-12', 'begandolpho@gmail.com', ' 96523-125'),
(' Bianca Montalvão', '164382377-95', '2001-04-20', 'bbmonts@gmail.com', ' 97678-511'),
('Eduarda Valmor', '165453077-89', '2000-02-07', 'hgcjshdydsf@jvfhf.com', '36987-4521'),
(' Paulo Roberto', '364634660-12', '2017-12-20', 'auauaua@aml.com', '12998-5361'),
(' Tai Porto', '398137428-28', '2001-04-23', 'tai.dporto@outlook.com', '99438-1079');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_vendas_cliente`
--

CREATE TABLE IF NOT EXISTS `tab_vendas_cliente` (
  `cod_venda` int(11) NOT NULL AUTO_INCREMENT,
  `FK_cpf_cliente` varchar(13) DEFAULT NULL,
  `FK_cod_produto` int(11) DEFAULT NULL,
  `data_venda` date NOT NULL,
  `quantidade` int(11) NOT NULL,
  PRIMARY KEY (`cod_venda`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Extraindo dados da tabela `tab_vendas_cliente`
--

INSERT INTO `tab_vendas_cliente` (`cod_venda`, `FK_cpf_cliente`, `FK_cod_produto`, `data_venda`, `quantidade`) VALUES
(1, '398137428-28', 1, '2017-12-19', 1),
(2, '398137428-28', 4, '2017-12-19', 2),
(3, '165453077-89', 7, '2017-12-19', 5),
(4, '165453077-89', 10, '2017-12-19', 5),
(5, '165453077-89', 12, '2017-12-19', 5),
(6, '123456789-90', 8, '2017-12-20', 1);
