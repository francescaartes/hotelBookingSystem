# Hotel Booking System
Welcome to THE SYNTAX HOTEL Booking System! This console application was developed as a school project for our Object-Oriented Programming (OOP) subject. The system allows users to book hotel rooms, view room prices, manage bookings, and cancel reservations.

## Usage
The main menu provides the following options:

1. Book a hotel room: Allows users to book a room by providing their name, selecting a room type, and specifying check-in and check-out dates.
2. View hotel room prices: Displays the prices for Standard, Deluxe, and Suite rooms.
3. View bookings: Shows a list of all current bookings, including guest names, check-in and check-out dates, room type, room number, and total price.
4. Cancel booking: Enables users to cancel a booking by entering the guest's name.
5. Exit: Exits the program.

## Features
* Dynamic Room Availability: Rooms are dynamically marked as available or unavailable based on the user's selection.
* Random Room Numbers: Room numbers are randomly generated based on the room type.
* Booking Confirmation: Users can confirm their bookings and receive a detailed confirmation message.

## Classes
* HotelBookingSystem: The main class containing the program logic and user interface.
* Booking: Represents a hotel booking with details such as guest name, check-in and check-out dates, room type, room number, and total price.
* Room: Abstract class for different room types, providing common functionality.
* StandardRoom, DeluxeRoom, SuiteRoom: Derived classes representing specific room types, each with unique characteristics.

## Contributors
Francesca Q. Artes