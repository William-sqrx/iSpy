import scrapy
import json

class ProductSpider(scrapy.Spider):
    name = "products"

    def start_requests(self):
        urls = [
            "https://www.amazon.com/s?k=men+shirts",
            "https://www.walmart.com/browse/clothing/men-shirts/5438_133197",
            "https://www.target.com/c/men-s-shirts/-/N-5xu2f",
            "https://www.instacart.com/store/items/organic-apples",
        ]
        for url in urls:
            yield scrapy.Request(url=url, callback=self.parse)

    def parse(self, response):
        products = []

        if "amazon.com" in response.url:
            for product in response.css(".s-main-slot .s-result-item"):
                products.append({
                    "name": product.css("h2 .a-link-normal::text").get(),
                    "price": product.css(".a-price-whole::text").get(),
                    "location": "Amazon",
                    "url": response.urljoin(product.css("h2 .a-link-normal::attr(href)").get()),
                })

        elif "walmart.com" in response.url:
            for product in response.css(".search-result-gridview-item"):
                products.append({
                    "name": product.css(".product-title-link span::text").get(),
                    "price": product.css(".price-main span::text").get(),
                    "location": "Walmart",
                    "url": response.urljoin(product.css(".product-title-link::attr(href)").get()),
                })

        elif "target.com" in response.url:
            for product in response.css(".styles__StyledProductCard"):
                products.append({
                    "name": product.css(".styles__Title-sc::text").get(),
                    "price": product.css(".styles__PriceText-sc::text").get(),
                    "location": "Target",
                    "url": response.urljoin(product.css("a::attr(href)").get()),
                })

        elif "instacart.com" in response.url:
            for product in response.css(".item"):
                products.append({
                    "name": product.css(".item-title::text").get(),
                    "price": product.css(".price::text").get(),
                    "location": "Instacart",
                    "url": response.urljoin(product.css(".item-link::attr(href)").get()),
                })

        with open("scraped_products.json", "w") as f:
            json.dump(products, f, indent=2)

        self.log(f"Scraped {len(products)} products from {response.url}")