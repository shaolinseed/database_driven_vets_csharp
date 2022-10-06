-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 01, 2022 at 11:54 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.3.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `veterinary_centre`
--

-- --------------------------------------------------------

--
-- Table structure for table `addresses`
--

CREATE TABLE `addresses` (
  `address_id` int(9) NOT NULL,
  `customer_id` int(8) DEFAULT NULL,
  `staff_id` int(6) DEFAULT NULL,
  `post_code` varchar(8) NOT NULL,
  `name` varchar(100) NOT NULL,
  `line1` varchar(140) NOT NULL,
  `line2` varchar(140) DEFAULT NULL,
  `town_city` varchar(80) NOT NULL,
  `county_state` varchar(80) NOT NULL,
  `country` int(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `appointments`
--

CREATE TABLE `appointments` (
  `appointment_id` int(8) NOT NULL,
  `customer_id` int(8) DEFAULT NULL,
  `staff_id` int(6) DEFAULT NULL,
  `pet_id` int(9) DEFAULT NULL,
  `base_fee` decimal(5,2) NOT NULL,
  `date` date NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `status` enum('Open','Cancelled','Completed','') NOT NULL,
  `create_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `appointment_species_services`
--

CREATE TABLE `appointment_species_services` (
  `appointment_id` int(8) NOT NULL,
  `species_services_id` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `brands`
--

CREATE TABLE `brands` (
  `brand_id` int(4) NOT NULL,
  `name` varchar(80) NOT NULL,
  `contact_email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `brands`
--

INSERT INTO `brands` (`brand_id`, `name`, `contact_email`) VALUES
(1, 'Activyl', 'contact@activyl.com'),
(2, 'Adaxio', 'support@adaxio.co.uk'),
(3, 'Advantix', 'contact@advantix.co.uk'),
(4, 'Dechra', 'stock@dechramedications.org');

-- --------------------------------------------------------

--
-- Table structure for table `breeds`
--

CREATE TABLE `breeds` (
  `breed_id` int(5) NOT NULL,
  `species_id` int(3) NOT NULL,
  `name` varchar(100) NOT NULL,
  `lifespan_min` int(2) NOT NULL,
  `lifespan_max` int(2) NOT NULL,
  `male_weight_min_kg` decimal(3,1) NOT NULL,
  `male_weight_max_kg` decimal(3,1) NOT NULL,
  `female_weight_min_kg` decimal(3,1) NOT NULL,
  `female_weight_max_kg` decimal(3,1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `breeds`
--

INSERT INTO `breeds` (`breed_id`, `species_id`, `name`, `lifespan_min`, `lifespan_max`, `male_weight_min_kg`, `male_weight_max_kg`, `female_weight_min_kg`, `female_weight_max_kg`) VALUES
(1, 2, 'Basset Hound', 10, 12, '23.0', '29.0', '20.0', '27.0'),
(2, 1, 'Beagle', 12, 15, '13.0', '16.0', '11.0', '13.0'),
(3, 3, 'Border Collie', 12, 15, '19.0', '24.0', '18.0', '22.0'),
(4, 2, 'Cocker Spaniel', 12, 14, '13.0', '16.0', '12.0', '15.0'),
(5, 1, 'French Bulldog', 10, 12, '12.0', '15.0', '10.0', '11.0'),
(6, 3, 'Labrador Retriever', 10, 12, '29.0', '36.0', '25.0', '31.0'),
(7, 4, 'Mastiff', 10, 12, '50.0', '59.0', '41.0', '50.0'),
(8, 2, 'English Cocker Spaniel', 12, 14, '13.0', '16.0', '12.0', '15.0'),
(9, 1, 'Dachshund', 13, 16, '4.0', '5.0', '4.0', '5.0'),
(10, 2, 'Staffordshire Bull Terrier', 12, 14, '13.0', '17.0', '11.0', '15.5'),
(11, 1, 'Toy Poodle', 14, 16, '3.5', '5.5', '3.5', '5.5'),
(12, 1, 'Miniature Poodle', 14, 16, '7.0', '8.0', '5.5', '7.0'),
(13, 2, 'Standard Poodle', 12, 15, '20.0', '32.0', '20.0', '27.0'),
(14, 1, 'Maltese', 15, 18, '2.0', '4.0', '2.0', '4.0'),
(15, 1, 'Jack Russell Terrier', 13, 16, '6.0', '8.0', '5.0', '7.0'),
(16, 2, 'Kelpie', 10, 14, '20.5', '25.0', '14.0', '21.0'),
(17, 1, 'Pug', 12, 15, '6.0', '9.0', '6.0', '8.0'),
(18, 3, 'Rottweiler', 8, 11, '45.5', '54.5', '36.0', '41.0'),
(19, 4, 'Newfoundland', 9, 12, '64.0', '69.0', '50.0', '54.0'),
(20, 1, 'Norfolk Terrier', 12, 15, '5.0', '6.0', '5.0', '6.0'),
(21, 2, 'Siberian Husky', 12, 14, '20.0', '27.0', '16.0', '23.0'),
(22, 1, 'West Highland Terrier', 12, 16, '8.0', '9.0', '7.0', '8.0'),
(23, 2, 'Whippet', 12, 15, '10.0', '13.0', '8.0', '11.0'),
(25, 1, 'Yorkshire Terrier', 12, 16, '3.0', '4.0', '3.0', '4.0'),
(26, 1, 'Shih Tzu', 10, 16, '4.5', '8.1', '4.0', '7.2'),
(27, 2, 'Shetland Sheepdog', 12, 14, '8.0', '12.3', '6.4', '10.3'),
(28, 1, 'Lhasa Apso', 12, 15, '7.0', '8.0', '6.0', '7.0'),
(29, 4, 'Great Dane', 7, 10, '54.0', '80.0', '45.0', '59.0'),
(30, 2, 'English Springer Spaniel', 10, 14, '20.0', '25.0', '18.0', '23.0'),
(31, 2, 'Doberman Pinscher', 10, 12, '34.0', '41.0', '29.5', '36.0'),
(32, 1, 'Cavalier King Charles Spaniel', 10, 14, '5.0', '9.0', '5.0', '8.0'),
(33, 2, 'Boxer', 10, 12, '30.0', '32.0', '25.0', '27.0'),
(34, 1, 'Boston Terrier', 12, 15, '6.0', '11.0', '4.5', '9.0'),
(35, 3, 'Golden Retriever', 10, 12, '31.7', '36.3', '27.2', '31.7'),
(36, 3, 'German Shepherd', 10, 13, '34.0', '38.5', '27.0', '32.0'),
(37, 1, 'Chihuahua', 14, 18, '1.5', '3.0', '1.5', '3.0'),
(38, 1, 'Miniature Schnauzer', 12, 14, '5.0', '8.2', '4.5', '6.8'),
(39, 2, 'Standard Schnauzer', 12, 15, '16.0', '23.0', '14.0', '20.0');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(8) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `phone_number` varchar(15) NOT NULL,
  `membership` tinyint(1) NOT NULL,
  `referral_id` int(8) DEFAULT NULL,
  `create_date` datetime NOT NULL,
  `active` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `first_name`, `last_name`, `email`, `password`, `phone_number`, `membership`, `referral_id`, `create_date`, `active`) VALUES
(1, 'John', 'Mckenzie', 'jmckenzie79@gmail.com', '4d3363440f5889e947752bc1f610ba9c', '01632 960311', 0, NULL, '2022-02-25 13:25:47', 1),
(2, 'Michael', 'Aroste', 'michael2934@gmail.com', '9b893a322272de3c1be21b306f17b44a', '07715492519', 0, NULL, '2022-02-13 12:38:12', 1),
(3, 'Zach', 'Power', 'zachpower@zachy.com', '89c664a844c5e9f7b0e61115432321b4', '07700900897', 1, NULL, '2022-02-25 13:25:47', 1),
(4, 'Timothy', 'Evans', 'timothyevans1975@hotmail.co.uk', 'c7aefe6b4d47449f7321e38af26fd62a', '07485765696', 0, NULL, '2022-02-19 23:16:41', 1),
(5, 'Claire', 'Mickleback', 'clairemback@gmail.com', '3b421f4d421e38e47a5955f38fc38dee', '07247765696', 1, NULL, '2022-02-19 23:16:41', 1),
(6, 'Caitlin', 'Relevance', 'caitie293@gmail.com', '9255b240bdcf71b90ca2bfaa98ade274', '07713492519', 1, NULL, '2022-02-23 12:03:35', 1),
(7, 'Jackie', 'Simons', 'jackiesimons@hotmail.co.uk', '698008228ba12217215f613c611e5a12', '07707318470 ', 0, NULL, '2022-02-23 12:03:35', 1),
(8, 'James ', 'Lee', 'jameslee2843@gmail.com', '227f235d7248693cce0366bf4d662807', '07033422077', 1, NULL, '2022-02-23 12:06:01', 1),
(9, 'Isla', 'Harris', 'isalert@gmail.com', '84485d611e085e1ea599d7a7e69f27e9', '07952265540', 1, 17596248, '2022-02-23 12:08:35', 1),
(10, 'Edward ', 'Bardot', 'eddie219@hotmail.com', '3076ff6270dbb3d4f622e2a7772ea8a5', '07870594058', 0, NULL, '2022-02-23 12:08:35', 1),
(11, 'Andres ', 'Bandini', 'andresss96@gmail.com', 'fcec03f2617126385866b06c9f7f2b2e', '07713626192', 1, NULL, '2022-02-23 12:08:35', 1),
(12, 'Adalyn ', 'Williams   ', 'sweeper73@yahoo.co.uk', '4f167c88a370950091532f6181d64ff0', '07706476537', 0, NULL, '2022-02-23 12:08:35', 1),
(13, 'Joshua ', 'Raven', 'joshyr@protonmail.com', '482c811da5d5b4bc6d497ffa98491e38', '07981169736', 0, NULL, '2022-02-23 12:08:35', 1),
(14, 'Hope ', 'Jones', 'hopejones@hotmail.co.uk', 'd34af4de670506a78b509affa95b7e0d', '07856311924', 1, NULL, '2022-02-23 12:08:35', 1),
(15, 'Kevin ', 'Hernandez', 'kevinhernando@gmail.com', '8c7f74ecef7fa8c8f5070e99972a3bdd', '07827470345', 0, NULL, '2022-02-23 12:08:35', 1),
(16, 'Juliana ', 'Nelson', 'julie98@gmail.com', '2fec1dc0bf947d808f126cbd5ff48758', '07038165584', 1, NULL, '2022-02-23 12:08:35', 1),
(17, 'Arlo ', 'Holly', 'arloholl@protonmail.com', '07f6ba2e6ba3e3f4c4450b8a17a9d469', '07803588229', 0, NULL, '2022-02-23 12:08:35', 1),
(18, 'Finley', ' Noel', 'finleynoel237@hotmail.co.uk', '68e55846cc01544533808d605ae0543e', '07048734359', 1, NULL, '2022-02-23 12:08:35', 1);

-- --------------------------------------------------------

--
-- Table structure for table `medications`
--

CREATE TABLE `medications` (
  `medication_id` int(6) NOT NULL,
  `brand_id` int(4) NOT NULL,
  `name` varchar(100) NOT NULL,
  `description` varchar(200) NOT NULL,
  `standard_dosage_mg` int(6) NOT NULL,
  `unit_purchase_cost` decimal(8,2) NOT NULL,
  `unit_sale_price` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `medication_sizes`
--

CREATE TABLE `medication_sizes` (
  `medication_id` int(6) NOT NULL,
  `sizes_id` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `payment_details`
--

CREATE TABLE `payment_details` (
  `payment_details_id` int(9) NOT NULL,
  `customer_id` int(8) DEFAULT NULL,
  `staff_id` int(6) DEFAULT NULL,
  `name` varchar(100) NOT NULL,
  `card_number` varchar(16) NOT NULL,
  `expiry_date` date NOT NULL,
  `security_code` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `payment_details`
--

INSERT INTO `payment_details` (`payment_details_id`, `customer_id`, `staff_id`, `name`, `card_number`, `expiry_date`, `security_code`) VALUES
(1, NULL, NULL, 'John Mckenzie', '4598214596584126', '2024-02-08', 695),
(2, 4, NULL, 'Timothy Evans', '4598654785965486', '2025-04-24', 658);

-- --------------------------------------------------------

--
-- Table structure for table `pescriptions`
--

CREATE TABLE `pescriptions` (
  `pescription_id` int(9) NOT NULL,
  `medication_id` int(6) NOT NULL,
  `pet_id` int(9) NOT NULL,
  `staff_id` int(6) NOT NULL,
  `quantity` int(2) NOT NULL,
  `dosage_Interval` int(2) DEFAULT NULL,
  `dosage_amount` varchar(20) DEFAULT NULL,
  `repeat_interval` int(3) DEFAULT NULL,
  `total_repeats` int(3) DEFAULT NULL,
  `current_repeat` int(3) NOT NULL,
  `issue_date` date NOT NULL,
  `expiration_date` date NOT NULL,
  `active` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `pets`
--

CREATE TABLE `pets` (
  `pet_id` int(9) NOT NULL,
  `customer_id` int(8) DEFAULT NULL,
  `breed_id` int(5) DEFAULT NULL,
  `name` varchar(50) NOT NULL,
  `gender` enum('Male','Female','','') NOT NULL,
  `chip_number` bigint(15) DEFAULT NULL,
  `birth_date` date NOT NULL,
  `notes` text DEFAULT NULL,
  `create_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pets`
--

INSERT INTO `pets` (`pet_id`, `customer_id`, `breed_id`, `name`, `gender`, `chip_number`, `birth_date`, `notes`, `create_date`) VALUES
(1, 1, 33, 'Kisbo', 'Male', 142542534942472, '2016-05-20', NULL, '2022-02-25 13:38:54'),
(2, 2, 3, 'Cassie', 'Female', 718162135787888, '2013-02-03', 'Back issues since young', '2022-02-25 13:38:54'),
(5, 3, 37, 'Princess', 'Female', 329481406153596, '2015-08-07', NULL, '2022-02-25 13:41:11'),
(6, 3, 9, 'Sasuage', 'Male', 748440507856581, '2010-02-16', 'Broke back, now needs back wheels to support spine', '2022-02-25 13:41:11'),
(7, 4, 12, 'Matty', 'Male', NULL, '2015-02-10', NULL, '2022-02-25 13:43:17'),
(8, 5, 29, 'Danny', 'Male', 217484825035359, '2017-06-16', NULL, '2022-02-25 13:43:17'),
(9, 7, 2, 'Snoopy', 'Male', 183485468774508, '2021-11-18', NULL, '2022-02-25 13:58:09'),
(10, 7, 4, 'Mia', 'Female', 632165385604436, '2020-05-16', NULL, '2022-02-25 13:58:09');

-- --------------------------------------------------------

--
-- Table structure for table `pet_weights`
--

CREATE TABLE `pet_weights` (
  `pets_weights_id` int(10) NOT NULL,
  `pets_id` int(9) NOT NULL,
  `weight` decimal(3,1) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pet_weights`
--

INSERT INTO `pet_weights` (`pets_weights_id`, `pets_id`, `weight`, `date`) VALUES
(1, 1, '30.0', '2019-12-18'),
(2, 2, '10.0', '2017-10-18'),
(3, 2, '11.0', '2020-04-16'),
(4, 5, '2.0', '2020-06-24'),
(5, 5, '2.3', '2021-11-12'),
(6, 5, '2.6', '2022-01-07'),
(7, 6, '6.0', '2020-04-10'),
(8, 6, '7.0', '2021-04-02'),
(9, 6, '6.5', '2022-01-27'),
(10, 7, '5.6', '2021-04-09'),
(11, 8, '50.0', '2020-04-24'),
(12, 8, '56.0', '2021-05-14'),
(13, 8, '60.0', '2022-02-11'),
(14, 9, '8.0', '2022-01-27'),
(15, 10, '13.0', '2022-03-18');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `service_id` int(4) NOT NULL,
  `name` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `cost` decimal(6,2) NOT NULL,
  `average_time` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `sizes`
--

CREATE TABLE `sizes` (
  `sizes_id` int(7) NOT NULL,
  `size_description` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `species`
--

CREATE TABLE `species` (
  `species_id` int(3) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `species`
--

INSERT INTO `species` (`species_id`, `name`) VALUES
(1, 'Small Dog'),
(2, 'Medium Dog'),
(3, 'Large Dog'),
(4, 'Extra Large Dog'),
(5, 'Small Cat'),
(6, 'Medium Cat'),
(7, 'Large Cat'),
(8, 'Extra large Cat');

-- --------------------------------------------------------

--
-- Table structure for table `species_medications`
--

CREATE TABLE `species_medications` (
  `species_id` int(3) NOT NULL,
  `medication_id` int(6) NOT NULL,
  `dosage_mg` int(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `species_services`
--

CREATE TABLE `species_services` (
  `species_service_id` int(6) NOT NULL,
  `species_id` int(3) NOT NULL,
  `service_id` int(4) NOT NULL,
  `cost` decimal(6,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `species_services_comp`
--

CREATE TABLE `species_services_comp` (
  `species_id` int(3) NOT NULL,
  `services_id` int(4) NOT NULL,
  `cost` decimal(7,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `species_service_medications`
--

CREATE TABLE `species_service_medications` (
  `species_service_id` int(6) NOT NULL,
  `medication_id` int(6) NOT NULL,
  `dosage_mg` int(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `staff_id` int(6) NOT NULL,
  `position` enum('Practitioner','Nurse','Receptionist','Stock','Finance','Manager') NOT NULL,
  `email` varchar(100) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `phone_number` varchar(15) NOT NULL,
  `gender` enum('Male','Female','Other','') NOT NULL,
  `ni_number` varchar(13) DEFAULT NULL,
  `create_date` datetime NOT NULL,
  `active` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staff_id`, `position`, `email`, `first_name`, `last_name`, `password`, `phone_number`, `gender`, `ni_number`, `create_date`, `active`) VALUES
(6, 'Practitioner', 'isaacw283@gmail.com', 'Isaac', 'Winfrey', '82038d065a08819e8a221d11930416c4', '01569845263', 'Male', 'KT379646D', '2022-02-16 17:29:47', 1),
(7, 'Practitioner', 'emmanuel283@gmail.com', 'Emmanuel ', 'Martinez', '9695ca506f1c51da91c3a3ef94b30988', '07978163447', 'Male', 'ZG 92 40 50 D', '2022-02-23 12:16:12', 1),
(8, 'Receptionist', 'natalicullen76@hotmail.co.uk', 'Natalia ', 'Cullen', '9196dc3b2412e033bf0680d37658f011', '07885023587', 'Female', 'OP 65 78 17 C', '2022-02-23 12:18:08', 1),
(9, 'Nurse', 'cartermadison@yahoo.co.uk', 'Carter ', 'Madison', 'a3de77d271534a46c682629a832def0d', '07743886047', 'Female', 'CB 16 96 81 D', '2022-02-23 12:18:51', 1),
(10, 'Stock', 'jonahhh123@gmail.com', 'Jonah', 'Flores', 'faa8a3789840ebe50c4e913683ca74a4', '07808388045', 'Male', 'YE 85 29 73 A', '2022-02-23 12:18:51', 1);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `transaction_id` int(10) NOT NULL,
  `appointment_id` int(8) NOT NULL,
  `staff_id` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `transaction_medications`
--

CREATE TABLE `transaction_medications` (
  `transaction_id` int(10) NOT NULL,
  `medication_id` int(8) NOT NULL,
  `quantity` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addresses`
--
ALTER TABLE `addresses`
  ADD PRIMARY KEY (`address_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `staff_id` (`staff_id`);

--
-- Indexes for table `appointments`
--
ALTER TABLE `appointments`
  ADD PRIMARY KEY (`appointment_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `staff_id` (`staff_id`),
  ADD KEY `pet_id` (`pet_id`);

--
-- Indexes for table `appointment_species_services`
--
ALTER TABLE `appointment_species_services`
  ADD PRIMARY KEY (`appointment_id`,`species_services_id`),
  ADD KEY `species_services_id` (`species_services_id`);

--
-- Indexes for table `brands`
--
ALTER TABLE `brands`
  ADD PRIMARY KEY (`brand_id`);

--
-- Indexes for table `breeds`
--
ALTER TABLE `breeds`
  ADD PRIMARY KEY (`breed_id`),
  ADD KEY `species_id` (`species_id`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `medications`
--
ALTER TABLE `medications`
  ADD PRIMARY KEY (`medication_id`),
  ADD KEY `brand_id` (`brand_id`);

--
-- Indexes for table `medication_sizes`
--
ALTER TABLE `medication_sizes`
  ADD PRIMARY KEY (`medication_id`,`sizes_id`),
  ADD KEY `sizes_id` (`sizes_id`);

--
-- Indexes for table `payment_details`
--
ALTER TABLE `payment_details`
  ADD PRIMARY KEY (`payment_details_id`),
  ADD KEY `payment_details_ibfk_1` (`customer_id`),
  ADD KEY `payment_details_ibfk_2` (`staff_id`);

--
-- Indexes for table `pescriptions`
--
ALTER TABLE `pescriptions`
  ADD PRIMARY KEY (`pescription_id`),
  ADD KEY `medication_id` (`medication_id`),
  ADD KEY `pet_id` (`pet_id`),
  ADD KEY `staff_id` (`staff_id`);

--
-- Indexes for table `pets`
--
ALTER TABLE `pets`
  ADD PRIMARY KEY (`pet_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `breed_id` (`breed_id`);

--
-- Indexes for table `pet_weights`
--
ALTER TABLE `pet_weights`
  ADD PRIMARY KEY (`pets_weights_id`),
  ADD KEY `pets_id` (`pets_id`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`service_id`);

--
-- Indexes for table `sizes`
--
ALTER TABLE `sizes`
  ADD PRIMARY KEY (`sizes_id`);

--
-- Indexes for table `species`
--
ALTER TABLE `species`
  ADD PRIMARY KEY (`species_id`);

--
-- Indexes for table `species_medications`
--
ALTER TABLE `species_medications`
  ADD PRIMARY KEY (`species_id`,`medication_id`),
  ADD KEY `medication_id` (`medication_id`);

--
-- Indexes for table `species_services`
--
ALTER TABLE `species_services`
  ADD PRIMARY KEY (`species_service_id`),
  ADD KEY `species_id` (`species_id`),
  ADD KEY `service_id` (`service_id`);

--
-- Indexes for table `species_services_comp`
--
ALTER TABLE `species_services_comp`
  ADD PRIMARY KEY (`species_id`,`services_id`),
  ADD KEY `services_id` (`services_id`);

--
-- Indexes for table `species_service_medications`
--
ALTER TABLE `species_service_medications`
  ADD PRIMARY KEY (`species_service_id`,`medication_id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`transaction_id`);

--
-- Indexes for table `transaction_medications`
--
ALTER TABLE `transaction_medications`
  ADD PRIMARY KEY (`transaction_id`,`medication_id`),
  ADD KEY `medication_id` (`medication_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addresses`
--
ALTER TABLE `addresses`
  MODIFY `address_id` int(9) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `appointments`
--
ALTER TABLE `appointments`
  MODIFY `appointment_id` int(8) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `brands`
--
ALTER TABLE `brands`
  MODIFY `brand_id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `breeds`
--
ALTER TABLE `breeds`
  MODIFY `breed_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `medications`
--
ALTER TABLE `medications`
  MODIFY `medication_id` int(6) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `payment_details`
--
ALTER TABLE `payment_details`
  MODIFY `payment_details_id` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `pescriptions`
--
ALTER TABLE `pescriptions`
  MODIFY `pescription_id` int(9) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pets`
--
ALTER TABLE `pets`
  MODIFY `pet_id` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `pet_weights`
--
ALTER TABLE `pet_weights`
  MODIFY `pets_weights_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `service_id` int(4) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sizes`
--
ALTER TABLE `sizes`
  MODIFY `sizes_id` int(7) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `species`
--
ALTER TABLE `species`
  MODIFY `species_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `species_services`
--
ALTER TABLE `species_services`
  MODIFY `species_service_id` int(6) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `staff_id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `transaction_id` int(10) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `addresses`
--
ALTER TABLE `addresses`
  ADD CONSTRAINT `addresses_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`),
  ADD CONSTRAINT `addresses_ibfk_2` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`);

--
-- Constraints for table `appointments`
--
ALTER TABLE `appointments`
  ADD CONSTRAINT `appointments_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `appointments_ibfk_2` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `appointments_ibfk_3` FOREIGN KEY (`pet_id`) REFERENCES `pets` (`pet_id`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `appointment_species_services`
--
ALTER TABLE `appointment_species_services`
  ADD CONSTRAINT `appointment_species_services_ibfk_1` FOREIGN KEY (`appointment_id`) REFERENCES `appointments` (`appointment_id`),
  ADD CONSTRAINT `appointment_species_services_ibfk_2` FOREIGN KEY (`species_services_id`) REFERENCES `species_services` (`species_service_id`);

--
-- Constraints for table `breeds`
--
ALTER TABLE `breeds`
  ADD CONSTRAINT `breeds_ibfk_1` FOREIGN KEY (`species_id`) REFERENCES `species` (`species_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `medications`
--
ALTER TABLE `medications`
  ADD CONSTRAINT `medications_ibfk_1` FOREIGN KEY (`brand_id`) REFERENCES `brands` (`brand_id`);

--
-- Constraints for table `medication_sizes`
--
ALTER TABLE `medication_sizes`
  ADD CONSTRAINT `medication_sizes_ibfk_1` FOREIGN KEY (`medication_id`) REFERENCES `medications` (`medication_id`),
  ADD CONSTRAINT `medication_sizes_ibfk_2` FOREIGN KEY (`sizes_id`) REFERENCES `sizes` (`sizes_id`);

--
-- Constraints for table `payment_details`
--
ALTER TABLE `payment_details`
  ADD CONSTRAINT `payment_details_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `payment_details_ibfk_2` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pescriptions`
--
ALTER TABLE `pescriptions`
  ADD CONSTRAINT `pescriptions_ibfk_1` FOREIGN KEY (`pet_id`) REFERENCES `pets` (`pet_id`),
  ADD CONSTRAINT `pescriptions_ibfk_2` FOREIGN KEY (`medication_id`) REFERENCES `medications` (`medication_id`),
  ADD CONSTRAINT `pescriptions_ibfk_3` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`);

--
-- Constraints for table `pets`
--
ALTER TABLE `pets`
  ADD CONSTRAINT `pets_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `pets_ibfk_2` FOREIGN KEY (`breed_id`) REFERENCES `breeds` (`breed_id`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `pet_weights`
--
ALTER TABLE `pet_weights`
  ADD CONSTRAINT `pet_weights_ibfk_1` FOREIGN KEY (`pets_id`) REFERENCES `pets` (`pet_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `species_medications`
--
ALTER TABLE `species_medications`
  ADD CONSTRAINT `species_medications_ibfk_1` FOREIGN KEY (`medication_id`) REFERENCES `medications` (`medication_id`);

--
-- Constraints for table `species_services`
--
ALTER TABLE `species_services`
  ADD CONSTRAINT `species_services_ibfk_1` FOREIGN KEY (`species_id`) REFERENCES `species` (`species_id`),
  ADD CONSTRAINT `species_services_ibfk_2` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`);

--
-- Constraints for table `species_services_comp`
--
ALTER TABLE `species_services_comp`
  ADD CONSTRAINT `species_services_comp_ibfk_1` FOREIGN KEY (`services_id`) REFERENCES `services` (`service_id`),
  ADD CONSTRAINT `species_services_comp_ibfk_2` FOREIGN KEY (`species_id`) REFERENCES `species` (`species_id`);

--
-- Constraints for table `transaction_medications`
--
ALTER TABLE `transaction_medications`
  ADD CONSTRAINT `transaction_medications_ibfk_1` FOREIGN KEY (`medication_id`) REFERENCES `medications` (`medication_id`),
  ADD CONSTRAINT `transaction_medications_ibfk_2` FOREIGN KEY (`transaction_id`) REFERENCES `transactions` (`transaction_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
