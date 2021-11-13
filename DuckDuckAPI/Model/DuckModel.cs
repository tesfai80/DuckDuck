namespace DuckDuckAPI.Model
{
    
        public class DuckModel
    {
 
            public string Abstract { get; set; }
            public string AbstractSource { get; set; }
            public string AbstractText { get; set; }
            public string AbstractURL { get; set; }
            public string Answer { get; set; }
            public string AnswerType { get; set; }
            public string Definition { get; set; }
            public string DefinitionSource { get; set; }
            public string DefinitionURL { get; set; }
            public string Entity { get; set; }
            public string Heading { get; set; }
            public string Image { get; set; }
            public int ImageHeight { get; set; }
            public int ImageIsLogo { get; set; }
            public int ImageWidth { get; set; }
            public string Infobox { get; set; }
            public string Redirect { get; set; }
            public Relatedtopic[] RelatedTopics { get; set; }
            public object[] Results { get; set; }
            public string Type { get; set; }
            public Meta meta { get; set; }
        }
        public class Meta
        {
            public object attribution { get; set; }
            public object blockgroup { get; set; }
            public object created_date { get; set; }
            public string description { get; set; }
            public object designer { get; set; }
            public object dev_date { get; set; }
            public string dev_milestone { get; set; }
            public Developer[] developer { get; set; }
            public string example_query { get; set; }
            public string id { get; set; }
            public object is_stackexchange { get; set; }
            public string js_callback_name { get; set; }
            public object live_date { get; set; }
            public Maintainer maintainer { get; set; }
            public string name { get; set; }
            public string perl_module { get; set; }
            public object producer { get; set; }
            public string production_state { get; set; }
            public string repo { get; set; }
            public string signal_from { get; set; }
            public string src_domain { get; set; }
            public int src_id { get; set; }
            public string src_name { get; set; }
            public Src_Options src_options { get; set; }
            public object src_url { get; set; }
            public string status { get; set; }
            public string tab { get; set; }
            public string[] topic { get; set; }
            public int _unsafe { get; set; }
        }
        public class Maintainer
        {
            public string github { get; set; }
        }
        public class Src_Options
        {
            public string directory { get; set; }
            public int is_fanon { get; set; }
            public int is_mediawiki { get; set; }
            public int is_wikipedia { get; set; }
            public string language { get; set; }
            public string min_abstract_length { get; set; }
            public int skip_abstract { get; set; }
            public int skip_abstract_paren { get; set; }
            public string skip_end { get; set; }
            public int skip_icon { get; set; }
            public int skip_image_name { get; set; }
            public string skip_qr { get; set; }
            public string source_skip { get; set; }
            public string src_info { get; set; }
        }
        public class Developer
        {
            public string name { get; set; }
            public string type { get; set; }
            public string url { get; set; }
        }
        public class Relatedtopic
        {
            public string FirstURL { get; set; }
            public Icon Icon { get; set; }
            public string Result { get; set; }
            public string Text { get; set; }
            public string Name { get; set; }
            public Topic[] Topics { get; set; }
        }
        public class Icon
        {
            public object Height { get; set; }
            public string URL { get; set; }
            public object Width { get; set; }
        }
        public class Topic
        {
            public string FirstURL { get; set; }
            public Icon1 Icon { get; set; }
            public string Result { get; set; }
            public string Text { get; set; }
        }
        public class Icon1
        {
            public object Height { get; set; }
            public string URL { get; set; }
            public object Width { get; set; }
        }

}
