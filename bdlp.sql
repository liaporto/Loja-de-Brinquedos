-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 15-Nov-2018 às 20:31
-- Versão do servidor: 5.7.17
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bdlp`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_brinquedo`
--

CREATE TABLE `tab_brinquedo` (
  `cod_brinquedo` int(11) NOT NULL,
  `nome_brinquedo` varchar(80) NOT NULL,
  `categoria` varchar(30) DEFAULT NULL,
  `faixa_etaria` varchar(7) DEFAULT NULL,
  `marca` varchar(20) NOT NULL,
  `data_ultimareposicao` date NOT NULL,
  `quantidade_em_estoque` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tab_brinquedo`
--

INSERT INTO `tab_brinquedo` (`cod_brinquedo`, `nome_brinquedo`, `categoria`, `faixa_etaria`, `marca`, `data_ultimareposicao`, `quantidade_em_estoque`) VALUES
(0, 'Barbie', 'Bonecos', '7-9', 'Mattel', '2017-05-21', 100),
(1, 'Sabre de Luz', 'Fantasias', '7-9', 'Disney', '2017-12-12', 118),
(4, 'Max Steel', 'Bonecos', '7-9', 'Mattel', '2017-12-19', 118),
(5, 'Massinha de Modelar', 'Artes e Atividades', 'Para to', 'Estrela', '2017-12-19', 120),
(6, 'Barbie', 'Bonecos', '4-6', 'Mattel', '2017-12-19', 120),
(7, 'Hot Wheels', 'Automóveis', '4-6', 'Hot Wheels', '2017-12-19', 120),
(8, 'Jenga', 'Jogos de Tabuleiro', 'Para to', 'Hasbro', '2017-12-19', 119),
(9, 'War', 'Jogos de Tabuleiro', '14+', 'Grow', '2017-12-19', 120),
(10, 'Cabeça de Batata', 'Bonecos', '4-6', 'Hasbro', '2017-12-19', 120),
(11, 'Genius', 'Quebra-Cabeças', 'Para to', 'Estrela', '2017-12-19', 120),
(12, 'Amoeba', 'Artes e Atividades', '7-9', 'Asca Toys', '2017-12-19', 120);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_cliente`
--

CREATE TABLE `tab_cliente` (
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `datanasc` date DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `tel_celular` varchar(15) DEFAULT NULL,
  `logradouro` varchar(200) DEFAULT NULL,
  `num_logradouro` varchar(6) DEFAULT NULL,
  `complemento` varchar(50) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tab_vendas_cliente`
--

CREATE TABLE `tab_vendas_cliente` (
  `cod_venda` int(11) NOT NULL,
  `FK_cpf_cliente` varchar(11) DEFAULT NULL,
  `FK_cod_produto` int(11) DEFAULT NULL,
  `data_venda` date NOT NULL,
  `quantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tab_brinquedo`
--
ALTER TABLE `tab_brinquedo`
  ADD PRIMARY KEY (`cod_brinquedo`);

--
-- Indexes for table `tab_cliente`
--
ALTER TABLE `tab_cliente`
  ADD PRIMARY KEY (`cpf`);

--
-- Indexes for table `tab_vendas_cliente`
--
ALTER TABLE `tab_vendas_cliente`
  ADD PRIMARY KEY (`cod_venda`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tab_brinquedo`
--
ALTER TABLE `tab_brinquedo`
  MODIFY `cod_brinquedo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `tab_vendas_cliente`
--
ALTER TABLE `tab_vendas_cliente`
  MODIFY `cod_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
