//CREATE A WEB API WITH ASP.NET CORE CONTROLLERS

//CRUD actions in ASP.NET Core
/*
HTTP action verb	CRUD operation	    ASP.NET Core attribute
GET	                Read	            [HttpGet]
POST	            Create	            [HttpPost]
PUT	                Update	            [HttpPut]
DELETE	            Delete	            [HttpDelete]
*/


//POST
[HttpPost]
public IActionResult Create(Pizza pizza)
{            
    // This code will save the pizza and return a result
}


//PUT
[HttpPut("{id}")]
public IActionResult Update(int id, Pizza pizza)
{
    // This code will update the pizza and return a result
}


//DELETE
[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    // This code will delete the pizza and return a result
}