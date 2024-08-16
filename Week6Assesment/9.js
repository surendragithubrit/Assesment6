class Book {
    
    Book(title, author, publicationYear) {
        this.title = title;
        this.author = author;
        this.publicationYear = publicationYear;
    }

    
    Details() {
        console.log(`Title: ${this.title}`);
        console.log(`Author: ${this.author}`);
        console.log(`Publication Year: ${this.publicationYear}`);
    }
}


book1 = new Book("Gabber Signh","Pawan Kalyan",2014);
book2 = new Book("Bro", "Sai", 2020);


book1.Details();
book2.Details();
