result = """ """


data = (
    ('Scrimshawed Whale Tooth', '2A', 'Deserted Docks', ('2', 'A'), 'Blue'),
    ('Brass Spyglass', '4B', 'Abandoned Lighthouse', ('4', 'B'), 'Blue')
)


result = """\n"""
for outer in data:
    result += str(outer[0:1] + outer[2::]) + "\n"
    
print(result)
