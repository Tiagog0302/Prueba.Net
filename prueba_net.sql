-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-06-2022 a las 01:03:48
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `prueba.net`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `hr_departamento`
--

CREATE TABLE `hr_departamento` (
  `id` int(11) NOT NULL,
  `cod_empresa` varchar(2) NOT NULL,
  `cod_departamento` varchar(16) NOT NULL,
  `nombre` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `hr_departamento`
--

INSERT INTO `hr_departamento` (`id`, `cod_empresa`, `cod_departamento`, `nombre`) VALUES
(1, '1', '1', 'ADAM'),
(2, '2', '2', 'Medellin'),
(3, '1', '2', 'ADAM'),
(5, '1', '3', 'ADAM'),
(6, '1', '4', 'ADAM');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `hr_pago`
--

CREATE TABLE `hr_pago` (
  `id` int(11) NOT NULL,
  `codigo` int(11) NOT NULL,
  `cod_empresa` varchar(2) NOT NULL,
  `cod_rubro_pago` varchar(32) NOT NULL,
  `resultado` double(18,6) NOT NULL,
  `fecha_pago` date NOT NULL,
  `cod_departamento` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `hr_pago`
--

INSERT INTO `hr_pago` (`id`, `codigo`, `cod_empresa`, `cod_rubro_pago`, `resultado`, `fecha_pago`, `cod_departamento`) VALUES
(1, 1, '1', '1', 1.000000, '2022-06-04', '1');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `hr_departamento`
--
ALTER TABLE `hr_departamento`
  ADD PRIMARY KEY (`id`,`cod_empresa`,`cod_departamento`),
  ADD KEY `cod_departamento` (`cod_departamento`);

--
-- Indices de la tabla `hr_pago`
--
ALTER TABLE `hr_pago`
  ADD PRIMARY KEY (`id`,`codigo`,`cod_empresa`),
  ADD KEY `cod_departamento` (`cod_departamento`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `hr_departamento`
--
ALTER TABLE `hr_departamento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `hr_pago`
--
ALTER TABLE `hr_pago`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `hr_pago`
--
ALTER TABLE `hr_pago`
  ADD CONSTRAINT `hr_pago_ibfk_1` FOREIGN KEY (`cod_departamento`) REFERENCES `hr_departamento` (`cod_departamento`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
