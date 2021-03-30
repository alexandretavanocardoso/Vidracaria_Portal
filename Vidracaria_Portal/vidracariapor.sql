-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 30-Mar-2021 às 02:58
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `vidracariaportal`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `adesivos`
--

CREATE TABLE `adesivos` (
  `CodigoAdesivo` int(11) NOT NULL,
  `Nome` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `adesivos`
--

INSERT INTO `adesivos` (`CodigoAdesivo`, `Nome`) VALUES
(1, ' '),
(2, 'Vermelho'),
(3, 'Preto'),
(4, 'Branco'),
(5, 'Dourado'),
(6, 'Amarelo'),
(7, 'Prata'),
(8, 'Cinza'),
(9, 'Verde'),
(10, 'Alumínio'),
(11, 'Azul');

-- --------------------------------------------------------

--
-- Estrutura da tabela `agenda`
--

CREATE TABLE `agenda` (
  `CodigoAgenda` int(11) NOT NULL,
  `Texto` text NOT NULL,
  `Assunto` text DEFAULT NULL,
  `DataCadastro` datetime DEFAULT NULL,
  `DataLimite` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aluminios`
--

CREATE TABLE `aluminios` (
  `CodigoAluminio` int(11) NOT NULL,
  `NomeAluminio` varchar(100) NOT NULL,
  `CorId` int(11) NOT NULL,
  `Marca` varchar(100) DEFAULT NULL,
  `EstoqueMaximo` int(11) NOT NULL,
  `EstoqueMinimo` int(11) NOT NULL,
  `PrecoVenda` decimal(18,2) NOT NULL,
  `PrecoFabrica` decimal(18,2) NOT NULL,
  `Imagem` varchar(300) DEFAULT NULL,
  `DataCadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aprovados`
--

CREATE TABLE `aprovados` (
  `CodigoAprovado` int(11) NOT NULL,
  `CodigoOrcamento` int(11) NOT NULL,
  `Nome` varchar(70) DEFAULT NULL,
  `Rua` varchar(80) DEFAULT NULL,
  `NumeroCasa` int(11) NOT NULL,
  `Cidade` varchar(80) DEFAULT NULL,
  `Bairro` varchar(80) DEFAULT NULL,
  `Celular` varchar(20) DEFAULT NULL,
  `Telefone` varchar(20) DEFAULT NULL,
  `Estado` varchar(80) DEFAULT NULL,
  `TipoId` int(11) NOT NULL,
  `TipoServicoCodigoTipo` int(11) DEFAULT NULL,
  `DataCadastro` datetime NOT NULL,
  `Imagem` text DEFAULT NULL,
  `Valor` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(85) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(85) DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `aspnetroles`
--

INSERT INTO `aspnetroles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
('5327a433-2ea0-46bf-9aae-c771f98c577d', 'Administrador', 'ADMINISTRADOR', '90f71724-5474-4591-973f-aa0a5a5a41c7'),
('691f9138-81b5-4b90-bfa3-38a97d7a1aea', 'Cliente', 'CLIENTE', '4cc65901-4d12-498d-a250-b06e92d86436');

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(85) NOT NULL,
  `ClaimType` text DEFAULT NULL,
  `ClaimValue` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(85) NOT NULL,
  `ProviderKey` varchar(85) NOT NULL,
  `ProviderDisplayName` text DEFAULT NULL,
  `UserId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(85) NOT NULL,
  `RoleId` varchar(85) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `aspnetuserroles`
--

INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`) VALUES
('74f6179f-cc12-4ed0-ad7f-5007160434dd', '691f9138-81b5-4b90-bfa3-38a97d7a1aea'),
('ec9ee7ae-f1c3-45dd-9ee6-ddc161afa53d', '5327a433-2ea0-46bf-9aae-c771f98c577d');

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(85) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(85) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(85) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` text DEFAULT NULL,
  `SecurityStamp` text DEFAULT NULL,
  `ConcurrencyStamp` text DEFAULT NULL,
  `PhoneNumber` text DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `Nome`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('74f6179f-cc12-4ed0-ad7f-5007160434dd', 'Alexandre', 'tavanoalexandre@outlook.com', 'TAVANOALEXANDRE@OUTLOOK.COM', 'tavanoalexandre@outlook.com', 'TAVANOALEXANDRE@OUTLOOK.COM', 1, 'AQAAAAEAACcQAAAAEBkuQMj+TetzM6ijyHrJy3bT92YfKHzT5lzeMnpo49Mf/Jl5iF13lCKnlneBob7b2w==', '6151694', '17539e7b-9eee-47ce-9296-eea102db125a', NULL, 0, 0, NULL, 0, 0),
('ec9ee7ae-f1c3-45dd-9ee6-ddc161afa53d', 'Admin', 'admin@vidracariaportal.com.br', 'ADMIN@VIDRACARIAPORTAL.COM.BR', 'admin@vidracariaportal.com.br', 'ADMIN@VIDRACARIAPORTAL.COM.BR', 1, 'AQAAAAEAACcQAAAAEN01F8pOHjTE7msmiVuwhXEqC9N5rQvI5aE1amviPHfzFj+dM06Puuh3Uqm3HT7f8w==', '37966223', '85f6c8ad-f2b1-4218-a228-169f248d6791', NULL, 0, 0, NULL, 0, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(85) NOT NULL,
  `LoginProvider` varchar(85) NOT NULL,
  `Name` varchar(85) NOT NULL,
  `Value` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `CodigoCliente` int(11) NOT NULL,
  `NomeCliente` varchar(70) NOT NULL,
  `Email` text DEFAULT NULL,
  `CidadeCliente` varchar(80) NOT NULL,
  `Bairro` varchar(80) NOT NULL,
  `NumeroCasa` int(11) NOT NULL,
  `EstadoCliente` varchar(80) NOT NULL,
  `Celular` varchar(20) NOT NULL,
  `Documento` varchar(20) DEFAULT NULL,
  `DataCadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `concluidos`
--

CREATE TABLE `concluidos` (
  `CodigoConcluido` int(11) NOT NULL,
  `CodigoAprovados` int(11) NOT NULL,
  `CodigoOrcamento` int(11) NOT NULL,
  `Nome` varchar(70) DEFAULT NULL,
  `Rua` varchar(80) DEFAULT NULL,
  `NumeroCasa` int(11) NOT NULL,
  `Cidade` varchar(80) DEFAULT NULL,
  `Bairro` varchar(80) DEFAULT NULL,
  `Celular` varchar(20) DEFAULT NULL,
  `Telefone` varchar(20) DEFAULT NULL,
  `Estado` varchar(80) DEFAULT NULL,
  `TipoId` int(11) NOT NULL,
  `TipoServicoCodigoTipo` int(11) DEFAULT NULL,
  `DataCadastro` datetime NOT NULL,
  `Imagem` text DEFAULT NULL,
  `Valor` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `contatos`
--

CREATE TABLE `contatos` (
  `CodigoContato` int(11) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Assunto` varchar(100) NOT NULL,
  `Mensagem` varchar(500) NOT NULL,
  `Retorno` varchar(500) DEFAULT NULL,
  `DataContato` datetime NOT NULL,
  `DataRetorno` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cores`
--

CREATE TABLE `cores` (
  `CodigoCor` int(11) NOT NULL,
  `NomeCor` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cores`
--

INSERT INTO `cores` (`CodigoCor`, `NomeCor`) VALUES
(1, ' '),
(2, 'Vermelho'),
(3, 'Preto'),
(4, 'Branco'),
(5, 'Dourado'),
(6, 'Amarelo'),
(7, 'Prata'),
(8, 'Cinza'),
(9, 'Verde'),
(10, 'Alumínio'),
(11, 'Azul');

-- --------------------------------------------------------

--
-- Estrutura da tabela `expessura`
--

CREATE TABLE `expessura` (
  `CodigoExpessura` int(11) NOT NULL,
  `Expessura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `expessura`
--

INSERT INTO `expessura` (`CodigoExpessura`, `Expessura`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10),
(11, 11),
(12, 12),
(13, 13),
(14, 14),
(15, 15),
(16, 16),
(17, 17),
(18, 18),
(19, 19),
(20, 20);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ferragens`
--

CREATE TABLE `ferragens` (
  `CodigoFerragem` int(11) NOT NULL,
  `NomeFerragem` varchar(70) NOT NULL,
  `CorId` int(11) NOT NULL,
  `Marca` varchar(70) DEFAULT NULL,
  `EstoqueMaximo` int(11) NOT NULL,
  `EstoqueMinimo` int(11) NOT NULL,
  `PrecoVenda` decimal(18,2) NOT NULL,
  `PrecoFabrica` decimal(18,2) NOT NULL,
  `Imagem` varchar(300) DEFAULT NULL,
  `DataCadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `galeria`
--

CREATE TABLE `galeria` (
  `CodigoGaleria` int(11) NOT NULL,
  `Imagem` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `nosso_time`
--

CREATE TABLE `nosso_time` (
  `CodigoTIme` int(11) NOT NULL,
  `NomeTime` text DEFAULT NULL,
  `Cargo` text DEFAULT NULL,
  `Imagem` text DEFAULT NULL,
  `LinkFacebook` text DEFAULT NULL,
  `LinkImagem` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `orcamentos`
--

CREATE TABLE `orcamentos` (
  `CodigoOrcamento` int(11) NOT NULL,
  `Nome` varchar(70) DEFAULT NULL,
  `Rua` varchar(80) DEFAULT NULL,
  `NumeroCasa` int(11) NOT NULL,
  `Cidade` varchar(80) DEFAULT NULL,
  `Bairro` varchar(80) DEFAULT NULL,
  `Celular` varchar(20) DEFAULT NULL,
  `Telefone` varchar(20) DEFAULT NULL,
  `Estado` varchar(80) DEFAULT NULL,
  `TipoId` int(11) NOT NULL,
  `TipoServicoCodigoTipo` int(11) DEFAULT NULL,
  `DataCadastro` datetime NOT NULL,
  `Imagem` text DEFAULT NULL,
  `Valor` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `peliculas`
--

CREATE TABLE `peliculas` (
  `CodigoPelicula` int(11) NOT NULL,
  `Nome` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `peliculas`
--

INSERT INTO `peliculas` (`CodigoPelicula`, `Nome`) VALUES
(1, ' '),
(2, 'Jateada'),
(3, 'preto'),
(4, 'Incolor'),
(5, 'Dourado'),
(6, 'Amarelo'),
(7, 'Prata'),
(8, 'Cinza'),
(9, 'Verde'),
(10, 'Alumínio'),
(11, 'Azul');

-- --------------------------------------------------------

--
-- Estrutura da tabela `servicos`
--

CREATE TABLE `servicos` (
  `CodigoServico` int(11) NOT NULL,
  `NomeServico` text DEFAULT NULL,
  `Imagem` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipos_de_servicos`
--

CREATE TABLE `tipos_de_servicos` (
  `CodigoTipo` int(11) NOT NULL,
  `Tipo` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tipos_de_servicos`
--

INSERT INTO `tipos_de_servicos` (`CodigoTipo`, `Tipo`) VALUES
(1, 'Espelho'),
(2, 'Aquário'),
(3, 'Bascultante'),
(4, 'Box de Acrílico'),
(5, 'Box de Vidro'),
(6, 'Corrimão de Alumínio'),
(7, 'Divisória de Eucatex'),
(8, 'Esquadria de Alumínio'),
(9, 'Forro PVC'),
(10, 'Gaveteiro de Alumínio'),
(11, 'Guarda Corpo'),
(12, 'Janela de Vidro'),
(13, 'Kit Pia'),
(14, 'Vidro de Mesa'),
(15, 'Persiana Vertical'),
(16, 'Persiana Horizontal'),
(17, 'Portal com Adesivo'),
(18, 'Porta com Película'),
(19, 'Porta de Alumínio'),
(20, 'Portão de Alumínio'),
(21, 'Porta de Acrílico'),
(22, 'Porta de Vidro'),
(23, 'Porta Pivotante'),
(24, 'Prateleira de Vidro'),
(25, 'Quadro com Moldura'),
(26, 'Tela Mosqueteira'),
(27, 'Toldo'),
(28, 'Vidro Comum'),
(29, 'Portas Automatizadas'),
(30, 'Porta Sanfonadas'),
(31, 'Espelho Bisotê'),
(32, '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `vidros_comuns`
--

CREATE TABLE `vidros_comuns` (
  `CodigoVidro` int(11) NOT NULL,
  `NomeVidro` varchar(70) NOT NULL,
  `AdesivoId` int(11) NOT NULL,
  `PeliculaId` int(11) NOT NULL,
  `ExpessuraId` int(11) NOT NULL,
  `Marca` varchar(70) DEFAULT NULL,
  `EstoqueMaximo` decimal(18,2) NOT NULL,
  `EstoqueMinimo` decimal(18,2) NOT NULL,
  `PrecoVenda` decimal(18,2) NOT NULL,
  `PrecoFabrica` decimal(18,2) NOT NULL,
  `Imagem` varchar(300) DEFAULT NULL,
  `DataCadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `vidros_temperados`
--

CREATE TABLE `vidros_temperados` (
  `CodigoVidro` int(11) NOT NULL,
  `NomeVidro` varchar(70) NOT NULL,
  `AdesivoId` int(11) NOT NULL,
  `PeliculaId` int(11) NOT NULL,
  `ExpessuraId` int(11) NOT NULL,
  `Marca` varchar(70) DEFAULT NULL,
  `EstoqueMaximo` int(11) NOT NULL,
  `EstoqueMinimo` int(11) NOT NULL,
  `PrecoVenda` decimal(18,2) NOT NULL,
  `PrecoFabrica` decimal(18,2) NOT NULL,
  `Imagem` varchar(300) DEFAULT NULL,
  `DataCadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20210330003043_Ajuste_01', '5.0.4'),
('20210330005648_Initial', '5.0.4');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `adesivos`
--
ALTER TABLE `adesivos`
  ADD PRIMARY KEY (`CodigoAdesivo`);

--
-- Índices para tabela `agenda`
--
ALTER TABLE `agenda`
  ADD PRIMARY KEY (`CodigoAgenda`);

--
-- Índices para tabela `aluminios`
--
ALTER TABLE `aluminios`
  ADD PRIMARY KEY (`CodigoAluminio`),
  ADD KEY `IX_ALUMINIOS_CorId` (`CorId`);

--
-- Índices para tabela `aprovados`
--
ALTER TABLE `aprovados`
  ADD PRIMARY KEY (`CodigoAprovado`),
  ADD KEY `IX_APROVADOS_TipoServicoCodigoTipo` (`TipoServicoCodigoTipo`);

--
-- Índices para tabela `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Índices para tabela `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Índices para tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Índices para tabela `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Índices para tabela `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Índices para tabela `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Índices para tabela `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`CodigoCliente`);

--
-- Índices para tabela `concluidos`
--
ALTER TABLE `concluidos`
  ADD PRIMARY KEY (`CodigoConcluido`),
  ADD KEY `IX_CONCLUIDOS_TipoServicoCodigoTipo` (`TipoServicoCodigoTipo`);

--
-- Índices para tabela `contatos`
--
ALTER TABLE `contatos`
  ADD PRIMARY KEY (`CodigoContato`);

--
-- Índices para tabela `cores`
--
ALTER TABLE `cores`
  ADD PRIMARY KEY (`CodigoCor`);

--
-- Índices para tabela `expessura`
--
ALTER TABLE `expessura`
  ADD PRIMARY KEY (`CodigoExpessura`);

--
-- Índices para tabela `ferragens`
--
ALTER TABLE `ferragens`
  ADD PRIMARY KEY (`CodigoFerragem`),
  ADD KEY `IX_FERRAGENS_CorId` (`CorId`);

--
-- Índices para tabela `galeria`
--
ALTER TABLE `galeria`
  ADD PRIMARY KEY (`CodigoGaleria`);

--
-- Índices para tabela `nosso_time`
--
ALTER TABLE `nosso_time`
  ADD PRIMARY KEY (`CodigoTIme`);

--
-- Índices para tabela `orcamentos`
--
ALTER TABLE `orcamentos`
  ADD PRIMARY KEY (`CodigoOrcamento`),
  ADD KEY `IX_ORCAMENTOS_TipoServicoCodigoTipo` (`TipoServicoCodigoTipo`);

--
-- Índices para tabela `peliculas`
--
ALTER TABLE `peliculas`
  ADD PRIMARY KEY (`CodigoPelicula`);

--
-- Índices para tabela `servicos`
--
ALTER TABLE `servicos`
  ADD PRIMARY KEY (`CodigoServico`);

--
-- Índices para tabela `tipos_de_servicos`
--
ALTER TABLE `tipos_de_servicos`
  ADD PRIMARY KEY (`CodigoTipo`);

--
-- Índices para tabela `vidros_comuns`
--
ALTER TABLE `vidros_comuns`
  ADD PRIMARY KEY (`CodigoVidro`),
  ADD KEY `IX_VIDROS_COMUNS_AdesivoId` (`AdesivoId`),
  ADD KEY `IX_VIDROS_COMUNS_ExpessuraId` (`ExpessuraId`),
  ADD KEY `IX_VIDROS_COMUNS_PeliculaId` (`PeliculaId`);

--
-- Índices para tabela `vidros_temperados`
--
ALTER TABLE `vidros_temperados`
  ADD PRIMARY KEY (`CodigoVidro`),
  ADD KEY `IX_VIDROS_TEMPERADOS_AdesivoId` (`AdesivoId`),
  ADD KEY `IX_VIDROS_TEMPERADOS_ExpessuraId` (`ExpessuraId`),
  ADD KEY `IX_VIDROS_TEMPERADOS_PeliculaId` (`PeliculaId`);

--
-- Índices para tabela `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `adesivos`
--
ALTER TABLE `adesivos`
  MODIFY `CodigoAdesivo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `agenda`
--
ALTER TABLE `agenda`
  MODIFY `CodigoAgenda` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `aluminios`
--
ALTER TABLE `aluminios`
  MODIFY `CodigoAluminio` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `aprovados`
--
ALTER TABLE `aprovados`
  MODIFY `CodigoAprovado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `CodigoCliente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `concluidos`
--
ALTER TABLE `concluidos`
  MODIFY `CodigoConcluido` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `contatos`
--
ALTER TABLE `contatos`
  MODIFY `CodigoContato` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `cores`
--
ALTER TABLE `cores`
  MODIFY `CodigoCor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `expessura`
--
ALTER TABLE `expessura`
  MODIFY `CodigoExpessura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `ferragens`
--
ALTER TABLE `ferragens`
  MODIFY `CodigoFerragem` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `galeria`
--
ALTER TABLE `galeria`
  MODIFY `CodigoGaleria` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `nosso_time`
--
ALTER TABLE `nosso_time`
  MODIFY `CodigoTIme` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `orcamentos`
--
ALTER TABLE `orcamentos`
  MODIFY `CodigoOrcamento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `peliculas`
--
ALTER TABLE `peliculas`
  MODIFY `CodigoPelicula` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `servicos`
--
ALTER TABLE `servicos`
  MODIFY `CodigoServico` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tipos_de_servicos`
--
ALTER TABLE `tipos_de_servicos`
  MODIFY `CodigoTipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT de tabela `vidros_comuns`
--
ALTER TABLE `vidros_comuns`
  MODIFY `CodigoVidro` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `vidros_temperados`
--
ALTER TABLE `vidros_temperados`
  MODIFY `CodigoVidro` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `aluminios`
--
ALTER TABLE `aluminios`
  ADD CONSTRAINT `FK_ALUMINIOS_CORES_CorId` FOREIGN KEY (`CorId`) REFERENCES `cores` (`CodigoCor`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aprovados`
--
ALTER TABLE `aprovados`
  ADD CONSTRAINT `FK_APROVADOS_TIPOS_DE_SERVICOS_TipoServicoCodigoTipo` FOREIGN KEY (`TipoServicoCodigoTipo`) REFERENCES `tipos_de_servicos` (`CodigoTipo`);

--
-- Limitadores para a tabela `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `concluidos`
--
ALTER TABLE `concluidos`
  ADD CONSTRAINT `FK_CONCLUIDOS_TIPOS_DE_SERVICOS_TipoServicoCodigoTipo` FOREIGN KEY (`TipoServicoCodigoTipo`) REFERENCES `tipos_de_servicos` (`CodigoTipo`);

--
-- Limitadores para a tabela `ferragens`
--
ALTER TABLE `ferragens`
  ADD CONSTRAINT `FK_FERRAGENS_CORES_CorId` FOREIGN KEY (`CorId`) REFERENCES `cores` (`CodigoCor`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `orcamentos`
--
ALTER TABLE `orcamentos`
  ADD CONSTRAINT `FK_ORCAMENTOS_TIPOS_DE_SERVICOS_TipoServicoCodigoTipo` FOREIGN KEY (`TipoServicoCodigoTipo`) REFERENCES `tipos_de_servicos` (`CodigoTipo`);

--
-- Limitadores para a tabela `vidros_comuns`
--
ALTER TABLE `vidros_comuns`
  ADD CONSTRAINT `FK_VIDROS_COMUNS_ADESIVOS_AdesivoId` FOREIGN KEY (`AdesivoId`) REFERENCES `adesivos` (`CodigoAdesivo`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_VIDROS_COMUNS_EXPESSURA_ExpessuraId` FOREIGN KEY (`ExpessuraId`) REFERENCES `expessura` (`CodigoExpessura`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_VIDROS_COMUNS_PELICULAS_PeliculaId` FOREIGN KEY (`PeliculaId`) REFERENCES `peliculas` (`CodigoPelicula`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `vidros_temperados`
--
ALTER TABLE `vidros_temperados`
  ADD CONSTRAINT `FK_VIDROS_TEMPERADOS_ADESIVOS_AdesivoId` FOREIGN KEY (`AdesivoId`) REFERENCES `adesivos` (`CodigoAdesivo`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_VIDROS_TEMPERADOS_EXPESSURA_ExpessuraId` FOREIGN KEY (`ExpessuraId`) REFERENCES `expessura` (`CodigoExpessura`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_VIDROS_TEMPERADOS_PELICULAS_PeliculaId` FOREIGN KEY (`PeliculaId`) REFERENCES `peliculas` (`CodigoPelicula`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
