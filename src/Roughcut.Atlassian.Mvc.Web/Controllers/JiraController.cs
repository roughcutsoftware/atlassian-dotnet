using System.Diagnostics;
using FizzWare.NBuilder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roughcut.Atlassian.ClientServices.Dtos;
using Roughcut.Atlassian.ClientServices.Services;
using Roughcut.Atlassian.Interfaces.AppConfig;
using Roughcut.Atlassian.Interfaces.Services;
using Roughcut.Atlassian.Mvc.Web.Models;

namespace Roughcut.Atlassian.Mvc.Web.Controllers
{
    public class JiraController : Controller
    {
        JiraService<IssueUpInsertDto> _jiraService;

        // get secretservice from dependency injection
        private readonly SecretsService _secretsService;

        // create jira-issue-service
        private JiraIssueService _issueService { get; set; }




        public JiraController(SecretsService secretsService)
        {
            // set secrets service
            this._secretsService = secretsService;

            // create jira-issue-service
            this._issueService = new JiraIssueService();

            // get jira base url from secrets service
            string jiraBaseUrl = _secretsService.GetSecrets<JiraApiSettings>().JiraBaseUrl;

            // get jira username and api token from secrets service
            string jiraUsername = _secretsService.GetSecrets<JiraApiSettings>().JiraLoginUserName;
            string jiraApiToken = _secretsService.GetSecrets<JiraApiSettings>().JiraApiAccessKeyId;

            // string jiraBaseUrl = "https://jira-cloud-demo.atlassian.net/rest/api/2";
            this._jiraService = new JiraService<IssueUpInsertDto>(jiraBaseUrl, jiraUsername, jiraApiToken);
            
        }
        // GET: JiraController
        public ActionResult Index()
        {
            return View();
        }

        //// GET: JiraController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: JiraController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Jira jira)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Save the Jira object to the database
        //        return RedirectToAction("Index");
        //    }

        //    return View(jira);
        //}

        // POST: JiraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                // debug breakpoint
                string breakpoint = "debug";

                // get issuedto from form
                var issueDto = new IssueDto
                {
                    Description = collection["Description"] + "\n\n ** Created at: " + DateTime.Now.ToString("F"),
                    Summary = collection["Summary"],
                    IssueType = collection["IssueType"] 
                };

                // create issue upsert dto
                var issueUpInsert = _issueService.CreateIssue(issueDto);

                // TODO: Add insert of 'jira-story' logic here
                // create new fake issue
                //var issueDto = Builder<IssueDto>
                //    .CreateNew()
                //    //.With(x => x = "BANK")
                //    .With(x => x.Description = "A custom description here")
                //    .With(x => x.Summary = "Story - Add-Test - " + DateTime.Now.ToString("F"))
                //    .With(x => x.IssueType = "Story")
                //    //.With(x => x.)
                //    .Build();

                // try to add the issue, and wait for the response - write error if it fails
                try
                {

                    //
                    await _jiraService.AddAsync(issueUpInsert, true);
                }
                catch (Exception exc)
                {

                    // create error message with inner exception
                    string errorMessage = "Error: " + exc.Message + " Inner Exception: " + exc.InnerException.Message;

                    // create error view with error message
                    var errorViewModel = new ErrorViewModel
                    {
                        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                        Message = errorMessage
                    };
                    return View("Error", errorViewModel);

                    Console.WriteLine(exc);

                    
                    throw;
                }






                // return to index
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //// GET: JiraController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: JiraController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: JiraController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: JiraController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
