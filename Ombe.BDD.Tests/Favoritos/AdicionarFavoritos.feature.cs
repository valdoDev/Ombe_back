﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Ombe.BDD.Tests.Favoritos
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class Favoritos_AdicionarFeature : object, Xunit.IClassFixture<Favoritos_AdicionarFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AdicionarFavoritos.feature"
#line hidden
        
        public Favoritos_AdicionarFeature(Favoritos_AdicionarFeature.FixtureData fixtureData, Ombe_BDD_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Favoritos", "Favoritos - Adicionar", "\tComo um usuario\r\n\tEu desejo cadastrar produto como favorito no app\r\n\tPara que eu" +
                    " possa utilizar das funcionalidades do app", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Adicionar favorito com sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "Favoritos - Adicionar")]
        [Xunit.TraitAttribute("Description", "Adicionar favorito com sucesso")]
        public void AdicionarFavoritoComSucesso()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adicionar favorito com sucesso", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
testRunner.Given("Que um usuario acesse opcao de cadastro favorito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 8
testRunner.When("O usuario inserir informacoes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 9
testRunner.And("tocar no botao cadastrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 10
testRunner.Then("O usuario recebera uma mensagem de sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Adicionar favorito existente")]
        [Xunit.TraitAttribute("FeatureTitle", "Favoritos - Adicionar")]
        [Xunit.TraitAttribute("Description", "Adicionar favorito existente")]
        public void AdicionarFavoritoExistente()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adicionar favorito existente", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
testRunner.Given("Que um usuario acesse opcao de cadastro favorito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 14
testRunner.When("O usuario inserir informacoes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 15
testRunner.And("tocar no botao cadastrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 16
testRunner.And("codigo produto e usuario ja estiverem cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 17
testRunner.Then("O usuario recebera uma mensagem de erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Adicionar favorito com dados incompletos")]
        [Xunit.TraitAttribute("FeatureTitle", "Favoritos - Adicionar")]
        [Xunit.TraitAttribute("Description", "Adicionar favorito com dados incompletos")]
        public void AdicionarFavoritoComDadosIncompletos()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adicionar favorito com dados incompletos", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
testRunner.Given("Que um usuario acesse opcao de cadastro favorito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 21
testRunner.When("O usuario inserir informacoes incompletas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 22
testRunner.And("tocar no botao cadastrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 23
testRunner.Then("O usuario recebera uma mensagem de erro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                Favoritos_AdicionarFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                Favoritos_AdicionarFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
